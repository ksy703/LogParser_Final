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
    public class BWClip_Datalog
    {
        public DataTable dt;
        public string fileName; public string filePath; long fileLength; public string binfile_header;
        string[] header_info = new string[20];

        //Data Table Columns setting
        public void SetUpData()
        {
            dt.Columns.Add("Gas Reading");
            dt.Columns.Add("Raw ADC");
            dt.Columns.Add("Temperature");
            dt.Columns.Add("Battery Voltage");
            dt.Columns.Add("UTC Time");
        }


        //Get Time
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
        public void datalog_parsing_bwc()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "file open";
            ofd.FileName = "test";
            ofd.Filter = "bin 파일|*.bin";

            DialogResult dr = ofd.ShowDialog();
            if (dr == DialogResult.OK)
            {
                dt = new DataTable();
                fileName = ofd.SafeFileName;
                filePath = ofd.FileName;
                FileInfo fi = new FileInfo(filePath);
                fileLength = fi.Length;
                DataRow workRow;

                try
                {
                    BinaryReader rdr = new BinaryReader(File.Open(filePath, FileMode.Open));
                    byte[] info_bytes = new byte[13];


                    SetUpData();

                    while (rdr.BaseStream.Position < fileLength-21)
                    {
                        workRow = dt.NewRow();
                        info_bytes = rdr.ReadBytes(13);

                        /* [0]: Gas reading
                         * [1]: Raw ADC
                         * [2]: Temperature
                         * [3]: Battery Voltage
                         * [4]: UTC time
                        */
                        workRow[0] = BitConverter.ToInt32(info_bytes, 0);
                        workRow[1] = BitConverter.ToInt16(info_bytes, 4);
                        workRow[2] = Convert.ToInt16(info_bytes[6]);
                        workRow[3] = BitConverter.ToUInt16(info_bytes, 7);
                        workRow[4] = (Convert.ToDateTime("1970/1/1").AddSeconds(BitConverter.ToUInt32(info_bytes, 9))).ToString("yyyy'/'MM'/'dd HH:mm:ss");

                        dt.Rows.Add(workRow);

                    }
                    rdr.Close();
                }


                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }


            }



        }
    }
}
