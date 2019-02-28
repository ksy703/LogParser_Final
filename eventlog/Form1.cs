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
using System.Threading;
using System.Reflection;

namespace log
{
    

    public partial class Form1 : Form
    {
        public MaxXT_Eventlog mxt;
        public MaxXT_Datalog d_mxt;
        public MicroClip_Eventlog mcp;
        public MicroClip_Datalog d_mcp;
        public BWClip4_Eventlog bwc4;
        public BWClip4_Datalog d_bwc4;
        public BWClip_Eventlog bwc;
        public BWClip_Datalog d_bwc;


        public Form1()
        {
            InitializeComponent();
            mxt = new MaxXT_Eventlog();
            d_mxt = new MaxXT_Datalog();
            mcp = new MicroClip_Eventlog();
            d_mcp = new MicroClip_Datalog();
            bwc4 = new BWClip4_Eventlog();
            d_bwc4 = new BWClip4_Datalog();
            bwc = new BWClip_Eventlog();
            d_bwc = new BWClip_Datalog();
        }

        //zero filter checkBox
        public void tabcontol_index_change(object sender, EventArgs e)
        {
            if (tabControl2.SelectedIndex == 1 && (tabControl3.SelectedIndex == 1 || tabControl3.SelectedIndex == 0))
            {
                checkBox1.Visible = true;
            }
            else
            {
                checkBox1.Visible = false;
            }
        }

