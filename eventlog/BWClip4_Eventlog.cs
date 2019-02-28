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
    public class BWClip4_Eventlog
    {
        public DataTable dt;
        public string fileName; public string filePath; long fileLength; public string binfile_header;
        string[] header_info = new string[20];
        byte[] binfile;
        
        //setting datatable columns(.evl)
        public void SetUpData_evl()
        {
            dt.Columns.Add("Serial Number");

            dt.Columns.Add("Start Time");
            dt.Columns.Add("Start Time in UTC");
            dt.Columns.Add("Event Type");
            dt.Columns.Add("Channel");
            dt.Columns.Add("H2S Peak (ppm)");
            dt.Columns.Add("CO Peak (ppm)");
            dt.Columns.Add("O2 Peak (%Vol)");
            dt.Columns.Add("LEL Peak (%LEL)");
            dt.Columns.Add("H2S TWA");
            dt.Columns.Add("CO TWA");
            dt.Columns.Add("H2S STEL");
            dt.Columns.Add("CO STEL");
            dt.Columns.Add("Remaining Life time");
            dt.Columns.Add("Event Duration");
            dt.Columns.Add("Temperature");
            dt.Columns.Add("Battery Voltage");

            dt.Columns.Add("H2S Low Alarm Pt");
            dt.Columns.Add("H2S High Alarm Pt");
            dt.Columns.Add("H2S TWA Alarm Pt");
            dt.Columns.Add("H2S STEL Alarm Pt");
            dt.Columns.Add("CO Low Alarm Pt");
            dt.Columns.Add("CO High Alarm Pt");
            dt.Columns.Add("CO TWA Alarm Pt");
            dt.Columns.Add("CO STEL Alarm Pt");
            dt.Columns.Add("O2 Low Alarm Pt");
            dt.Columns.Add("O2 High Alarm Pt");
            dt.Columns.Add("LEL Low Alarm Pt");
            dt.Columns.Add("LEL High Alarm Pt");
            dt.Columns.Add("O2 Low AL Trigger");
            dt.Columns.Add("O2 High AL Trigger");
        }

        //setting datatable columns(.bin)
        public void SetUpData()
        {
            dt.Columns.Add("Serial Number");
            
            dt.Columns.Add("UTC Time Stamp");
            dt.Columns.Add("Local Time Stamp");
            dt.Columns.Add("Event Type");
            dt.Columns.Add("Channel");
            dt.Columns.Add("H2S Peak (ppm)");
            dt.Columns.Add("CO Peak (ppm)");
            dt.Columns.Add("O2 Peak (%Vol)");
            dt.Columns.Add("LEL Peak (%LEL)");
            dt.Columns.Add("H2S TWA");
            dt.Columns.Add("CO TWA");
            dt.Columns.Add("H2S STEL");
            dt.Columns.Add("CO STEL");
            dt.Columns.Add("Life time");
            dt.Columns.Add("Event Duration");
            dt.Columns.Add("Temperature");
            dt.Columns.Add("Battery Voltage");

            dt.Columns.Add("H2S Low Alarm Pt");
            dt.Columns.Add("H2S High Alarm Pt");
            dt.Columns.Add("H2S TWA Alarm Pt");
            dt.Columns.Add("H2S STEL Alarm Pt");
            dt.Columns.Add("CO Low Alarm Pt");
            dt.Columns.Add("CO High Alarm Pt");
            dt.Columns.Add("CO TWA Alarm Pt");
            dt.Columns.Add("CO STEL Alarm Pt");
            dt.Columns.Add("O2 Low Alarm Pt");
            dt.Columns.Add("O2 High Alarm Pt");
            dt.Columns.Add("LEL Low Alarm Pt");
            dt.Columns.Add("LEL High Alarm Pt");
            dt.Columns.Add("O2 Low AL Trigger");
            dt.Columns.Add("O2 High AL Trigger");
        }
        
        //parsing header
        public void parsing_header(DataRow dr, byte[] Header_bytes)
        {
            string sn = "";
            //serial number
            for (int j = 0; j < 18; j++)
            {
                sn+= (char)Header_bytes[j];
            }dr[0] = sn;
            //DATA ROW [0] : serial number

            //Alarm Point(Ch#1~4)

            /* DATA ROW
             *[17] : H2S Low Alarm Pt
             *[18] : H2S High Alarm Pt
             *[19] : H2S TWA Alarm Pt
             *[20] : H2S STEL Alarm Pt
             *[21] : CO Low Alarm Pt
             *[22] : CO High Alarm Pt
             *[23] : CO TWA Alarm Pt
             *[24] : CO STEL Alarm Pt
             *[25] : O2 Low Alarm Pt
             *[26] : O2 High Alarm Pt
             *[27] : LEL Low Alarm Pt
             *[28] : LEL High Alarm Pt
             *[29] : O2 Low AL Trigger
             *[30] : O2 High AL Trigger
            */

            for (int j = 0; j < 12; j++)
            {
                dr[j+17] = ((float)BitConverter.ToUInt16(Header_bytes, 18 + j * 2) / 10);
            }

            //O2 Low AL Trigger
            string tmp = string.Empty;
            switch (Header_bytes[42])
            {
                case 0: tmp = "Disable"; break;
                case 1: tmp = "Rising"; break;
                case 2: tmp = "Falling"; break;
            }
            dr[29]= tmp;

            //O2 High AL Trigger
            switch (Header_bytes[43])
            {
                case 0: tmp = "Disable"; break;
                case 1: tmp = "Rising"; break;
                case 2: tmp = "Falling"; break;
            }
            dr[30]= tmp;
            
        }

        //time
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

        //get channel
        static string GetEventChannel(byte input)
        {
            string result = "";
            if ((input & 1) == 1)
            {
                result += "Channel 1 (H2S) ";
            }
            if ((input & 2) == 2)
            {
                result += "Channel 2 (CO) ";
            }
            if ((input & 4) == 4)
            {
                result += "Channel 3 (O2) ";
            }
            if ((input & 8) == 8)
            {
                result += "Channel 4 (LEL) ";
            }

            return result;
        }

        //BWClip4 eventlog parsing
        public void eventlog_parsing_bwc4()
        {
            int size = 0;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "file open";
            ofd.FileName = "test";
            ofd.Filter = "bin 파일|*.bin|event log 파일|*.evl";

            //file 선택
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
                    SetUpData();
                    binfile = File.ReadAllBytes(filePath);
                    int count = BitConverter.ToUInt16(binfile, 56);

                    for (int j = 0; j < count; j++)
                    {
                        workRow = dt.NewRow();
                        parsing_header(workRow,binfile);
                        workRow[1] = bwTime(BitConverter.ToUInt32(binfile, 60 + 36 * j));
                        workRow[2] = bwTime(BitConverter.ToUInt32(binfile, 64 + 36 * j));

                        //get event type
                        string eventType = "";
                        switch (binfile[68 + 36 * j])
                        {
                            case 0:
                                eventType = ("0 : Alarm(Low/High/-OL/OL);");
                                break;
                            case 1:
                                eventType = ("1 : Hygiene alarm (TWA or STEL);");
                                break;
                            case 2:
                                eventType = ("2 : Bump Test Pass;");
                                break;
                            case 3:
                                eventType = ("3 : Zero Cal Pass;");
                                break;
                            case 4:
                                eventType = ("4 : Calibration Pass;");
                                break;
                            case 5:
                                eventType = ("5 : Bump Test Fail;");
                                break;
                            case 6:
                                eventType = ("6 : Zero Fail;");
                                break;
                            case 7:
                                eventType = ("7 : Calibration Fail;");
                                break;
                            case 8:
                                eventType = ("8 : FW Update Fail;");
                                break;
                            case 9:
                                eventType = ("9 : Config. Update Fail;");
                                break;
                        }
                        workRow[3] = eventType; //event type
                        workRow[4] = (GetEventChannel(binfile[69 + 36 * j])); //channel
                        workRow[5] = (((float)BitConverter.ToInt16(binfile, 70 + 36 * j) / 10)); //H2S Peak
                        workRow[6] = (((float)BitConverter.ToInt16(binfile, 72 + 36 * j) / 10)); //CO Peak
                        workRow[7] = (((float)BitConverter.ToInt16(binfile, 74 + 36 * j) / 10)); //O2 Peak
                        workRow[8] = (((float)BitConverter.ToInt16(binfile, 76 + 36 * j) / 10)); //LEL Peak
                        workRow[9] = (((float)BitConverter.ToInt16(binfile, 78 + 36 * j) / 10)); //H2S TWA
                        workRow[10] = (((float)BitConverter.ToInt16(binfile, 80 + 36 * j) / 10)); //CO TWA
                        workRow[11] = (((float)BitConverter.ToInt16(binfile, 82 + 36 * j) / 10)); //H2S STEL
                        workRow[12] = (((float)BitConverter.ToInt16(binfile, 84 + 36 * j) / 10)); //CO STEL
                        workRow[13] = (BitConverter.ToUInt32(binfile, 86 + 36 * j)); //Lifetime
                        workRow[14] = ((BitConverter.ToUInt16(binfile, 90 + 36 * j))); //Event Duration
                        workRow[15] = ((BitConverter.ToInt16(binfile, 92 + 36 * j))); //Temperature
                        workRow[16] = ((BitConverter.ToUInt16(binfile, 94 + 36 * j))); //Battery Voltage
                        dt.Rows.Add(workRow);
                    }



                }

                //.evl 파일 parsing
                else if (Path.GetExtension(ofd.FileName) == ".evl")
                {
                    if (filePath.Contains("WR"))
                    {
                        string[] log_distinct_bits = new string[fileLength / 8];
                        BinaryReader rdr = new BinaryReader(File.Open(filePath, FileMode.Open));
                        byte[] Header_bytes = new byte[60];
                        byte[] info_bytes = new byte[36];
                        int i = 0;

                        SetUpData_evl();
                        while (rdr.BaseStream.Position < fileLength)
                        {
                            do
                            {
                                Header_bytes[i] = rdr.ReadByte();
                            } while (Header_bytes[i] == 0xff);
                            
                            //find "SN"
                            if (i > 0 && Header_bytes[i - 1] == 0x53 && Header_bytes[i] == 0x4e) 
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
                                    //FW version
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

                                int sz = Convert.ToInt32(size);

                                //Header(log)

                                Header_bytes = rdr.ReadBytes(60); sz -= 60;
                                int count = BitConverter.ToUInt16(Header_bytes, 56);
                                
                                for (int j = 0; j < count; j++)
                                {
                                    workRow = dt.NewRow();
                                    parsing_header(workRow, Header_bytes); //workRow[0] : SN

                                //Data(log)
                                    info_bytes = rdr.ReadBytes(36);
                                    sz -= 36;
                                    
                                    workRow[1] = bwTime(BitConverter.ToUInt32(info_bytes, 0));  //Start Time
                                    workRow[2] = bwTime(BitConverter.ToUInt32(info_bytes, 4));  //Start Time in UTC

                                    //get event type
                                    string eventType = "";
                                    switch (info_bytes[8])
                                    {
                                        case 0:
                                            eventType = ("0 : Alarm(Low/High/-OL/OL);");
                                            break;
                                        case 1:
                                            eventType = ("1 : Hygiene alarm (TWA or STEL);");
                                            break;
                                        case 2:
                                            eventType = ("2 : Bump Test Pass;");
                                            break;
                                        case 3:
                                            eventType = ("3 : Zero Cal Pass;");
                                            break;
                                        case 4:
                                            eventType = ("4 : Calibration Pass;");
                                            break;
                                        case 5:
                                            eventType = ("5 : Bump Test Fail;");
                                            break;
                                        case 6:
                                            eventType = ("6 : Zero Fail;");
                                            break;
                                        case 7:
                                            eventType = ("7 : Calibration Fail;");
                                            break;
                                        case 8:
                                            eventType = ("8 : FW Update Fail;");
                                            break;
                                        case 9:
                                            eventType = ("9 : Config. Update Fail;");
                                            break;
                                    }

                                    workRow[3] = eventType;                                                 //event type
                                    workRow[4] = (GetEventChannel(info_bytes[9]));                          //channel
                                    workRow[5] = (((float)BitConverter.ToInt16(info_bytes, 10) / 10));      //H2S Peak(ppm)
                                    workRow[6] = (((float)BitConverter.ToInt16(info_bytes, 12) / 10));      //CO Peak(ppm)
                                    workRow[7] = (((float)BitConverter.ToInt16(info_bytes, 14) / 10));      //O2 Peak(%Vol)
                                    workRow[8] = (((float)BitConverter.ToInt16(info_bytes, 16) / 10));      //LEL Peak(%LEL)
                                    workRow[9] = (((float)BitConverter.ToInt16(info_bytes, 18) / 10));      //H2S TWA
                                    workRow[10] = (((float)BitConverter.ToInt16(info_bytes, 20) / 10));     //CO TWA
                                    workRow[11] = (((float)BitConverter.ToInt16(info_bytes, 22) / 10));     //H2S STEL
                                    workRow[12] = (((float)BitConverter.ToInt16(info_bytes, 24) / 10));     //CO STEL
                                    workRow[13] = (BitConverter.ToUInt32(info_bytes, 26));                  //Remaining Life time
                                    workRow[14] = ((BitConverter.ToUInt16(info_bytes, 30)));                //Event duration
                                    workRow[15] = ((BitConverter.ToInt16(info_bytes, 32)));                 //Temperature
                                    workRow[16] = ((BitConverter.ToUInt16(info_bytes, 34)));                //Battery Voltage
                                    dt.Rows.Add(workRow);
                                }
                            }
                            i++;
                            i = i % 2;
                        }rdr.Close();
                    }
                    else
                    {
                        MessageBox.Show("Wrong File");
                    }
                }
            }
        }
    }
}
