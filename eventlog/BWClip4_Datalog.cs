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
    public class BWClip4_Datalog
    {
        public DataTable dt;
        public string fileName; public string filePath;
        string[] header_info = new string[20];
        byte[] binfile;
        
        
        //setting datatable columns
        public void SetUpData()
        {
            dt.Columns.Add("System Tick");
            dt.Columns.Add("UTC Time Stamp");
            dt.Columns.Add("Raw AD Ch #1");
            dt.Columns.Add("Raw AD Ch #2");
            dt.Columns.Add("Raw AD Ch #3");
            dt.Columns.Add("Raw AD Ch #4");
            dt.Columns.Add("Gas Conc Ch #1");
            dt.Columns.Add("Gas Conc Ch #2");
            dt.Columns.Add("Gas Conc Ch #3");
            dt.Columns.Add("Gas Conc Ch #4");
            dt.Columns.Add("H2S TWA Value");
            dt.Columns.Add("CO TWA Value");
            dt.Columns.Add("H2S STEL Value");
            dt.Columns.Add("CO STEL Value");
            dt.Columns.Add("Status Ch #1");
            dt.Columns.Add("Status Ch #2");
            dt.Columns.Add("Status Ch #3");
            dt.Columns.Add("Status Ch #4");
            dt.Columns.Add("MIPEX NTC AD");
            dt.Columns.Add("Remaining Life Time");
            dt.Columns.Add("Temperature");
            dt.Columns.Add("Battery Voltage");
            dt.Columns.Add("Reserved1");
            dt.Columns.Add("Reserved2");
            
        }
        
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
        public void datalog_parsing_bwc4()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "file open";
            ofd.FileName = "test";
            ofd.Filter = "data log 파일|*.bin";
            DialogResult dr = ofd.ShowDialog();
            string FW_ver = string.Empty;
            string Mipex = string.Empty;
            UInt16 NumofLog;
            UInt16 CRC;
            DataRow workRow;
            if (dr == DialogResult.OK)
            {
                dt = new DataTable();
                fileName = ofd.SafeFileName;
                filePath = ofd.FileName;

                SetUpData();
                binfile = File.ReadAllBytes(filePath);

                for (int j = 0; j < 12; j++)
                {
                    FW_ver += (char)binfile[j];
                }
                if (FW_ver.Contains("WVR"))
                {

                    for (int j = 12; j < 20; j++)
                    {
                        Mipex += (char)(binfile[j]);
                    }

                    NumofLog = BitConverter.ToUInt16(binfile, 20);

                    CRC = BitConverter.ToUInt16(binfile, 22);

                    int cnt = 0;
                    while (cnt < NumofLog)
                    {
                        workRow = dt.NewRow();

                        //System Tick
                        workRow[0] = Math.Round(BitConverter.ToUInt32(binfile, 24 + cnt * 64) / 31.25);

                        //Time
                        workRow[1] = bwTime(BitConverter.ToUInt32(binfile, 28 + cnt * 64));

                        //RawAD
                        for (int j = 0; j < 4; j++)
                        {
                            workRow[2 + j] = BitConverter.ToInt16(binfile, 32 + j * 2 + cnt * 64);
                        }

                        //Gas conc
                        for (int j = 0; j < 4; j++)
                        {
                            workRow[6 + j] = (float)BitConverter.ToInt32(binfile, 40 + j * 4 + cnt * 64) / 100;
                        }

                        //TWA,STEL
                        for (int j = 0; j < 4; j++)
                        {
                            workRow[10 + j] = BitConverter.ToInt16(binfile, 56 + j * 2 + cnt * 64);
                        }

                        //status,mipex
                        for (int j = 0; j < 5; j++)
                        {
                            workRow[14 + j] = BitConverter.ToUInt16(binfile, 64 + j * 2 + cnt * 64);
                        }

                        //remaininglifetime
                        workRow[19] = BitConverter.ToUInt32(binfile, 74 + cnt * 64);

                        //temperature
                        workRow[20] = BitConverter.ToInt16(binfile, 78 + cnt * 64);

                        //battvol,reserved1,reserved2,crc
                        for (int j = 0; j < 3; j++)
                        {
                            workRow[21 + j] = BitConverter.ToUInt16(binfile, 80 + j * 2 + cnt * 64);
                        }
                        dt.Rows.Add(workRow);
                        cnt++;
                    }

                }
                else
                {
                    MessageBox.Show("Wrong File!");
                }
            }
            
        }




    }
}
