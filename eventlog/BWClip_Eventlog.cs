using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace log
{
    public class BWClip_Eventlog
    {
        public DataTable dt;
        public string fileName; public string filePath; long fileLength; public string binfile_header;
        string[] header_info = new string[20];

        //setting data table columns (.evl)
        public void SetUpData()
        {
            dt.Columns.Add("Serial Number");
            dt.Columns.Add("Firmware Version");
            dt.Columns.Add("Start Time");
            dt.Columns.Add("Start Time in UTC");
            dt.Columns.Add("Remaining Minutes");
            dt.Columns.Add("Remaining Life time");
            dt.Columns.Add("Sensor Type");
            dt.Columns.Add("Event Type");
            dt.Columns.Add("Peak Gas Reading");
            dt.Columns.Add("Duration of Alarm (seconds)");
            dt.Columns.Add("Low Alarm Pt");
            dt.Columns.Add("High Alarm Pt");
            dt.Columns.Add("Total Unit Alarm Time (minutes)");
            dt.Columns.Add("Remaining Hibernate time");
        }
        
        //setting data table columns (.bin)
        public void SetUpData_bin()
        {
            dt.Columns.Add("Serial Number");
            dt.Columns.Add("Start Time");
            dt.Columns.Add("Start Time in UTC");
            dt.Columns.Add("Remaining Minutes");
            dt.Columns.Add("Remaining Life time");
            dt.Columns.Add("Sensor Type");
            dt.Columns.Add("Event Type");
            dt.Columns.Add("Peak Gas Reading");
            dt.Columns.Add("Duration of Alarm (seconds)");
            dt.Columns.Add("Low Alarm Pt");
            dt.Columns.Add("High Alarm Pt");
            dt.Columns.Add("Total Unit Alarm Time (minutes)");
            dt.Columns.Add("Remaining Hibernate time");
        }

        //Get time
        static string bwTime(UInt32 input)
        {
            UInt16 min, hour, sec, year, month, day;

            min = (UInt16)(input & 0x3F);
            hour = (UInt16)((input & 0x7C0) >> 6);
            day = (UInt16)((input & 0xF800) >> 11);
            sec = (UInt16)((input & 0x3F0000) >> 16);
            month = (UInt16)((input & 0x3C00000) >> 22);
            year = (UInt16)((input & 0xFC000000) >> 26);
            
            string result = year + "/" + month + "/" + day + " " + hour + ":" + min + ":" + sec;
            return result;
        }
        
        //file 선택
        public void eventlog_parsing_bwc()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "file open";
            ofd.FileName = "test";
            ofd.Filter = "event log 파일|*.evl|bin 파일|*.bin";
            byte[] binfile;
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dt = new DataTable();
                fileName = ofd.SafeFileName;
                filePath = ofd.FileName;
                FileInfo fi = new FileInfo(filePath);
                fileLength = fi.Length;
                DataRow workRow;

                //.bin 파일 parsing
                if (Path.GetExtension(ofd.FileName) == ".bin")
                {
                    SetUpData_bin();
                    int cnt = 0;
                    binfile = File.ReadAllBytes(filePath);
                    string sn="";
                    int sz = binfile.Length; sz -= 40; cnt += 40;
                    for (int i = 0; i < 18; i++)
                    {
                        sn += Convert.ToChar(binfile[i]);
                    }
                    while (sz >= 21)
                    {
                        
                        workRow = dt.NewRow();
                        
                        workRow[0] = sn;
                        workRow[1] = bwTime(BitConverter.ToUInt32(binfile, 4+cnt));
                        workRow[2] = bwTime(BitConverter.ToUInt32(binfile, 8+cnt));
                        int mins = Convert.ToUInt16(binfile[14+cnt]);
                        int RemainMin = BitConverter.ToUInt16(binfile, 12+cnt) * 30 + mins;
                        workRow[3] = RemainMin;
                        int days = RemainMin / 1440;
                        int hrs = (RemainMin - (days * 1440)) / 60;

                        workRow[4] = days + " days, " + hrs + " hrs, " + mins + " mins";
                        workRow[5] = "SO2";

                        string eventType = "";
                        switch (binfile[20+cnt])
                        {
                            case 0xa0:
                                eventType = ("Peak Exposure");
                                break;
                            case 0xa1:
                                eventType = ("Bump Test");
                                break;
                            case 0xa2:
                                eventType = ("Zero Cal");
                                break;
                            case 0xa3:
                                eventType = ("Span Cal");
                                break;
                        }
                        workRow[6] = eventType;


                        workRow[7] = Math.Round((((float)BitConverter.ToInt32(binfile, cnt) / 256)), 1);
                        workRow[8] = BitConverter.ToInt16(binfile, cnt+18);
                        workRow[9] = Math.Round(((float)BitConverter.ToInt32(binfile, 18) / 256), 1);
                        workRow[10] = Math.Round(((float)BitConverter.ToInt32(binfile, 22) / 256), 1);
                        workRow[11] = BitConverter.ToUInt16(binfile, 30);
                        workRow[12] = BitConverter.ToUInt32(binfile, 36) / 86400 + " days";
                        bool check_overlap = false;
                        foreach (DataRow d in dt.Rows)
                        {
                            if (d[2].Equals(workRow[2]))
                            {
                                check_overlap = true;
                            }
                        }
                        if (!check_overlap && !workRow[2].ToString().Contains("0/0/0"))
                        {
                            dt.Rows.Add(workRow);
                        }
                        sz -= 21;
                        cnt += 21;
                    }
                    
                }

                //.evl 파일 parsing
                else if (Path.GetExtension(ofd.FileName) == ".evl")
                {
                    if (filePath.Contains("BC"))
                    {
                        string[] log_distinct_bits = new string[fileLength / 8];
                        BinaryReader rdr = new BinaryReader(File.Open(filePath, FileMode.Open));
                        byte[] Header_bytes = new byte[40];
                        byte[] info_bytes = new byte[21];

                        int i = 0;

                        SetUpData();

                        while (rdr.BaseStream.Position < fileLength)
                        {
                            do
                            {
                                Header_bytes[i] = rdr.ReadByte();
                            } while (Header_bytes[i] == 0x00);

                            if (i > 0 && Header_bytes[i - 1] == 0x53 && Header_bytes[i] == 0x4e) //find "SN"
                            {
                                string sn = ""; int header_cnt = 0; string s_size = ""; string dock_time = ""; string FW = "";
                                DateTime DockTime = new DateTime();
                                byte s;

                                //Header(IDX)
                                while (rdr.BaseStream.Position < fileLength)
                                {
                                    s = rdr.ReadByte();
                                    //serial number
                                    if (header_cnt == 0 && s == 0x3a)
                                    {
                                        s = rdr.ReadByte();
                                        while (s != 0x0d)
                                        {
                                            sn += Char.ConvertFromUtf32(s);
                                            s = rdr.ReadByte();
                                        }
                                    }
                                    //DockTime
                                    if (header_cnt == 1 && s == 0x3a)
                                    {
                                        s = rdr.ReadByte();
                                        while (s != 0x0d)
                                        {
                                            dock_time += Char.ConvertFromUtf32(s);
                                            s = rdr.ReadByte();
                                        }
                                        string[] logtime = dock_time.Split(':', ' ', '-');
                                        DockTime = new DateTime(int.Parse(logtime[0]), int.Parse(logtime[1]), int.Parse(logtime[2]), int.Parse(logtime[3]), int.Parse(logtime[4]), int.Parse(logtime[5]));

                                    }
                                    //FW
                                    if (header_cnt == 2 && s == 0x3a)
                                    {
                                        s = rdr.ReadByte();
                                        while (s != 0x0d)
                                        {
                                            FW += Char.ConvertFromUtf32(s);
                                            s = rdr.ReadByte();
                                        }
                                    }
                                    //Size
                                    if (header_cnt == 4 && s == 0x3a)
                                    {
                                        s = rdr.ReadByte();
                                        while (s != 0x0d)
                                        {
                                            s_size += Char.ConvertFromUtf32(s);
                                            s = rdr.ReadByte();
                                        }
                                    }
                                    if (s == 0x0d && rdr.ReadByte() == 0x0a)
                                    {
                                        header_cnt++;
                                    }
                                    if (header_cnt == 5)
                                    {
                                        break;
                                    }
                                }

                                int sz = Convert.ToInt32(s_size);

                                //Header(log)

                                Header_bytes = rdr.ReadBytes(40); sz -= 40;

                                //Data(log)
                                while (sz >= 21)
                                {
                                    workRow = dt.NewRow();
                                    
                                    info_bytes = rdr.ReadBytes(21);
                                    sz -= 21;
                                    workRow[0] = sn;
                                    workRow[1] = FW;
                                    workRow[2] = bwTime(BitConverter.ToUInt32(info_bytes, 4));
                                    workRow[3] = bwTime(BitConverter.ToUInt32(info_bytes, 8));
                                    int mins = Convert.ToUInt16(info_bytes[14]);
                                    int RemainMin = BitConverter.ToUInt16(info_bytes, 12) * 30 + mins;
                                    workRow[4] = RemainMin;
                                    int days = RemainMin / 1440;
                                    int hrs = (RemainMin - (days * 1440)) / 60;

                                    workRow[5] = days + " days, " + hrs + " hrs, " + mins + " mins";
                                    workRow[6] = "SO2";

                                    //get event type
                                    string eventType = "";
                                    switch (info_bytes[20])
                                    {
                                        case 0xa0:
                                            eventType = ("Peak Exposure");
                                            break;
                                        case 0xa1:
                                            eventType = ("Bump Test");
                                            break;
                                        case 0xa2:
                                            eventType = ("Zero Cal");
                                            break;
                                        case 0xa3:
                                            eventType = ("Span Cal");
                                            break;
                                    }
                                    workRow[7] = eventType;
                                    
                                    workRow[8] = Math.Round((((float)BitConverter.ToInt32(info_bytes, 0) / 256)), 1);       //Peak Gas Reading
                                    workRow[9] = BitConverter.ToInt16(info_bytes, 18);                                      //Duration of Alarm (seconds)
                                    workRow[10] = Math.Round(((float)BitConverter.ToInt32(Header_bytes, 18) / 256), 1);     //Low Alarm Pt
                                    workRow[11] = Math.Round(((float)BitConverter.ToInt32(Header_bytes, 22) / 256), 1);     //High Alarm Pt
                                    workRow[12] = BitConverter.ToUInt16(Header_bytes, 30);                                  //Total Unit Alarm Time (minutes)
                                    workRow[13] = BitConverter.ToUInt32(Header_bytes, 36) / 86400 + " days";                //Remaining Hibernate time

                                    bool check_overlap = false;
                                    foreach (DataRow d in dt.Rows)
                                    {
                                        if (d[2].Equals(workRow[2]))
                                        {
                                            check_overlap = true;
                                        }
                                    }
                                    if (!check_overlap && !workRow[2].ToString().Contains("0/0/0"))
                                    {
                                        dt.Rows.Add(workRow);
                                    }
                                }
                            }
                            i++;
                            i = i % 2;
                        }
                        rdr.Close();
                    }
                }
                
                else
                {
                    MessageBox.Show("Wrong File");
                }

            }



        }
    }
}
