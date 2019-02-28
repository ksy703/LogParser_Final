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
    public class MicroClip_Datalog
    {
        public DataTable dt;
        public string fileName; public string filePath; long fileLength;
        bool cb_checked;
        //setting datatable columns
        public void SetUpData()
        {
            dt.Columns.Add("Serial Number");
            dt.Columns.Add("Log Type");
            dt.Columns.Add("Log Time");
            dt.Columns.Add("Status");
            dt.Columns.Add("Bump");
            dt.Columns.Add("H2S Reading");
            dt.Columns.Add("H2S STEL");
            dt.Columns.Add("H2S TWA");
            dt.Columns.Add("CO Reading");
            dt.Columns.Add("CO STEL");
            dt.Columns.Add("CO TWA");
            dt.Columns.Add("O2 Reading");
            dt.Columns.Add("LEL Reading");
            dt.Columns.Add("H2S Status");
            dt.Columns.Add("CO Status");
            dt.Columns.Add("O2 Status");
            dt.Columns.Add("LEL Status");
            dt.Columns.Add("Unit Status");
            dt.Columns.Add("Unit Options");
            dt.Columns.Add("Language");
            dt.Columns.Add("Gas Configure");
            dt.Columns.Add("Cal Interval");
            dt.Columns.Add("Last Cal Date");
            dt.Columns.Add("Bump Interval");
            dt.Columns.Add("Last Bump Date");
            dt.Columns.Add("High Alarm");
            dt.Columns.Add("Low Alarm");
            dt.Columns.Add("TWA Alarm");
            dt.Columns.Add("STEL Alarm");
            dt.Columns.Add("STEL Period");
            dt.Columns.Add("Temperature");
        }
        public string chargingAlarmParse(byte b)
        {
            string result = "";

            if ((b & 1) == 1) result += "Alarm Start; ";
            else result += "Alarm Stop; ";

            if ((b & 2) == 2) result += "Device On; ";
            else result += "Device Off; ";

            return result;
        }

        string[] UnitOptionList = {
                "Confidnece Beep",
                "Forced Calibration",
                "Forced Bump",
                "calibration lock",
                "bump lock",
                "latch Alarm",
                "safe mode",
                "stealth mode",
                "IR stealth mode",
                "Intelli Flash"
            };
        string[] SensorStatusList = {
                "Calibration due",
                "Bump fail",
                "Self-test fail",
                "zero fault",
                "cal fault",
                "cal abort"
            };

        string[] UnitStatusList = {
                "not charging",
                "charging",
                "charged",
                "aborted cal"
            };
        string[] ReadingStatusList = {
                "Downscale Alarm",
                "TWa Alarm",
                "STEL Alarm",
                "Low Alarm",
                "High Alarm",
                "Multi Alarm",
                "Low Battery",
                "",
                "Auto-Zeroing",
                "Calibrating"
            };
        string[] GasconfigOptionList =
        {
            "LEL By Volume",
            "Sensor Disabled",
            "O2 Auto-Calibrate"
        };

        bool isBump = false;
        int inZero = 0;

        public bool H2SEnabled = false;
        public bool COEnabled = false;
        public bool O2Enabled = false;
        public bool LELEnabled = false;
        public int findsize(byte s)
        {
            switch (s)
            {
                case (0x10): return 4;
                case (0x11): return 4;
                case (0x20): return 22;
                case (0x21): return 4;
                case (0x30): return 6;
                case (0x40): return 28;
                case (0x41): return 28;
                case (0x42): return 28;
                case (0x43): return 28;
                case (0x50): return 9;
                case (0x51): return 7;
                default: return 0;
            }
        }
        public string Optionparse(UInt32 l, string[] OptionList)
        {
            string unitOption = "";

            for (int i = 0; i < OptionList.Length; i++)
            {

                if ((l & (1 << i)) == 1 << i)
                {
                    unitOption += OptionList[i] + " ";
                }
            }

            return unitOption;
        }
        public bool isvalid(Int32 value)
        {
            if (value < 30000 && value > -30000)
                return true;
            else
                return false;
        }
        public void addNewRow(byte s, DataRow dr, DataTable dt)
        {
            if (cb_checked == false)
            {
                dt.Rows.Add(dr);
            }
            else if (s != 0x21)
            {
                dt.Rows.Add(dr);
            }
            else if (inZero < 2)
            {
                dt.Rows.Add(dr);
            }
        }


        DateTime deviceTime = new DateTime();
        int sz = 0;
        string sn = "";
        DataRow workRow;

        UInt32 curConst;
        //file 선택
        public void datalog_parsing_micro_clip(TextBox tb,CheckBox cb)
        {
            if (cb.Checked){ cb_checked = true; }
            else { cb_checked = false; }
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "file open";
            ofd.FileName = "test";
            ofd.Filter = "data log from IDX|*.dal|data log from Microdock|*.BWC";
            byte[] info_bytes = new byte[28];
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                dt = new DataTable();
                fileName = ofd.SafeFileName;
                filePath = ofd.FileName;
                FileInfo fi = new FileInfo(filePath);




                fileLength = fi.Length;
                string[] lines;
                byte[] file;
                byte[] line = new byte[4];



                if (Path.GetExtension(ofd.FileName) == ".BWC")
                {
                    DateTime filetime = File.GetLastWriteTime(filePath);

                    int seek = 0;
                    tb.Text = "Reading...";
                    tb.Refresh();
                    file = File.ReadAllBytes(filePath);
                    lines = File.ReadAllLines(filePath);

                    if (!lines[0].Equals("GasAlert Microclip data log file"))
                    {
                        tb.Text = "It is not Microclip Data log file!\n";
                        tb.Refresh();
                        return;
                    }
                    else if (lines[1].Length > 17 || lines[1].Length < 16)
                    {
                        tb.Text = "Device's Serial Number is invalid!\n";
                        tb.Refresh();
                        return;

                    }
                    sn = lines[1].Split()[1];
                    if (lines[2].Contains("Count:"))
                    {
                        curConst = UInt32.Parse(lines[2].Split(':')[2]);
                    }
                    else
                    {
                        seek = lines[0].Length + 2 + lines[1].Length + 2;
                        for (int j = 0; j < 4; j++)
                        {
                            line[j] = file[seek++];
                        }
                        curConst = BitConverter.ToUInt32(line, 0);
                    }
                    filetime = filetime.AddSeconds(curConst * -1);
                    seek = lines[0].Length + 2 + lines[1].Length + 2 + lines[2].Length + 2 + lines[3].Length + 2;
                    SetUpData();

                    while (seek < file.Length - 1)
                    {

                        if (file[seek] == 0xff || file[seek] == 0x00) //unused/invalid/garbage byte
                        {
                            seek++;
                        }
                        else
                        {

                            int t = findsize(file[seek]);
                            seek++;
                            if (t != 0)
                            {
                                for (int k = 0; k < t; k++)
                                {
                                    info_bytes[k] = file[seek + k];
                                    if (info_bytes[k] == 0xff)
                                    {
                                        seek += k ;
                                        break;
                                    }
                                }
                                sz = MakeData(workRow, file[seek - 1], file.Length - seek, info_bytes, sn, filetime);
                                seek += t;
                            }


                        }

                    }
                    tb.Text = ("Finish!!");
                }



                else if (Path.GetExtension(ofd.FileName) == ".dal"&& fileName.Contains("MC"))
                {
                    tb.Text = "Reading...";
                    tb.Refresh();

                    info_bytes = new byte[28];


                    file = File.ReadAllBytes(filePath);
                    lines = File.ReadAllLines(filePath);
                    int seek = 0;

                    SetUpData();
                    while (seek < fileLength - 1)
                    {
                        if (file[seek] == 0x53 && file[seek + 1] == 0x4e) //find "SN"
                        {

                            sn = ""; int header_cnt = 0; string size = ""; string dock_time = "";
                            DateTime DockTime = new DateTime();
                            byte s;

                            //header
                            while (seek < fileLength - 1)
                            {
                                seek++;
                                s = file[seek];

                                //serial number
                                if (header_cnt == 0 && s == 0x3a)
                                {
                                    seek++;
                                    s = file[seek];
                                    while (s != 0x0d)
                                    {
                                        sn += Char.ConvertFromUtf32(s);
                                        seek++;
                                        s = file[seek];
                                    }

                                }
                                //DockTime
                                if (header_cnt == 1 && s == 0x3a)
                                {
                                    seek++;
                                    s = file[seek];
                                    while (s != 0x0d)
                                    {

                                        dock_time += Char.ConvertFromUtf32(s);

                                        seek++;
                                        s = file[seek];

                                    }
                                    string[] logtime = dock_time.Split(':', ' ', '-');
                                    DockTime = new DateTime(int.Parse(logtime[0]), int.Parse(logtime[1]), int.Parse(logtime[2]), int.Parse(logtime[3]), int.Parse(logtime[4]), int.Parse(logtime[5]));

                                }
                                //Size
                                if (header_cnt == 4 && s == 0x3a)
                                {
                                    seek++;
                                    s = file[seek];
                                    while (s != 0x0d)
                                    {
                                        size += Char.ConvertFromUtf32(s);
                                        seek++;
                                        s = file[seek];
                                    }
                                }
                                if (s == 0x0d && file[seek + 1] == 0x0a)
                                {
                                    header_cnt++;
                                }
                                if (header_cnt == 5)
                                {
                                    break;
                                }
                            }
                            seek += 2;
                            sz = Convert.ToInt32(size);
                            for (int k = 0; k < 4; k++)
                            {
                                info_bytes[k] = file[seek + k];
                            }
                            seek += 4;
                            sz -= 4;
                            curConst = BitConverter.ToUInt32(info_bytes, 0);
                            deviceTime = DockTime.AddSeconds(curConst * -1);
                            do
                            {
                                s = file[seek];

                                if (s == 0xff || s == 0x00) //unused/invalid/garbage byte
                                {
                                    do
                                    {
                                        seek++;
                                        sz--;
                                    } while ((s == 0xff || s == 0x00) && sz > 2);
                                }
                                else
                                {
                                    int t = findsize(s);
                                    if (t != 0)
                                    {
                                        seek++;
                                        for (int k = 0; k < t; k++)
                                        {
                                            info_bytes[k] = file[seek + k];

                                        }

                                        sz = MakeData(workRow, file[seek - 1], sz, info_bytes, sn, deviceTime);
                                        seek += t - 1;

                                    }

                                }
                                seek++;
                                sz--;
                            } while (sz > 2);
                        }
                        seek++;

                    }
                    tb.Text = ("Finish!!");

                }
                else
                {
                    MessageBox.Show("Wrong file!");
                    dt = null;
                }
            }

        }

        public int MakeData(DataRow workRow, byte s, int sz, byte[] info_bytes, string sn, DateTime deviceTime)
        {
            //eventlog parsing

            DateTime logtime;
            UInt16 status;
            workRow = dt.NewRow();
            switch (s)
            {
                case 0x10://Startup control byte
                          //info_bytes = rdr.ReadBytes(4);
                    workRow[0] = sn;
                    workRow[1] = "Power up";
                    logtime = deviceTime.AddSeconds(BitConverter.ToUInt32(info_bytes, 0));
                    workRow[2] = logtime.ToString("yyyy/MM/dd HH:mm:ss");
                    sz -= 4;
                    addNewRow(s, workRow, dt);
                    break;
                case 0x11://Shutdown control byte
                          //info_bytes = rdr.ReadBytes(4);
                    workRow[0] = sn;
                    workRow[1] = "ShutDown";
                    logtime = deviceTime.AddSeconds(BitConverter.ToUInt32(info_bytes, 0));
                    workRow[2] = logtime.ToString("yyyy/MM/dd HH:mm:ss");
                    sz -= 4;
                    addNewRow(s, workRow, dt);
                    break;
                case 0x20: //Gas readings (full record)
                           //info_bytes = rdr.ReadBytes(22);
                    workRow[0] = sn;
                    workRow[1] = "Gas Reading";
                    logtime = deviceTime.AddSeconds(BitConverter.ToUInt32(info_bytes, 0));
                    workRow[2] = logtime.ToString("yyyy/MM/dd HH:mm:ss");
                    status = BitConverter.ToUInt16(info_bytes, 4);
                    workRow[3] = Optionparse(status, ReadingStatusList);
                    if ((status & (1 << 10)) == (1 << 10))
                    {
                        workRow[4] = "Yes";
                        isBump = true;
                    }
                    else
                    {
                        workRow[4] = "No";
                        isBump = false;
                    }
                    if (H2SEnabled && isvalid(BitConverter.ToInt16(info_bytes, 6)))
                    {
                        workRow[5] = (BitConverter.ToInt16(info_bytes, 6) / 10.0).ToString("0.0");
                        workRow[6] = (BitConverter.ToUInt16(info_bytes, 8) / 10.0).ToString("0.0");
                        workRow[7] = (BitConverter.ToUInt16(info_bytes, 10) / 10.0).ToString("0.0");
                    }
                    else H2SEnabled = false;
                    if (COEnabled && isvalid(BitConverter.ToInt16(info_bytes, 18)))
                    {
                        workRow[8] = (BitConverter.ToInt16(info_bytes, 12) / 10.0).ToString("0.0");
                        workRow[9] = (BitConverter.ToUInt16(info_bytes, 14) / 10.0).ToString("0.0");
                        workRow[10] = (BitConverter.ToUInt16(info_bytes, 16) / 10.0).ToString("0.0");
                    }
                    else COEnabled = false;
                    if (O2Enabled && isvalid(BitConverter.ToInt16(info_bytes, 18)))
                    {
                        workRow[11] = (BitConverter.ToInt16(info_bytes, 18) / 10.0).ToString("0.0");
                    }
                    else O2Enabled = false;
                    if (LELEnabled && isvalid(BitConverter.ToInt16(info_bytes, 20)))
                    {
                        workRow[12] = (BitConverter.ToInt16(info_bytes, 20) / 10.0).ToString("0.0");
                    }
                    else LELEnabled = false;

                    sz -= 22;
                    addNewRow(s, workRow, dt);
                    break;
                case 0x21://All gas readings & STEL/TWA are zero (compressed record)
                          //info_bytes = rdr.ReadBytes(4);
                    workRow[0] = sn;
                    workRow[1] = "Gas Reading";
                    logtime = deviceTime.AddSeconds(BitConverter.ToUInt32(info_bytes, 0));
                    workRow[2] = logtime.ToString("yyyy/MM/dd HH:mm:ss");
                    if (isBump) { workRow[4] = "Yes"; }
                    else { workRow[4] = "No"; }
                    workRow[3] = "";
                    workRow[5] = "0.0";
                    workRow[6] = "0.0";
                    workRow[7] = "0.0";
                    workRow[8] = "0.0";
                    workRow[9] = "0.0";
                    workRow[10] = "0.0";
                    workRow[11] = "20.9";
                    workRow[12] = "0";

                    sz -= 4;
                    addNewRow(s, workRow, dt);
                    break;
                case 0x30: //Unit options
                    workRow[0] = sn;
                    //info_bytes = rdr.ReadBytes(6);
                    UInt16 h = BitConverter.ToUInt16(info_bytes, 4);
                    workRow[1] = "Unit Option";
                    workRow[2] = dt.Rows[dt.Rows.Count - 1][2];
                    workRow[18] = Optionparse(BitConverter.ToUInt32(info_bytes, 0), UnitOptionList);

                    if (h == 0) workRow[19] = "English";
                    else if (h == 1) workRow[19] = "French";
                    else if (h == 2) workRow[19] = "German";
                    else if (h == 3) workRow[19] = "Spanish";
                    else if (h == 4) workRow[19] = "Portugese";
                    else workRow[19] = "invalid";

                    sz -= 6;
                    addNewRow(s, workRow, dt);
                    break;

                //H2S options//CO options//O2 options//LEL options

                case 0x40:
                case 0x41:
                case 0x42:
                case 0x43:
                    //info_bytes = rdr.ReadBytes(28);
                    workRow[0] = sn;
                    workRow[2] = dt.Rows[dt.Rows.Count - 1][2];
                    workRow[20] = Optionparse(BitConverter.ToUInt16(info_bytes, 0), GasconfigOptionList);
                    workRow[21] = BitConverter.ToUInt32(info_bytes, 2) / 86400;
                    workRow[22] = deviceTime.AddSeconds(BitConverter.ToUInt32(info_bytes, 6)).ToString("yyyy-MM-dd HH:mm:ss");
                    workRow[23] = BitConverter.ToUInt32(info_bytes, 10) / 86400;
                    workRow[24] = deviceTime.AddSeconds(BitConverter.ToUInt32(info_bytes, 14)).ToString("yyyy-MM-dd HH:mm:ss");
                    workRow[25] = (BitConverter.ToUInt16(info_bytes, 18) / 10.0).ToString("0.0");
                    workRow[26] = (BitConverter.ToUInt16(info_bytes, 20) / 10.0).ToString("0.0");
                    if (s == 0x40 || s == 0x41)
                    {
                        workRow[27] = (BitConverter.ToUInt16(info_bytes, 22) / 10.0).ToString("0.0");
                        workRow[28] = (BitConverter.ToUInt16(info_bytes, 24) / 10.0).ToString("0.0");
                        workRow[29] = BitConverter.ToUInt16(info_bytes, 26);
                    }
                    if (s == 0x40) { workRow[1] = "H2S Options"; H2SEnabled = true; }
                    else if (s == 0x41) { workRow[1] = "CO Options"; COEnabled = true; }
                    else if (s == 0x42) { workRow[1] = "O2 Options"; O2Enabled = true; }
                    else if (s == 0x43) { workRow[1] = "LEL Options"; LELEnabled = true; }

                    sz -= 28;
                    addNewRow(s, workRow, dt);
                    break;
                case 0x50: //STATUS(i.e. self-test failure, cal failure, etc.)
                    workRow[0] = sn;
                    //info_bytes = rdr.ReadBytes(9);
                    logtime = deviceTime.AddSeconds(BitConverter.ToUInt32(info_bytes, 0));
                    workRow[1] = "Status";
                    workRow[2] = logtime.ToString("yyyy/MM/dd HH:mm:ss");
                    workRow[13] = Optionparse(info_bytes[4], SensorStatusList);
                    workRow[14] = Optionparse(info_bytes[5], SensorStatusList);
                    workRow[15] = Optionparse(info_bytes[6], SensorStatusList);
                    workRow[16] = Optionparse(info_bytes[7], SensorStatusList);
                    workRow[17] = Optionparse(info_bytes[8], SensorStatusList);

                    sz -= 9;
                    addNewRow(s, workRow, dt);
                    break;
                case 0x51: //Temperature
                           //info_bytes = rdr.ReadBytes(7);
                    workRow[0] = sn;
                    workRow[1] = "Charging Alarm";
                    logtime = deviceTime.AddSeconds(BitConverter.ToUInt32(info_bytes, 0));
                    workRow[2] = logtime.ToString("yyyy/MM/dd HH:mm:ss");
                    workRow[3] = chargingAlarmParse(info_bytes[4]);
                    workRow[30] = BitConverter.ToInt16(info_bytes, 5);

                    sz -= 7;
                    addNewRow(s, workRow, dt);
                    break;
            }
            if ((s == 0x21)) inZero++;
            else inZero = 0;

            return sz;



        }

    }
}
