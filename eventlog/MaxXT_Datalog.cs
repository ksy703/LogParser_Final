using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace log
{
    public class MaxXT_Datalog
    {
        public DataTable dt;
        public string fileName; public string filePath; long fileLength;
        DataRow workRow;
        DataRow tempRow;
        bool filter_check = true;

        int logging_interval;

        //dal,bwx파일 data columns setting
        public void SetUpData()
        {
            dt.Columns.Add("Serial Number");
            dt.Columns.Add("Log Time");
            dt.Columns.Add("Log Type");
            dt.Columns.Add("Status");

            dt.Columns.Add("H2S Status");
            dt.Columns.Add("H2S Reading");
            dt.Columns.Add("H2S TWA");
            dt.Columns.Add("H2S STEL");
            dt.Columns.Add("CO Status");
            dt.Columns.Add("CO Reading");

            dt.Columns.Add("CO TWA");
            dt.Columns.Add("CO STEL");
            dt.Columns.Add("O2 Status");
            dt.Columns.Add("O2 Reading");
            dt.Columns.Add("LEL Status");
            dt.Columns.Add("LEL Reading");
            dt.Columns.Add("Unit Status");
        }

        //fm파일 data columns setting
        public void SetUpData2()
        {
            dt.Columns.Add("Serial Number");
            dt.Columns.Add("Log Time");
            dt.Columns.Add("Log Type");
            dt.Columns.Add("Unit Status");

            dt.Columns.Add("H2S Status");
            dt.Columns.Add("H2S Reading");
            dt.Columns.Add("H2S STEL");
            dt.Columns.Add("H2S TWA");
            dt.Columns.Add("H2S Last Cal");
            dt.Columns.Add("H2S Last Bump");

            dt.Columns.Add("CO Status");
            dt.Columns.Add("CO Reading");
            dt.Columns.Add("CO STEL");
            dt.Columns.Add("CO TWA");
            dt.Columns.Add("CO Last Cal");
            dt.Columns.Add("CO Last Bump");

            dt.Columns.Add("O2 Status");
            dt.Columns.Add("O2 Reading");
            dt.Columns.Add("O2 Last Cal");
            dt.Columns.Add("O2 Last Bump");
            
            dt.Columns.Add("LEL Status");
            dt.Columns.Add("LEL Reading");
            dt.Columns.Add("LEL Last Cal");
            dt.Columns.Add("LEL Last Bump");

            dt.Columns.Add("Unit Option");
            dt.Columns.Add("Log Interval");
            dt.Columns.Add("Language");

            dt.Columns.Add("H2S Options");
            dt.Columns.Add("H2S Low Alarm Pt");
            dt.Columns.Add("H2S High Alarm Pt");
            dt.Columns.Add("H2S TWA Alarm Pt");
            dt.Columns.Add("H2S STEL Alarm Pt");
            dt.Columns.Add("H2S STEL Int");
            dt.Columns.Add("H2S TWA Int");
            dt.Columns.Add("H2S Cal Int");
            dt.Columns.Add("H2S Bump Int");

            dt.Columns.Add("CO Options");
            dt.Columns.Add("CO Low Alarm Pt");
            dt.Columns.Add("CO High Alarm Pt");
            dt.Columns.Add("CO TWA Alarm Pt");
            dt.Columns.Add("CO STEL Alarm Pt");
            dt.Columns.Add("CO STEL Int");
            dt.Columns.Add("CO TWA Int");
            dt.Columns.Add("CO Cal Int");
            dt.Columns.Add("CO Bump Int");

            dt.Columns.Add("O2 Options");
            dt.Columns.Add("O2 Low Alarm Pt");
            dt.Columns.Add("O2 High Alarm Pt");
            dt.Columns.Add("O2 Cal Int");
            dt.Columns.Add("O2 Bump Int");

            dt.Columns.Add("LEL Options");
            dt.Columns.Add("LEL Low Alarm Pt");
            dt.Columns.Add("LEL High Alarm Pt");
            dt.Columns.Add("LEL Cal Int");
            dt.Columns.Add("LEL Bump Int");

        }

        //bool to bit
        public string make_bit(Boolean b)
        {
            if (b == true)
            { return "1"; }
            else
            { return "0"; }
        }

        //Control Code 별 size
        public int findsize(byte s)
        {
            if (s == 0x10 || s == 0x11 || s == 0x20 || s == 0x21) { return 7; }
            else if ((0x12 <= s && s <= 0x17) || (0x22 <= s && s <= 0x27)) { return 3; }
            else if (s == 0x30) { return 2; }
            else if (s == 0x40) { return 4; }
            else if (s == 0x50 || s == 0x51) { return 22; }
            else if (s == 0x52 || s == 0x53) { return 14; }
            else if (0x60 <= s && s <= 0x67) { return 1; }
            else if (s == 0x80) { return 4; }
            else if (s == 0x70) { return 3; }
            else if (s == 0x90) { return 1; }

            else { return 0; }
        }

        //fm파일 Instrument Event 정보
        public string fm_IE(string s)
        {
            switch (s)
            {
                case "PU": return "power up";
                case "MS": return "manual shutdown";
                case "AS": return "automatic shutdown";
                case "IE": return "instrument error";
                case "ID": return "IR download event";
                case "TC": return "data/time change";
                case "NL": return "new location";
                default: return "";
            }
        }

        //fm파일 channel 정보
        public string fm_Channel(string s)
        {
            switch (s)
            {
                case "0":return "H2S ";
                case "1":return "CO ";
                case "2":return "O2 ";
                case "3":return "LEL ";
                default:return "";
            }
        }

        //fm파일 Sensor Event result
        public string fm_SE_Result(string s)
        {
            switch (s)
            {
                case "N":return "nothing";
                case "P": return "pass";
                case "F": return "fail";
                case "U": return "undefined";
                default:return "";
            }
        }

        //fm파일 Sensor Event 정보
        public string fm_SE(string s)
        {
            switch (s)
            {
                case "T":return "testing ";
                case "B":return "bump testing ";
                case "Z":return "zeroing ";
                case "S":return "spanning ";
                case "OL":return "OL protection (LEL) ";
                case "RP":return "ramp protection (LEL) ";
                case "O2":return "O2 protection (LEL) ";
                default:return "";
            }
        }

        //fm파일 IR 여부
        public string fm_SE_IR(string s)
        {
            switch (s)
            {
                case "1":return "(IR) ";
                default:return "";
            }
        }

        //fm파일 Readings 정보
        public string fm_Readings(string s)
        {
            string[] tmp = s.Split(':');
            string ans = "";
            for(int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i].Equals("CG")) { ans += "Charging;"; }
                else if (tmp[i].Equals("PD")) { ans += "Pump Disabled;"; }
                else if (tmp[i].Equals("PA")) { ans += "Pump Alarm;"; }
                else if (tmp[i].Equals("Z")) { ans += "Auto Zeroing; "; }
                else if (tmp[i].Equals("SP")) { ans += "Spanning; "; }
                else if (tmp[i].Equals("E")) { ans += "Error Alarm; "; }
                else if (tmp[i].Equals("AE")) { ans += "Error Acknowledge; "; }
                else if (tmp[i].Equals("L")) { ans += "Low Alarm; "; }
                else if (tmp[i].Equals("AL")) { ans += "Low Alarm Acknowledge; "; }
                else if (tmp[i].Equals("T")) { ans += "TWA Alarm; "; }
                else if (tmp[i].Equals("S")) { ans += "STEL Alarm; "; }
                else if (tmp[i].Equals("H")) { ans += "High Alarm; "; }
                else if (tmp[i].Equals("M")) { ans += "Multi Alarm; "; }

            }
            return ans;
        }

        //fm파일 Readings - Unit Option 정보
        public string fm_UnitOption(string s)
        {
            switch (s)
            {
                default:return "";
                case "FBT":return "force block test";
                case "SP": return "sensor prediction";
                case "LL": return "location logging";
                case "ST" : return "stealth mode";
                case "SF": return "safe mode";
                case "LA": return "latch alarm";
                case "SL": return "safety lock";
                case "CL": return "calibration lock";
                case "FB": return "forced bump";
                case "FC": return "forced calibration";
                case "CB": return "confidence beep";
            }
        }

        //fm파일 Language 정보
        public string fm_language(string s)
        {
            switch (s)
            {
                case "0":return "English";
                case "1":return "French";
                case "2":return "German";
                case "3":return "Spanish";
                case "4":return "Portuguese";
                default:return "";
            }
        }

        //fm파일 sensor option flag
        public string fm_sensorOptFlags(string s)
        {
            string[] tmp = s.Split(':');
            string ans = "";
            for (int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i].Equals("SD")){ans += "sensor disabled; ";}
                else if (tmp[i].Equals("AZ")) { ans += "Auto Zero; "; }
                else if (tmp[i].Equals("LA")) { ans += "Low Alarm Acknowledge; "; }
                else if (tmp[i].Equals("OS")) { ans += "CSA 22.2 over span(LEL); "; }
                else if (tmp[i].Equals("CH")) { ans += "%CH4; "; }
            }
            return ans;
        }

        //datalog unit event 정보
        public string uc_event(byte s)
        {
            switch (s)
            {
                case 0x00: return "Power-up";
                case 0x01: return "Manual Shutdown";
                case 0x02: return "Automatic Shutdown";
                case 0x03: return "Instrument Error";
                case 0x04: return "IR Download";
                case 0x05: return "Date/Time Changed";
                case 0x06: return "Location";
                default: return "";
            }
        }

        //datalog inst_status 정보
        public string Inst_status(byte s1, byte s2)
        {
            string tmp = Convert.ToString(s1, 2).PadLeft(8, '0') + Convert.ToString(s2, 2).PadLeft(8, '0');
            string charging = tmp.Substring(15, 1);
            string FullyCharged = tmp.Substring(14, 1);
            string flag = tmp.Substring(0, 10);
            string AlarmStatus = tmp.Substring(10, 4);
            string result = "";
            if (charging == "1") { result += "(Charging) "; }
            if (FullyCharged == "1") { result += "(Fully Charged) "; }
            if (flag.Substring(0, 1) == "1") { result += "(Pump Disabled) "; }
            if (flag.Substring(1, 1) == "1") { result += "(Low Battery) "; }
            if (flag.Substring(2, 1) == "1") { result += "(Pump Alarm) "; }
            result += Alarm_Status(AlarmStatus);
            return result;
        }

        //datalog alarm status 정보
        public string Alarm_Status(string AlarmStatus)
        {
            string result = "";
            if (AlarmStatus == "0000") { result += ""; }
            if (AlarmStatus == "0001") { result += "Zeroing "; }
            if (AlarmStatus == "0010") { result += "Spanning "; }
            if (AlarmStatus == "0011") { result += "Error Alarm "; }
            if (AlarmStatus == "0100") { result += "Error Alarm(ACKD) "; }
            if (AlarmStatus == "1000") { result += "Low Alarm "; }
            if (AlarmStatus == "1001") { result += "Low Alarm(ACKD) "; }
            if (AlarmStatus == "1010") { result += "TWA Alarm "; }
            if (AlarmStatus == "1011") { result += "STEL Alarm "; }
            if (AlarmStatus == "1100") { result += "High Alarm "; }
            if (AlarmStatus == "1101") { result += "Multi Alarm"; }
            return result;
        }

        //datalog 센서 값 reading
        public DataRow Sens_Reading(byte[] info_bytes, int cnt, DataRow workRow)
        {
            byte s = info_bytes[cnt]; string tmp = "";
            cnt++;
            if (s == 0x10 || s == 0x20)//H2S
            {
                tmp = (Convert.ToString(info_bytes[cnt], 2)).PadLeft(8, '0');
                int dec = Convert.ToInt16(tmp.Substring(6, 2));
                workRow[4] = Alarm_Status(tmp.Substring(2, 4));
                tmp = (Convert.ToString(info_bytes[cnt + 1], 2)).PadLeft(8, '0') + (Convert.ToString(info_bytes[cnt + 2], 2)).PadLeft(8, '0');
                workRow[5] = Convert.ToInt16(tmp, 2);
                tmp = (Convert.ToString(info_bytes[cnt + 3], 2)).PadLeft(8, '0') + (Convert.ToString(info_bytes[cnt + 4], 2)).PadLeft(8, '0');

                if (dec == 1)
                {
                    workRow[6] = (float)(Convert.ToInt16(tmp, 2)) / 10;
                }
                else if (dec == 2)
                {
                    workRow[6] = (float)(Convert.ToInt16(tmp, 2)) / 100;
                }
                else if (dec == 3)
                {
                    workRow[6] = (float)(Convert.ToInt16(tmp, 2)) / 1000;
                }
                else
                {
                    workRow[6] = Convert.ToInt16(tmp, 2);
                }

                tmp = (Convert.ToString(info_bytes[cnt + 5], 2)).PadLeft(8, '0') + (Convert.ToString(info_bytes[cnt + 6], 2)).PadLeft(8, '0');
                workRow[7] = Convert.ToInt16(tmp, 2);
            }
            else if (s == 0x11 || s == 0x21)//CO
            {
                tmp = (Convert.ToString(info_bytes[cnt], 2)).PadLeft(8, '0');
                int dec = Convert.ToInt16(tmp.Substring(6, 2));

                workRow[8] = Alarm_Status(tmp.Substring(2, 4));
                tmp = (Convert.ToString(info_bytes[cnt + 1], 2)).PadLeft(8, '0') + (Convert.ToString(info_bytes[cnt + 2], 2)).PadLeft(8, '0');
                workRow[9] = Convert.ToInt16(tmp, 2);
                tmp = (Convert.ToString(info_bytes[cnt + 3], 2)).PadLeft(8, '0') + (Convert.ToString(info_bytes[cnt + 4], 2)).PadLeft(8, '0');

                if (dec == 1)
                {
                    workRow[10] = (float)(Convert.ToInt16(tmp, 2)) / 10;
                }
                else if (dec == 2)
                {
                    workRow[10] = (float)(Convert.ToInt16(tmp, 2)) / 100;
                }
                else if (dec == 3)
                {
                    workRow[10] = (float)(Convert.ToInt16(tmp, 2)) / 1000;
                }
                else
                {
                    workRow[10] = Convert.ToInt16(tmp, 2);
                }
                tmp = (Convert.ToString(info_bytes[cnt + 5], 2)).PadLeft(8, '0') + (Convert.ToString(info_bytes[cnt + 6], 2)).PadLeft(8, '0');
                workRow[11] = Convert.ToInt16(tmp, 2);
            }
            else if (s == 0x12 || s == 0x22)//O2
            {
                tmp = (Convert.ToString(info_bytes[cnt], 2)).PadLeft(8, '0');
                int dec = Convert.ToInt16(tmp.Substring(6, 2), 2);

                workRow[12] = Alarm_Status(tmp.Substring(2, 4));

                tmp = (Convert.ToString(info_bytes[cnt + 1], 2)).PadLeft(8, '0') + (Convert.ToString(info_bytes[cnt + 2], 2)).PadLeft(8, '0');

                if (dec == 1)
                {
                    workRow[13] = (float)(Convert.ToInt16(tmp, 2)) / 10;
                }
                else if (dec == 2)
                {
                    workRow[13] = (float)(Convert.ToInt16(tmp, 2)) / 100;
                }
                else if (dec == 3)
                {
                    workRow[13] = (float)(Convert.ToInt16(tmp, 2)) / 1000;
                }
                else
                {
                    workRow[13] = Convert.ToInt16(tmp, 2);
                }
            }
            else if (s == 0x13 || s == 0x23)//LEL
            {
                tmp = (Convert.ToString(info_bytes[cnt], 2)).PadLeft(8, '0');
                int dec = Convert.ToInt16(tmp.Substring(6, 2), 2);
                workRow[14] = Alarm_Status(tmp.Substring(2, 4));
                tmp = (Convert.ToString(info_bytes[cnt + 1], 2)).PadLeft(8, '0') + (Convert.ToString(info_bytes[cnt + 2], 2)).PadLeft(8, '0');

                if (dec == 1)
                {
                    workRow[15] = (float)(Convert.ToInt16(tmp, 2)) / 10;
                }
                else if (dec == 2)
                {
                    workRow[15] = (float)(Convert.ToInt16(tmp, 2)) / 100;
                }
                else if (dec == 3)
                {
                    workRow[15] = (float)(Convert.ToInt16(tmp, 2)) / 1000;
                }
                else
                {
                    workRow[15] = Convert.ToInt16(tmp, 2);
                }
            }
            else if (s == 0x14 || s == 0x24) //Battery
            {

            }
            else if (s == 0x15 || s == 0x25)//Temp
            {
            }
            else if (s == 0x16 || s == 0x26)//Pressure
            {

            }
            else if (s == 0x17 || s == 0x27)//pump
            {

            }

            return workRow;
        }

        //datalog 센서 option flags
        public string SensorOptionFlags(string s)
        {
            string result = "";
            if (s.Substring(0, 1) == "1") { result += "Sensor Disabled "; }
            if (s.Substring(1, 1) == "1") { result += "Autozero Sensor "; }
            if (s.Substring(2, 1) == "1") { result += "Low Alarm Ack "; }
            if (s.Substring(3, 1) == "1") { result += "LEL Overspan "; }
            if (s.Substring(4, 1) == "1") { result += "LEL by Vol "; }
            if (s.Substring(5, 1) == "1") { result += "O2 208 Base "; }
            return result;
        }

        //센서 event 정보
        public string sens_uc_event(byte s)
        {
            string tmp = Convert.ToString(s, 2).PadLeft(8, '0');
            int p = Convert.ToInt32(tmp.Substring(0, 4));

            string e = tmp.Substring(4, 4);
            string result = "";
            switch (e)
            {
                case "0000": result = "Self test"; break;
                case "0001": result = "Bump test"; break;
                case "0010": result = "Auto zero"; break;
                case "0011": result = "Span"; break;
                case "0100": result = "OL protection"; break;
                case "0101": result = "Ramp protection"; break;
                case "0110": result = "O2 protection"; break;
            }
            if (p >= 1000) { result += " Fail"; p -= 1000; }

            if (p >= 100) { result += " Pass"; p -= 100; }
            if (p >= 10) { result += " (IR)"; }

            return result;
        }

        /*
        public bool isvalid(Int32 value)
        {
            if (value < 30000 && value > -30000)
                return true;
            else
                return false;
        }*/
        /*
        public string chargingAlarmParse(byte b)
        {
            string result = "";

            if ((b & 1) == 1) result += "Alarm Start; ";
            else result += "Alarm Stop; ";

            if ((b & 2) == 2) result += "Device On; ";
            else result += "Device Off; ";

            return result;
        }*/

        /*
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
        }*/

        //UInt32 curConst;

        //datalog file parsing
        public void datalog_parsing_max_xt(TextBox tb,CheckBox checkBox1)
        {
            //zero filter 여부
            if (!checkBox1.Checked)
            {
                filter_check = false;
            }
            else
            {
                filter_check = true;
            }

            //file 선택
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "file open";
            ofd.FileName = "test";
            ofd.Filter = "data log from IDX|*.dal|data log from Microdock|*.BWX|data log from FM|MXd.fm";
            byte[] info_bytes = new byte[1500];
            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dt = new DataTable();
                fileName = ofd.SafeFileName;
                filePath = ofd.FileName;
                FileInfo fi = new FileInfo(filePath);
                fileLength = fi.Length;
                if (!fileName.Contains("MX")&&Path.GetExtension(ofd.FileName)== ".dal")
                {
                    MessageBox.Show("Wrong file!");
                }

                else
                {

                    string[] lines;
                    byte[] file;
                    byte[] line = new byte[4];

                    int sz = 0;
                    string sn = "";
                    string fw = "";
                    
                    //MXd.fm 파일(fleet manager datalog file) parsing
                    if (Path.GetExtension(ofd.FileName) == ".fm"&&fileName.Contains("MXd"))
                    {
                        string[] info_string = new string[1500];
                        byte[] calDateTime = new byte[4];
                        int seek = 0;
                        file = File.ReadAllBytes(filePath);
                        lines = File.ReadAllLines(filePath);
                        SetUpData2();
                        byte s = file[seek];
                        int cnt = 0;
                        
                        while (cnt < lines.Length)
                        {
                            string dock_time = "";
                            sn = "";
                            info_string = lines[cnt].Split(',');
                            for(int i = 0; i < 3; i++)
                            {
                                if (i == 0) {
                                    sn = info_string[i];
                                }
                                else if (i == 1)
                                {
                                    dock_time = info_string[i];
                                }
                                else if (i == 2)
                                {
                                    if (info_string[i].Equals("IE"))
                                    {
                                        dt.Rows.Add(sn, dock_time, "Unit Event", fm_IE(info_string[3]));
                                    }
                                    else if (info_string[i].Equals("SE"))
                                    {
                                        dt.Rows.Add(sn, dock_time, "Sensor Event",fm_Channel(info_string[3])+fm_SE(info_string[4])+fm_SE_IR(info_string[5])+fm_SE_Result(info_string[6]));
                                    }
                                    else if (info_string[i].Equals("R"))
                                    {
                                        dt.Rows.Add(sn, dock_time, "readings", fm_Readings(info_string[3]), fm_Readings(info_string[4].Split(':')[0]), info_string[5], info_string[6], info_string[7], info_string[8], info_string[9]
                                            , fm_Readings(info_string[10]),info_string[11], info_string[12], info_string[13], info_string[14], info_string[15]
                                            , fm_Readings(info_string[16]), info_string[17], info_string[18], info_string[19]
                                            , fm_Readings(info_string[20]), info_string[21], info_string[22], info_string[23]
                                            , fm_UnitOption(info_string[24]), info_string[25], fm_language(info_string[26])
                                            , fm_sensorOptFlags(info_string[27]), info_string[28], info_string[29], info_string[30], info_string[31], info_string[32], info_string[33], info_string[34], info_string[35]
                                            , fm_sensorOptFlags(info_string[36]), info_string[37], info_string[38], info_string[39], info_string[40], info_string[41], info_string[42], info_string[43], info_string[44]
                                            , fm_sensorOptFlags(info_string[45]), info_string[46], info_string[47], info_string[48], info_string[49]
                                            , fm_sensorOptFlags(info_string[50]), info_string[51], info_string[52], info_string[53], info_string[54]);
                                            
                                    }
                                }
                            }
                            cnt++;
                        }
                    }

                    //.BWX 파일 parsing
                    else if (Path.GetExtension(ofd.FileName) == ".BWX")
                    {
                        info_bytes = new byte[1500];
                        byte[] calDateTime = new byte[4];
                        int seek = 0;
                        file = File.ReadAllBytes(filePath);
                        lines = File.ReadAllLines(filePath);

                        if (!lines[0].Contains("Max XT"))
                        {
                            MessageBox.Show("It is not MaxXT Data log file!");
                            return;
                        }
                        
                        else if (lines[1].Length > 17 || lines[1].Length < 16)
                        {
                            MessageBox.Show("Device's Serial Number is invalid!");
                            return;
                        }
                        sn = lines[1].Split(':')[1];
                        
                        if (lines[2].Contains("FW:"))
                        {
                            fw = lines[2].Split(':')[1];
                        }
                        
                        seek = lines[0].Length + 2 + lines[1].Length + 2 + lines[2].Length + 2 +2 ;
                       
                        SetUpData();
                        byte s;
                        sz = file.Length - seek;
                        
                        
                        do
                        {
                            s = file[seek];
                            if (s == 0 && sz < 4)
                            {
                                break;
                            }
                            if (s == 0xff&&sz>=4) //
                            {

                                seek += 4;
                                if (file[seek] == 0x40)
                                {
                                    tempRow = dt.NewRow();
                                    seek++;
                                    string i = Convert.ToString(file[seek + 2], 2).PadLeft(8, '0') + Convert.ToString(file[seek + 3], 2).PadLeft(8, '0');
                                    logging_interval = Convert.ToInt16(i.Substring(4, 12), 2);
                                    seek += 4;
                                    if (file[seek] == 0x50)
                                    {
                                        tempRow[2] = "Gas Reading";
                                        seek++;

                                        seek += 75;
                                    }
                                    if (file[seek] == 0x30)
                                    {
                                        seek++;
                                        tempRow[2] = "Gas Reading";
                                        tempRow[3] = Inst_status(file[seek], file[seek + 1]);
                                        seek += 2;
                                        while ((file[seek] >= 0x20 && file[seek] <= 0x27) || (file[seek] >= 0x10 && file[seek] <= 0x17))
                                        {
                                            int t = findsize(file[seek]);
                                            tempRow = Sens_Reading(file, seek, tempRow);
                                            seek += t + 1;
                                        }
                                        if (dt.Rows.Count >= 1)
                                        {
                                            tempRow[1] = dt.Rows[dt.Rows.Count - 1][1];
                                            tempRow[1] = Convert.ToDateTime(tempRow[1]).AddMilliseconds(logging_interval * 1000);
                                        }
                                    }
                                    sz -= 128;
                                }
                                else
                                {
                                    sz -= 4;
                                }

                            }
                            else
                            {
                                int cnt = 0;
                                info_bytes = new byte[3000];
                                try
                                {
                                    while (sz > 2)
                                    {
                                        s = file[seek];
                                        if (s.Equals(null))
                                        {
                                            break;
                                        }
                                        int t = findsize(s);

                                        if (t != 0)
                                        {
                                            info_bytes[cnt] = s;
                                            cnt++;

                                            seek++;
                                            sz--;

                                            if (s == 0x80)
                                            {
                                                DateTime date_time = new DateTime();
                                                string bit = "";
                                                for (int k = 0; k < t; k++)
                                                {
                                                    calDateTime[k] = file[seek + k];
                                                    bit += Convert.ToString(calDateTime[k], 2).PadRight(8, '0');

                                                }
                                                string[] reverse = new string[4];
                                                string date_bytes;
                                                BitArray bits = new BitArray(calDateTime);
                                                for (int n = 0; n < 32; n++)
                                                {
                                                    reverse[n / 8] = make_bit(bits[n]) + reverse[n / 8];
                                                }

                                                date_bytes = reverse[0] + reverse[1] + reverse[2] + reverse[3];
                                                int hour = Convert.ToInt32(date_bytes.Substring(16, 4), 2);

                                                if (date_bytes.Substring(0, 1).Equals("1"))
                                                {
                                                    hour += 12;
                                                }

                                                seek += t;
                                                sz -= t;
                                                date_time = new DateTime((2000 + Convert.ToInt32(date_bytes.Substring(1, 6), 2)), Convert.ToInt32(date_bytes.Substring(7, 4), 2), Convert.ToInt32(date_bytes.Substring(11, 5), 2), hour, Convert.ToInt32(date_bytes.Substring(20, 6), 2), Convert.ToInt32(date_bytes.Substring(26, 6), 2));


                                                MakeData(workRow, info_bytes, sn, date_time,tb,seek);

                                                info_bytes = new byte[3000];


                                            }
                                            else if (s == 0x90)
                                            {
                                                for (int k = 0; k < t; k++)
                                                {
                                                    info_bytes[cnt] = file[seek + k];
                                                    cnt++;
                                                }
                                                seek += t;
                                                sz -= t;
                                                DateTime date_time = Convert.ToDateTime(dt.Rows[dt.Rows.Count - 1][1]);


                                                if (info_bytes != null)
                                                {
                                                    MakeData(workRow, info_bytes, sn, date_time, tb, seek);
                                                }

                                                info_bytes = new byte[3000];

                                            }
                                            else
                                            {
                                                for (int k = 0; k < t; k++)
                                                {
                                                    info_bytes[cnt] = file[seek + k];
                                                    cnt++;
                                                }

                                                seek += t;
                                                sz -= t;
                                            }

                                        }
                                        else { break; }
                                    }
                                }
                                catch (System.Exception e)
                                {
                                }
                            }
                        } while (sz > 4&&!s.Equals(null));
                       
                    }

                    //.dal 파일 parsing
                    else if (Path.GetExtension(ofd.FileName) == ".dal")
                    {
                        info_bytes = new byte[1500];
                        
                        file = File.ReadAllBytes(filePath);
                        lines = File.ReadAllLines(filePath);
                        int seek = 0;
                        byte[] calDateTime = new byte[4];
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
                                        header_cnt = 0;
                                        break;
                                    }
                                }

                                seek += 2;
                                sz = Convert.ToInt32(size);

                                do
                                {
                                    s = file[seek];
                                    if (s == 0x0d)
                                    {
                                        seek+=2;sz-=2;
                                        break;
                                    }
                                    if (s == 0x0a)
                                    {
                                        seek++;sz--;break;
                                    }
                                    
                                    if (s == 0xff) //
                                    {

                                        seek += 4;
                                        if (file[seek] == 0x40)
                                        {
                                            tempRow = dt.NewRow();
                                            seek++;
                                            string i = Convert.ToString(file[seek + 2], 2).PadLeft(8, '0') + Convert.ToString(file[seek + 3], 2).PadLeft(8, '0');
                                            logging_interval = Convert.ToInt16(i.Substring(4, 12), 2);
                                            seek += 4;
                                            if (file[seek] == 0x50)
                                            {
                                                tempRow[2] = "Gas Reading";
                                                seek++;

                                                seek += 75;
                                            }
                                            if (file[seek] == 0x30)
                                            {
                                                seek++;
                                                tempRow[2] = "Gas Reading";
                                                tempRow[3] = Inst_status(file[seek], file[seek + 1]);
                                                seek += 2;
                                                while ((file[seek] >= 0x20 && file[seek] <= 0x27) || (file[seek] >= 0x10 && file[seek] <= 0x17))
                                                {
                                                    int t = findsize(file[seek]);
                                                    tempRow = Sens_Reading(file, seek, tempRow);
                                                    seek += t + 1;
                                                }
                                                if (dt.Rows.Count >= 1)
                                                {
                                                    tempRow[1] = dt.Rows[dt.Rows.Count - 1][1];
                                                    tempRow[1] = Convert.ToDateTime(tempRow[1]).AddMilliseconds(logging_interval * 1000);
                                                }
                                            }
                                            sz -= 128;
                                        }
                                        else if (file[seek] == 0xff) {
                                            while (file[seek] == 0xff) {
                                                seek++;
                                                sz--;
                                            }
                                        }
                                        else
                                        {
                                            sz -= 4;
                                        }

                                    }
                                    else
                                    {
                                        int cnt = 0;
                                        info_bytes = new byte[3000];
                                        try
                                        {
                                            while (sz > 2)
                                            {
                                                s = file[seek];
                                                int t = findsize(s);

                                                if (t != 0)
                                                {
                                                    info_bytes[cnt] = s;
                                                    cnt++;

                                                    seek++;
                                                    sz--;

                                                    if (s == 0x80)
                                                    {
                                                        DateTime date_time = new DateTime();
                                                        string bit = "";
                                                        for (int k = 0; k < t; k++)
                                                        {
                                                            calDateTime[k] = file[seek + k];
                                                            bit += Convert.ToString(calDateTime[k], 2).PadRight(8, '0');

                                                        }
                                                        string[] reverse = new string[4];
                                                        string date_bytes;
                                                        BitArray bits = new BitArray(calDateTime);
                                                        for (int n = 0; n < 32; n++)
                                                        {
                                                            reverse[n / 8] = make_bit(bits[n]) + reverse[n / 8];
                                                        }

                                                        date_bytes = reverse[0] + reverse[1] + reverse[2] + reverse[3];
                                                        int hour = Convert.ToInt32(date_bytes.Substring(16, 4), 2);

                                                        if (date_bytes.Substring(0, 1).Equals("1"))
                                                        {
                                                            hour += 12;
                                                        }

                                                        seek += t;
                                                        sz -= t;
                                                        date_time = new DateTime((2000 + Convert.ToInt32(date_bytes.Substring(1, 6), 2)), Convert.ToInt32(date_bytes.Substring(7, 4), 2), Convert.ToInt32(date_bytes.Substring(11, 5), 2), hour, Convert.ToInt32(date_bytes.Substring(20, 6), 2), Convert.ToInt32(date_bytes.Substring(26, 6), 2));


                                                        MakeData(workRow, info_bytes, sn, date_time, tb, seek);

                                                        info_bytes = new byte[3000];


                                                    }
                                                    else if (s == 0x90)
                                                    {
                                                        for (int k = 0; k < t; k++)
                                                        {
                                                            info_bytes[cnt] = file[seek + k];
                                                            cnt++;
                                                        }
                                                        seek += t;
                                                        sz -= t;
                                                        DateTime date_time = Convert.ToDateTime(dt.Rows[dt.Rows.Count - 1][1]);


                                                        if (info_bytes != null)
                                                        {
                                                            MakeData(workRow, info_bytes, sn, date_time, tb, seek);
                                                        }

                                                        info_bytes = new byte[3000];

                                                    }

                                                    else
                                                    {
                                                        for (int k = 0; k < t; k++)
                                                        {
                                                            info_bytes[cnt] = file[seek + k];
                                                            cnt++;
                                                        }

                                                        seek += t;
                                                        sz -= t;
                                                    }

                                                }
                                                else { seek++;sz--; break; }
                                            }
                                        }
                                        catch (System.Exception e)
                                        {
                                            //Console.WriteLine(e.Message);
                                        }
                                    }

                                } while (seek<fileLength-1);
                            }
                            seek++;
                            sz--;
                        }

                    }
                }
            }
        }

        //datatable에 Row 추가
        public void MakeData(DataRow workRow, byte[] info_bytes, string sn, DateTime deviceTime, TextBox tb, int seek)
        {
            tb.Text = seek + "/" + fileLength;
            tb.Refresh();
            int cnt = 0;
            byte s;
            workRow = dt.NewRow();
            if (info_bytes[0]==128)
            {
                workRow.ItemArray = dt.Rows[dt.Rows.Count - 1].ItemArray;
                workRow[1] = deviceTime.ToString("yyyy/MM/dd HH:mm:ss");
                
                dt.Rows.Add(workRow);
               
                workRow = dt.NewRow();

            }
            while (!info_bytes[cnt].Equals(null))
            {
                s = info_bytes[cnt];
                cnt++;

                workRow[0] = sn;
                workRow[1] = deviceTime.ToString("yyyy/MM/dd HH:mm:ss"); 
                if (s == 0x30)
                {
                    int num = dt.Rows.Count - 1;
                    if (num >= 0)
                    {
                        workRow.ItemArray = dt.Rows[num].ItemArray;
                    }
                    while (!dt.Rows[num][2].Equals("Gas Reading")&&num>0)
                    {
                        num--;
                        workRow.ItemArray = dt.Rows[num].ItemArray;
                    }
                    workRow[2] = "Gas Reading";
                    
                    workRow[3] = Inst_status(info_bytes[cnt], info_bytes[cnt + 1]);
                    cnt += 2;
                    bool check_once = false;
                    while ((info_bytes[cnt] >= 0x20 && info_bytes[cnt] <= 0x27) || (info_bytes[cnt] >= 0x10 && info_bytes[cnt] <= 0x17))
                    {
                        
                        if (info_bytes[cnt]==0x20)
                        {
                            if (!check_once)
                            {
                                check_once = true;
                            }
                            else
                            {
                                //DataRow tr = dt.NewRow();
                                //tr = Sens_Reading(info_bytes, cnt, tr);
                                //if (!tr[4].Equals(workRow[4]))
                                //{
                                    workRow[1] = Convert.ToDateTime(dt.Rows[dt.Rows.Count - 1][1]).AddMilliseconds(logging_interval * 1000).ToString("yyyy/MM/dd HH:mm:ss"); 
                                    dt.Rows.Add(workRow);
                               
                                workRow = dt.NewRow();
                                    workRow.ItemArray = dt.Rows[dt.Rows.Count - 1].ItemArray;
                                //}
                            }
                            
                            
                        }
                        int t = findsize(info_bytes[cnt]);
                        workRow = Sens_Reading(info_bytes, cnt, workRow);
                        cnt += t + 1;

                    }
                    workRow[1] = Convert.ToDateTime(dt.Rows[dt.Rows.Count - 1][1]).AddMilliseconds(logging_interval * 1000).ToString("yyyy/MM/dd HH:mm:ss"); 

                    dt.Rows.Add(workRow);
                   
                    workRow = dt.NewRow();
                }
                else if (s == 0x40)
                {
                    string i = Convert.ToString(info_bytes[cnt + 2], 2).PadLeft(8, '0') + Convert.ToString(info_bytes[cnt + 3], 2).PadLeft(8, '0');
                    logging_interval = Convert.ToInt16(i.Substring(4, 12), 2);
                    cnt += 4;
                    if (info_bytes[cnt] == 0x50)
                    {
                        cnt += 76;
                    }
                }
                else if (s == 0x50)
                {
                    cnt += 75;
                }
                else if (s == 0x60)
                {
                    workRow[2] = "Sensor Event";
                    workRow[3] = "H2S " + sens_uc_event(info_bytes[cnt]);
                    cnt++;
                    dt.Rows.Add(workRow);
                   
                    workRow = dt.NewRow();
                }
                else if (s == 0x61)
                {
                    workRow[2] = "Sensor Event";
                    workRow[3] = "CO " + sens_uc_event(info_bytes[cnt]);
                    cnt++;
                    dt.Rows.Add(workRow);
                   
                    workRow = dt.NewRow();
                }
                else if (s == 0x62)
                {
                    workRow[2] = "Sensor Event";
                    workRow[3] = "O2 " + sens_uc_event(info_bytes[cnt]);
                    cnt++;
                    dt.Rows.Add(workRow);
                   
                    workRow = dt.NewRow();
                }
                else if (s == 0x63)
                {
                    workRow[2] = "Sensor Event";
                    workRow[3] = "LEL " + sens_uc_event(info_bytes[cnt]);
                    cnt++;
                    dt.Rows.Add(workRow);
                   
                    workRow = dt.NewRow();
                }
                else if (s == 0x64)
                {
                    workRow[2] = "Sensor Event";
                    workRow[3] = "Battery " + sens_uc_event(info_bytes[cnt]);
                    cnt++;
                    dt.Rows.Add(workRow);
                   
                    workRow = dt.NewRow();
                }
                else if (s == 0x65)
                {
                    workRow[2] = "Sensor Event";
                    workRow[3] = "Temperature " + sens_uc_event(info_bytes[cnt]);
                    cnt++;
                    dt.Rows.Add(workRow);
                   
                    workRow = dt.NewRow();
                }
                else if (s == 0x66)
                {

                    workRow[2] = "Sensor Event";
                    workRow[3] = "Pressure " + sens_uc_event(info_bytes[cnt]);
                    cnt++;
                    dt.Rows.Add(workRow);
                   
                    workRow = dt.NewRow();
                }
                else if (s == 0x67)
                {
                    workRow[2] = "Sensor Event";
                    workRow[3] = "Pump " + sens_uc_event(info_bytes[cnt]);
                    cnt += 1;
                    dt.Rows.Add(workRow);
                   
                    workRow = dt.NewRow();
                }
                else if (s == 0x70)
                {
                    workRow[2] = "Unit Event";
                    if (info_bytes[cnt] == 0x03)
                    {
                        workRow[3] = uc_event(info_bytes[cnt]) + ":" + info_bytes[cnt + 2];
                    }
                    else if (info_bytes[cnt] == 0x06)
                    {
                        string a = Convert.ToString(info_bytes[cnt + 1], 2).PadLeft(8, '0') + Convert.ToString(info_bytes[cnt + 2], 2).PadLeft(8, '0');
                        int siteNum = Convert.ToInt16(a, 2);
                        workRow[3] = uc_event(info_bytes[cnt]) + ":" + siteNum;
                    }
                    else
                    {
                        workRow[3] = uc_event(info_bytes[cnt]);
                    }
                    cnt += 3;
                    dt.Rows.Add(workRow);
                   
                    workRow = dt.NewRow();
                }
                else if (s == 0x90)
                {
                    if (!filter_check)
                    {
                        int tmp = Convert.ToInt32(info_bytes[cnt]);

                        while (tmp > 0)
                        {
                            

                            if (!dt.Rows[dt.Rows.Count - 1][2].Equals("Gas Reading"))
                            {
                                workRow.ItemArray = tempRow.ItemArray;
                                workRow[0] = sn;
                            }
                            else
                            {
                                workRow.ItemArray = dt.Rows[dt.Rows.Count - 1].ItemArray;
                            }

                            workRow[1] = (Convert.ToDateTime(dt.Rows[dt.Rows.Count - 1][1]).AddMilliseconds(logging_interval * 1000)).ToString("yyyy/MM/dd HH:mm:ss"); 
                            dt.Rows.Add(workRow);
                           
                            workRow = dt.NewRow();
                            tmp--;
                        }

                    }
                    else
                    {
                        dt.Rows[dt.Rows.Count - 1].Delete();
                    }


                    cnt += 2;
                }
                else if (((s >= 0x20 && s <= 0x27) || (s >= 0x10 && s <= 0x17)) && !filter_check)
                {
                    int num = dt.Rows.Count - 1;
                    workRow.ItemArray = dt.Rows[num].ItemArray;
                    
                    while (!dt.Rows[num][2].Equals("Gas Reading")) {
                        num--;
                        workRow.ItemArray = dt.Rows[num].ItemArray;
                    }
                    workRow[2] = "Gas Reading";
                    cnt--;
                    while ((s >= 0x20 && s<= 0x27) || (s >= 0x10 && s <= 0x17))
                    {
                        int t = findsize(info_bytes[cnt]);
                        workRow = Sens_Reading(info_bytes, cnt, workRow);
                        cnt += t + 1;
                        s = info_bytes[cnt];

                    }
                    workRow[1] = Convert.ToDateTime(workRow[1]).AddMilliseconds(logging_interval * 1000).ToString("yyyy/MM/dd HH:mm:ss"); 

                    dt.Rows.Add(workRow);
                   
                    workRow = dt.NewRow();
                }



            }




        }


    }
}