        //MaxXT Datalog
        public void MaxXT_Datalog_import_button_Click(object sender, EventArgs e)
        {
            dataGridView4.Columns.Clear();
            dataGridView4.DoubleBuffered(true);

            button8.Enabled = false;
            button7.Enabled = false;
            checkBox1.Enabled = false;
            d_mxt.datalog_parsing_max_xt(textBox4,checkBox1);
            if (d_mxt.dt != null)
            {
                textBox4.Text = "Wait...(few minutes)\r\n";
                textBox4.Refresh();
                
                if (checkBox1.Checked)
                {
                    d_mxt.dt = d_mxt.dt.DefaultView.ToTable(true);
                }
                /*
                dataGridView4.DataSource = d_mxt.dt;
                dataGridView4.EditMode = DataGridViewEditMode.EditProgrammatically;
                */
                dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridView4.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
                dataGridView4.RowHeadersVisible = false;
                dataGridView4.SuspendLayout();
                System.Diagnostics.Stopwatch st = new System.Diagnostics.Stopwatch();
                st.Start();
                this.dataGridView4.DataSource = d_mxt.dt;
                st.Stop();
                System.Diagnostics.Debug.WriteLine(st.Elapsed.ToString());
                this.dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                
                this.dataGridView4.ResumeLayout();
                /*
                dataGridView4.DataSource = d_mxt.dt;
                dataGridView4.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView4.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView4.ResumeLayout();
                */
                dataGridView4.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            textBox4.Text = "Selected : " + d_mxt.filePath + "\r\n";
            button8.Enabled = true;
            button7.Enabled = true;
            checkBox1.Enabled = true;
        }

        //MaxXT Eventlog
        public void MaxXT_Eventlog_import_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DoubleBuffered(true);
            textBox1.Text = "Reading...\r\n";
            mxt.eventlog_parsing_max_xt();
            if (mxt.dt != null)
            {
                mxt.dt = mxt.dt.DefaultView.ToTable(true);
                dataGridView1.DataSource = mxt.dt;
                dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            textBox1.Text = "Selected : " + mxt.filePath + "\r\n";
        }

        //MicroClip Datalog
        public void MicroClip_Datalog_import_button_Click(object sender, EventArgs e)
        {
            dataGridView5.Columns.Clear();
            dataGridView5.DoubleBuffered(true);
            textBox5.Text = "Reading...\r\n";
            d_mcp.datalog_parsing_micro_clip(textBox5, checkBox1);
            if (d_mcp.dt != null)
            {
                dataGridView5.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridView5.SuspendLayout();
                dataGridView5.DataSource = d_mcp.dt;
                dataGridView5.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView5.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView5.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView5.Columns[20].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView5.Columns[22].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView5.Columns[24].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView5.ResumeLayout();
                dataGridView5.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            textBox5.Text = "Selected : " + d_mcp.filePath + "\r\n";
        }

        //MicroClip Eventlog
        public void MicroClip_Eventlog_import_button_Click(object sender, EventArgs e)
        {
            dataGridView2.Columns.Clear();
            dataGridView2.DoubleBuffered(true);
            textBox2.Text = "Reading...\r\n";
            mcp.eventlog_parsing_micro_clip();
            if (mcp.dt != null)
            {
                mcp.dt = mcp.dt.DefaultView.ToTable(true);
                dataGridView2.DataSource = mcp.dt;
                dataGridView2.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            textBox2.Text = "Selected : " + mcp.filePath + "\r\n";
        }

        //BWClip4 Datalog
        public void BWClip4_Datalog_import_button_Click(object sender, EventArgs e)
        {
            dataGridView6.Columns.Clear();
            dataGridView6.DoubleBuffered(true);
            textBox6.Text = "Reading...\r\n";
            d_bwc4.datalog_parsing_bwc4();
            if (d_bwc4.dt != null)
            {
                d_bwc4.dt = d_bwc4.dt.DefaultView.ToTable(true);
                dataGridView6.DataSource = d_bwc4.dt;
                dataGridView6.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            textBox6.Text = "Selected: " + d_bwc4.filePath + "\r\n";
        }

        //BWClip4 Eventlog
        private void BWClip4_Eventlog_import_button_Click(object sender, EventArgs e)
        {
            dataGridView3.Columns.Clear();
            dataGridView3.DoubleBuffered(true);
            textBox3.Text = "Reading...\r\n";
            bwc4.eventlog_parsing_bwc4();
            if (bwc4.dt != null)
            {
                bwc4.dt = bwc4.dt.DefaultView.ToTable(true);
                dataGridView3.DataSource = bwc4.dt;
                dataGridView3.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            textBox3.Text = "Selected: " + bwc4.filePath + "\r\n";
        }

        //BWClip Eventlog
        private void BWClip_Eventlog_import_button_Click(object sender, EventArgs e)
        {
            dataGridView7.Columns.Clear();
            dataGridView7.DoubleBuffered(true);
            textBox7.Text = "Reading...\r\n";
            bwc.eventlog_parsing_bwc();
            if (bwc.dt != null)
            {
                bwc.dt = bwc.dt.DefaultView.ToTable(true);
                dataGridView7.DataSource = bwc.dt;
                dataGridView7.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            textBox7.Text = "Selected: " + bwc.filePath + "\r\n";
        }

        //BWClip Datalog
        private void BWClip_Datalog_import_button_Click(object sender, EventArgs e)
        {
            dataGridView8.Columns.Clear();
            dataGridView8.DoubleBuffered(true);
            textBox8.Text = "Reading...\r\n";
            d_bwc.datalog_parsing_bwc();
            if (d_bwc.dt != null)
            {
                d_bwc.dt = d_bwc.dt.DefaultView.ToTable(true);
                dataGridView8.DataSource = d_bwc.dt;
                dataGridView8.EditMode = DataGridViewEditMode.EditProgrammatically;
            }
            textBox8.Text = "Selected: " + d_bwc.filePath + "\r\n";
        }

        //write data to CSV file
        public void writeCSV(DataGridView gridIn, string outputFile)
        {
            try
            {
                //test to see if the DataGridView has any rows
                if (gridIn.RowCount > 0)
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "csv|*.csv";
                    saveFileDialog1.Title = "Save Data";
                    saveFileDialog1.FileName = outputFile;
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string Filepath = saveFileDialog1.FileName;
                        FileStream fs = (FileStream)saveFileDialog1.OpenFile();
                        StreamWriter swOut = new StreamWriter(fs);
                        DataTable dt = (DataTable)gridIn.DataSource;

                        //write header rows to csv
                        for (int i = 0; i < gridIn.Columns.Count; i++)
                        {
                            swOut.Write(gridIn.Columns[i].HeaderText + ",");
                        }
                        swOut.WriteLine();

                        //write DataGridView rows to csv
                        for (int j = 0; j < gridIn.Rows.Count; j++)
                        {
                            for (int i = 0; i < gridIn.Columns.Count; i++)
                            {
                                swOut.Write(dt.Rows[j][i] + ",");
                            }
                            swOut.WriteLine();
                        }
                        swOut.Close();
                        MessageBox.Show("Converted successfully to *.csv format");
                    }
                }
                else
                {
                    MessageBox.Show("No data to save");
                }


            }
            catch (System.Exception ex) { MessageBox.Show(ex.Message); };
        }

        //save to csv file
        public void SaveToCSV_button_Click(object sender, EventArgs e)
        {
            if (tabControl2.SelectedTab == tabPage4 && tabControl1.SelectedTab == tabPage1)
            {
                writeCSV(dataGridView1, mxt.fileName.Split('.')[0]);
            }
            else if (tabControl2.SelectedTab == tabPage4 && tabControl1.SelectedTab == tabPage2)
            {
                writeCSV(dataGridView2, mcp.fileName.Split('.')[0]);
            }
            else if (tabControl2.SelectedTab == tabPage4 && tabControl1.SelectedTab == tabPage3)
            {
                writeCSV(dataGridView3, bwc4.fileName.Split('.')[0]);
            }
            else if (tabControl2.SelectedTab == tabPage5 && tabControl3.SelectedTab == tabPage6)
            {
                writeCSV(dataGridView4, d_mxt.fileName.Split('.')[0]);
            }
            else if (tabControl2.SelectedTab == tabPage5 && tabControl3.SelectedTab == tabPage7)
            {
                writeCSV(dataGridView5, d_mcp.fileName.Split('.')[0]);
            }
            else if (tabControl2.SelectedTab == tabPage5 && tabControl3.SelectedTab == tabPage8)
            {
                writeCSV(dataGridView6, d_bwc4.fileName.Split('.')[0]);
            }else if (tabControl2.SelectedTab == tabPage4 && tabControl1.SelectedTab == tabPage9)
            {
                writeCSV(dataGridView7, bwc.fileName.Split('.')[0]);
            }
            else
            {
                writeCSV(dataGridView8, d_bwc.fileName.Split('.')[0]);
            }
        }

        //tab design
        private void tabControl2_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl2.TabPages[e.Index];
            Color col = e.Index == 0 ? Color.PowderBlue : Color.MistyRose;
            Rectangle rect = new Rectangle(e.Bounds.X+4, e.Bounds.Y, e.Bounds.Width-3, e.Bounds.Height+5);
            e.Graphics.FillRectangle(new SolidBrush(col), rect);
            Rectangle paddedBounds = e.Bounds;
            Font f = new Font(Font, FontStyle.Bold);
            int yOffset = (e.State == DrawItemState.Selected) ? -1 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, f, paddedBounds, page.ForeColor);
        }
    }

    //DataGridView 대용량 데이터 로딩 지연 완화
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)

        {

            Type dgvType = dgv.GetType();

            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",

                BindingFlags.Instance | BindingFlags.NonPublic);

            pi.SetValue(dgv, setting, null);

        }

    }
}
