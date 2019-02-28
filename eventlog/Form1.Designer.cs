namespace log
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H2S_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H2S_Peak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CO_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CO_Peak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O2_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O2_Peak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LEL_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LEL_Peak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.microclip_duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.microclip_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemainingSeconds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceRemainingLifetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eventype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Channel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H2STWA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H2SSTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COTWA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTimeinUTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BatteryVoltageinAlarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirwareVersion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H2SLowAlarmPt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H2SHighAlarmPt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H2STWAAlarmPt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H2SSTELAlarmPt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COLowAlarmPt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COHighAlarmPt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COTWAAlarmPt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COSTELAlarmPt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O2LowAlarmPt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O2HighAlarmPt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LELLowAlarmPt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LELHighAlarmPt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O2LowTrigger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O2HighTrigger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSelfTests = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Totaleventtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numberofeventtrasfered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn76 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn77 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn78 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn79 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn80 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn81 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn82 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn83 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn84 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn85 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn86 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn87 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn88 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn89 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn90 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn91 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn92 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn93 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn94 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn95 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn96 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn97 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn98 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn99 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn100 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn101 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn102 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn103 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn104 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn105 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn106 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn107 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn108 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn109 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn110 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn112 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn67 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn68 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn69 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn70 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn71 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn72 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn73 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn74 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn75 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel22 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel23 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView8 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn113 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn114 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn115 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn116 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn117 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn118 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn119 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn120 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn121 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn122 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn123 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn124 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn125 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn126 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn127 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn128 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn129 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn130 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn131 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn132 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn133 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn134 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn135 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn136 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn137 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn138 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn139 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn140 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn141 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn142 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn143 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn144 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn145 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn146 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn147 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn148 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn149 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel24 = new System.Windows.Forms.TableLayoutPanel();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.tabPage10.SuspendLayout();
            this.tableLayoutPanel22.SuspendLayout();
            this.tableLayoutPanel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).BeginInit();
            this.tableLayoutPanel24.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl2.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tabControl2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl2.Location = new System.Drawing.Point(1, 17);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(896, 657);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 8;
            this.tabControl2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl2_DrawItem);
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabcontol_index_change);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.PowderBlue;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage4.Controls.Add(this.tabControl1);
            this.tabPage4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(888, 630);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Eventlog";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(4, 6);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(879, 618);
            this.tabControl1.TabIndex = 8;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabcontol_index_change);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.tableLayoutPanel5);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Controls.Add(this.tableLayoutPanel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(871, 591);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MaxXT";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.button2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(708, 488);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(160, 105);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "save to csv";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveToCSV_button_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MaxXT_Eventlog_import_button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 488);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(702, 103);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(696, 97);
            this.textBox1.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 388F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(869, 484);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SerialNumber,
            this.StartTime,
            this.EventType,
            this.Duration,
            this.H2S_Status,
            this.H2S_Peak,
            this.CO_Status,
            this.CO_Peak,
            this.O2_Status,
            this.O2_Peak,
            this.LEL_Status,
            this.LEL_Peak});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(863, 478);
            this.dataGridView1.TabIndex = 2;
            // 
            // SerialNumber
            // 
            this.SerialNumber.HeaderText = "Serial Number";
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            this.SerialNumber.Width = 75;
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Start Time";
            this.StartTime.Name = "StartTime";
            this.StartTime.ReadOnly = true;
            this.StartTime.Width = 69;
            // 
            // EventType
            // 
            this.EventType.HeaderText = "Event Type";
            this.EventType.Name = "EventType";
            this.EventType.ReadOnly = true;
            this.EventType.Width = 69;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 88;
            // 
            // H2S_Status
            // 
            this.H2S_Status.HeaderText = "H2S Status";
            this.H2S_Status.Name = "H2S_Status";
            this.H2S_Status.ReadOnly = true;
            this.H2S_Status.Width = 94;
            // 
            // H2S_Peak
            // 
            this.H2S_Peak.HeaderText = "H2S Peak (ppm)";
            this.H2S_Peak.Name = "H2S_Peak";
            this.H2S_Peak.ReadOnly = true;
            this.H2S_Peak.Width = 119;
            // 
            // CO_Status
            // 
            this.CO_Status.HeaderText = "CO Status";
            this.CO_Status.Name = "CO_Status";
            this.CO_Status.ReadOnly = true;
            this.CO_Status.Width = 87;
            // 
            // CO_Peak
            // 
            this.CO_Peak.HeaderText = "CO Peak (ppm)";
            this.CO_Peak.Name = "CO_Peak";
            this.CO_Peak.ReadOnly = true;
            this.CO_Peak.Width = 81;
            // 
            // O2_Status
            // 
            this.O2_Status.HeaderText = "O2 Status";
            this.O2_Status.Name = "O2_Status";
            this.O2_Status.ReadOnly = true;
            this.O2_Status.Width = 87;
            // 
            // O2_Peak
            // 
            this.O2_Peak.HeaderText = "O2 Peak (%Vol)";
            this.O2_Peak.Name = "O2_Peak";
            this.O2_Peak.ReadOnly = true;
            this.O2_Peak.Width = 81;
            // 
            // LEL_Status
            // 
            this.LEL_Status.HeaderText = "LEL Status";
            this.LEL_Status.Name = "LEL_Status";
            this.LEL_Status.ReadOnly = true;
            this.LEL_Status.Width = 94;
            // 
            // LEL_Peak
            // 
            this.LEL_Peak.HeaderText = "LEL Peak (%LEL)";
            this.LEL_Peak.Name = "LEL_Peak";
            this.LEL_Peak.ReadOnly = true;
            this.LEL_Peak.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Controls.Add(this.tableLayoutPanel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(871, 591);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "MicroClip";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(708, 488);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(160, 105);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(3, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "save to csv";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.SaveToCSV_button_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 45);
            this.button4.TabIndex = 0;
            this.button4.Text = "Import";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.MicroClip_Eventlog_import_button_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 488);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(702, 103);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(696, 97);
            this.textBox2.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.dataGridView2, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 388F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(869, 484);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowDrop = true;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn12,
            this.microclip_duration,
            this.microclip_status});
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(863, 478);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Serial Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 69;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Event Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 69;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Bump?";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 67;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "H2S Peak (ppm)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 119;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "CO Peak (ppm)";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 81;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "O2 Peak (%Vol)";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 81;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "LEL Peak (%LEL)";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // microclip_duration
            // 
            this.microclip_duration.HeaderText = "Duration";
            this.microclip_duration.Name = "microclip_duration";
            this.microclip_duration.ReadOnly = true;
            this.microclip_duration.Width = 88;
            // 
            // microclip_status
            // 
            this.microclip_status.HeaderText = "Device Status";
            this.microclip_status.Name = "microclip_status";
            this.microclip_status.ReadOnly = true;
            this.microclip_status.Width = 75;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.tableLayoutPanel9);
            this.tabPage3.Controls.Add(this.tableLayoutPanel8);
            this.tabPage3.Controls.Add(this.tableLayoutPanel7);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(871, 591);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "BW Clip4";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.button6, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.button5, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(708, 488);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(160, 105);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(3, 57);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 45);
            this.button6.TabIndex = 6;
            this.button6.Text = "save to csv";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.SaveToCSV_button_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 45);
            this.button5.TabIndex = 1;
            this.button5.Text = "Import";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BWClip4_Eventlog_import_button_Click);
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.textBox3, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 488);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(702, 103);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(3, 3);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(696, 97);
            this.textBox3.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.dataGridView3, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(869, 484);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowDrop = true;
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.RemainingSeconds,
            this.DeviceRemainingLifetime,
            this.Eventype,
            this.Channel,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.H2STWA,
            this.H2SSTEL,
            this.COTWA,
            this.COSTEL,
            this.StartTimeinUTC,
            this.Temperature,
            this.BatteryVoltageinAlarm,
            this.FirwareVersion,
            this.H2SLowAlarmPt,
            this.H2SHighAlarmPt,
            this.H2STWAAlarmPt,
            this.H2SSTELAlarmPt,
            this.COLowAlarmPt,
            this.COHighAlarmPt,
            this.COTWAAlarmPt,
            this.COSTELAlarmPt,
            this.O2LowAlarmPt,
            this.O2HighAlarmPt,
            this.LELLowAlarmPt,
            this.LELHighAlarmPt,
            this.O2LowTrigger,
            this.O2HighTrigger,
            this.TotalSelfTests,
            this.Totaleventtime,
            this.Numberofeventtrasfered,
            this.dataGridViewTextBoxColumn18});
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(863, 478);
            this.dataGridView3.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Serial Number";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 75;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 69;
            // 
            // RemainingSeconds
            // 
            this.RemainingSeconds.HeaderText = "Remaining Seconds";
            this.RemainingSeconds.Name = "RemainingSeconds";
            this.RemainingSeconds.ReadOnly = true;
            this.RemainingSeconds.Width = 138;
            // 
            // DeviceRemainingLifetime
            // 
            this.DeviceRemainingLifetime.HeaderText = "Device\'s Remaining Lifetime";
            this.DeviceRemainingLifetime.Name = "DeviceRemainingLifetime";
            this.DeviceRemainingLifetime.ReadOnly = true;
            this.DeviceRemainingLifetime.Width = 201;
            // 
            // Eventype
            // 
            this.Eventype.HeaderText = "Event Type";
            this.Eventype.Name = "Eventype";
            this.Eventype.ReadOnly = true;
            this.Eventype.Width = 69;
            // 
            // Channel
            // 
            this.Channel.HeaderText = "Channel";
            this.Channel.Name = "Channel";
            this.Channel.ReadOnly = true;
            this.Channel.Width = 81;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 88;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "H2S Peak (ppm)";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 119;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "CO Peak (ppm)";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 81;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "O2 Peak (%Vol)";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 81;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "LEL Peak (%LEL)";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // H2STWA
            // 
            this.H2STWA.HeaderText = "H2S TWA";
            this.H2STWA.Name = "H2STWA";
            this.H2STWA.ReadOnly = true;
            this.H2STWA.Width = 56;
            // 
            // H2SSTEL
            // 
            this.H2SSTEL.HeaderText = "H2S STEL";
            this.H2SSTEL.Name = "H2SSTEL";
            this.H2SSTEL.ReadOnly = true;
            this.H2SSTEL.Width = 81;
            // 
            // COTWA
            // 
            this.COTWA.HeaderText = "CO TWA";
            this.COTWA.Name = "COTWA";
            this.COTWA.ReadOnly = true;
            this.COTWA.Width = 69;
            // 
            // COSTEL
            // 
            this.COSTEL.HeaderText = "CO STEL";
            this.COSTEL.Name = "COSTEL";
            this.COSTEL.ReadOnly = true;
            this.COSTEL.Width = 75;
            // 
            // StartTimeinUTC
            // 
            this.StartTimeinUTC.HeaderText = "Start Time in UTC";
            this.StartTimeinUTC.Name = "StartTimeinUTC";
            this.StartTimeinUTC.ReadOnly = true;
            this.StartTimeinUTC.Width = 119;
            // 
            // Temperature
            // 
            this.Temperature.HeaderText = "Temperature";
            this.Temperature.Name = "Temperature";
            this.Temperature.ReadOnly = true;
            this.Temperature.Width = 109;
            // 
            // BatteryVoltageinAlarm
            // 
            this.BatteryVoltageinAlarm.HeaderText = "Battery Voltage in Alarm";
            this.BatteryVoltageinAlarm.Name = "BatteryVoltageinAlarm";
            this.BatteryVoltageinAlarm.ReadOnly = true;
            this.BatteryVoltageinAlarm.Width = 150;
            // 
            // FirwareVersion
            // 
            this.FirwareVersion.HeaderText = "Firware Version";
            this.FirwareVersion.Name = "FirwareVersion";
            this.FirwareVersion.ReadOnly = true;
            this.FirwareVersion.Width = 81;
            // 
            // H2SLowAlarmPt
            // 
            this.H2SLowAlarmPt.HeaderText = "H2S Low Alarm Pt";
            this.H2SLowAlarmPt.Name = "H2SLowAlarmPt";
            this.H2SLowAlarmPt.ReadOnly = true;
            this.H2SLowAlarmPt.Width = 119;
            // 
            // H2SHighAlarmPt
            // 
            this.H2SHighAlarmPt.HeaderText = "H2S High Alarm Pt";
            this.H2SHighAlarmPt.Name = "H2SHighAlarmPt";
            this.H2SHighAlarmPt.ReadOnly = true;
            this.H2SHighAlarmPt.Width = 125;
            // 
            // H2STWAAlarmPt
            // 
            this.H2STWAAlarmPt.HeaderText = "H2S TWA Alarm Pt";
            this.H2STWAAlarmPt.Name = "H2STWAAlarmPt";
            this.H2STWAAlarmPt.ReadOnly = true;
            this.H2STWAAlarmPt.Width = 119;
            // 
            // H2SSTELAlarmPt
            // 
            this.H2SSTELAlarmPt.HeaderText = "H2S STEL Alarm Pt";
            this.H2SSTELAlarmPt.Name = "H2SSTELAlarmPt";
            this.H2SSTELAlarmPt.ReadOnly = true;
            this.H2SSTELAlarmPt.Width = 125;
            // 
            // COLowAlarmPt
            // 
            this.COLowAlarmPt.HeaderText = "CO Low Alarm Pt";
            this.COLowAlarmPt.Name = "COLowAlarmPt";
            this.COLowAlarmPt.ReadOnly = true;
            this.COLowAlarmPt.Width = 113;
            // 
            // COHighAlarmPt
            // 
            this.COHighAlarmPt.HeaderText = "CO High Alarm Pt";
            this.COHighAlarmPt.Name = "COHighAlarmPt";
            this.COHighAlarmPt.ReadOnly = true;
            this.COHighAlarmPt.Width = 119;
            // 
            // COTWAAlarmPt
            // 
            this.COTWAAlarmPt.HeaderText = "CO TWA Alarm Pt";
            this.COTWAAlarmPt.Name = "COTWAAlarmPt";
            this.COTWAAlarmPt.ReadOnly = true;
            this.COTWAAlarmPt.Width = 113;
            // 
            // COSTELAlarmPt
            // 
            this.COSTELAlarmPt.HeaderText = "CO STEL Alarm Pt";
            this.COSTELAlarmPt.Name = "COSTELAlarmPt";
            this.COSTELAlarmPt.ReadOnly = true;
            this.COSTELAlarmPt.Width = 119;
            // 
            // O2LowAlarmPt
            // 
            this.O2LowAlarmPt.HeaderText = "O2 Low Alarm Pt";
            this.O2LowAlarmPt.Name = "O2LowAlarmPt";
            this.O2LowAlarmPt.ReadOnly = true;
            this.O2LowAlarmPt.Width = 113;
            // 
            // O2HighAlarmPt
            // 
            this.O2HighAlarmPt.HeaderText = "O2 High Alarm Pt";
            this.O2HighAlarmPt.Name = "O2HighAlarmPt";
            this.O2HighAlarmPt.ReadOnly = true;
            this.O2HighAlarmPt.Width = 119;
            // 
            // LELLowAlarmPt
            // 
            this.LELLowAlarmPt.HeaderText = "LEL Low Alarm Pt";
            this.LELLowAlarmPt.Name = "LELLowAlarmPt";
            this.LELLowAlarmPt.ReadOnly = true;
            this.LELLowAlarmPt.Width = 119;
            // 
            // LELHighAlarmPt
            // 
            this.LELHighAlarmPt.HeaderText = "LEL High Alarm Pt";
            this.LELHighAlarmPt.Name = "LELHighAlarmPt";
            this.LELHighAlarmPt.ReadOnly = true;
            this.LELHighAlarmPt.Width = 125;
            // 
            // O2LowTrigger
            // 
            this.O2LowTrigger.HeaderText = "O2 Low Trigger";
            this.O2LowTrigger.Name = "O2LowTrigger";
            this.O2LowTrigger.ReadOnly = true;
            this.O2LowTrigger.Width = 119;
            // 
            // O2HighTrigger
            // 
            this.O2HighTrigger.HeaderText = "O2 High Trigger";
            this.O2HighTrigger.Name = "O2HighTrigger";
            this.O2HighTrigger.ReadOnly = true;
            this.O2HighTrigger.Width = 81;
            // 
            // TotalSelfTests
            // 
            this.TotalSelfTests.HeaderText = "Total Self Tests";
            this.TotalSelfTests.Name = "TotalSelfTests";
            this.TotalSelfTests.ReadOnly = true;
            this.TotalSelfTests.Width = 132;
            // 
            // Totaleventtime
            // 
            this.Totaleventtime.HeaderText = "Total event time(seconds)";
            this.Totaleventtime.Name = "Totaleventtime";
            this.Totaleventtime.ReadOnly = true;
            this.Totaleventtime.Width = 188;
            // 
            // Numberofeventtrasfered
            // 
            this.Numberofeventtrasfered.HeaderText = "Number of event trasfered";
            this.Numberofeventtrasfered.Name = "Numberofeventtrasfered";
            this.Numberofeventtrasfered.ReadOnly = true;
            this.Numberofeventtrasfered.Width = 188;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Device Status";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.ReadOnly = true;
            this.dataGridViewTextBoxColumn18.Width = 75;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage9.Controls.Add(this.tableLayoutPanel20);
            this.tabPage9.Controls.Add(this.tableLayoutPanel21);
            this.tabPage9.Controls.Add(this.tableLayoutPanel19);
            this.tabPage9.Location = new System.Drawing.Point(4, 23);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(871, 591);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "BW Clip";
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel20.ColumnCount = 1;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.Controls.Add(this.button13, 0, 1);
            this.tableLayoutPanel20.Controls.Add(this.button14, 0, 0);
            this.tableLayoutPanel20.Location = new System.Drawing.Point(708, 488);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 2;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(160, 105);
            this.tableLayoutPanel20.TabIndex = 2;
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(3, 57);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(154, 45);
            this.button13.TabIndex = 6;
            this.button13.Text = "save to csv";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.SaveToCSV_button_Click);
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(3, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(154, 45);
            this.button14.TabIndex = 1;
            this.button14.Text = "Import";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.BWClip_Eventlog_import_button_Click);
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel21.ColumnCount = 1;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel21.Controls.Add(this.textBox7, 0, 0);
            this.tableLayoutPanel21.Location = new System.Drawing.Point(3, 488);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 1;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel21.Size = new System.Drawing.Size(702, 103);
            this.tableLayoutPanel21.TabIndex = 3;
            // 
            // textBox7
            // 
            this.textBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox7.Location = new System.Drawing.Point(3, 3);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(696, 97);
            this.textBox7.TabIndex = 3;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel19.ColumnCount = 1;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Controls.Add(this.dataGridView7, 0, 0);
            this.tableLayoutPanel19.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 1;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(869, 484);
            this.tableLayoutPanel19.TabIndex = 1;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AllowDrop = true;
            this.dataGridView7.AllowUserToAddRows = false;
            this.dataGridView7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn76,
            this.dataGridViewTextBoxColumn77,
            this.dataGridViewTextBoxColumn78,
            this.dataGridViewTextBoxColumn79,
            this.dataGridViewTextBoxColumn80,
            this.dataGridViewTextBoxColumn81,
            this.dataGridViewTextBoxColumn82,
            this.dataGridViewTextBoxColumn83,
            this.dataGridViewTextBoxColumn84,
            this.dataGridViewTextBoxColumn85,
            this.dataGridViewTextBoxColumn86,
            this.dataGridViewTextBoxColumn87,
            this.dataGridViewTextBoxColumn88,
            this.dataGridViewTextBoxColumn89,
            this.dataGridViewTextBoxColumn90,
            this.dataGridViewTextBoxColumn91,
            this.dataGridViewTextBoxColumn92,
            this.dataGridViewTextBoxColumn93,
            this.dataGridViewTextBoxColumn94,
            this.dataGridViewTextBoxColumn95,
            this.dataGridViewTextBoxColumn96,
            this.dataGridViewTextBoxColumn97,
            this.dataGridViewTextBoxColumn98,
            this.dataGridViewTextBoxColumn99,
            this.dataGridViewTextBoxColumn100,
            this.dataGridViewTextBoxColumn101,
            this.dataGridViewTextBoxColumn102,
            this.dataGridViewTextBoxColumn103,
            this.dataGridViewTextBoxColumn104,
            this.dataGridViewTextBoxColumn105,
            this.dataGridViewTextBoxColumn106,
            this.dataGridViewTextBoxColumn107,
            this.dataGridViewTextBoxColumn108,
            this.dataGridViewTextBoxColumn109,
            this.dataGridViewTextBoxColumn110,
            this.dataGridViewTextBoxColumn111,
            this.dataGridViewTextBoxColumn112});
            this.dataGridView7.Location = new System.Drawing.Point(3, 3);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.ReadOnly = true;
            this.dataGridView7.RowTemplate.Height = 23;
            this.dataGridView7.Size = new System.Drawing.Size(863, 478);
            this.dataGridView7.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn76
            // 
            this.dataGridViewTextBoxColumn76.HeaderText = "Serial Number";
            this.dataGridViewTextBoxColumn76.Name = "dataGridViewTextBoxColumn76";
            this.dataGridViewTextBoxColumn76.ReadOnly = true;
            this.dataGridViewTextBoxColumn76.Width = 75;
            // 
            // dataGridViewTextBoxColumn77
            // 
            this.dataGridViewTextBoxColumn77.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn77.Name = "dataGridViewTextBoxColumn77";
            this.dataGridViewTextBoxColumn77.ReadOnly = true;
            this.dataGridViewTextBoxColumn77.Width = 69;
            // 
            // dataGridViewTextBoxColumn78
            // 
            this.dataGridViewTextBoxColumn78.HeaderText = "Remaining Seconds";
            this.dataGridViewTextBoxColumn78.Name = "dataGridViewTextBoxColumn78";
            this.dataGridViewTextBoxColumn78.ReadOnly = true;
            this.dataGridViewTextBoxColumn78.Width = 138;
            // 
            // dataGridViewTextBoxColumn79
            // 
            this.dataGridViewTextBoxColumn79.HeaderText = "Device\'s Remaining Lifetime";
            this.dataGridViewTextBoxColumn79.Name = "dataGridViewTextBoxColumn79";
            this.dataGridViewTextBoxColumn79.ReadOnly = true;
            this.dataGridViewTextBoxColumn79.Width = 201;
            // 
            // dataGridViewTextBoxColumn80
            // 
            this.dataGridViewTextBoxColumn80.HeaderText = "Event Type";
            this.dataGridViewTextBoxColumn80.Name = "dataGridViewTextBoxColumn80";
            this.dataGridViewTextBoxColumn80.ReadOnly = true;
            this.dataGridViewTextBoxColumn80.Width = 69;
            // 
            // dataGridViewTextBoxColumn81
            // 
            this.dataGridViewTextBoxColumn81.HeaderText = "Channel";
            this.dataGridViewTextBoxColumn81.Name = "dataGridViewTextBoxColumn81";
            this.dataGridViewTextBoxColumn81.ReadOnly = true;
            this.dataGridViewTextBoxColumn81.Width = 81;
            // 
            // dataGridViewTextBoxColumn82
            // 
            this.dataGridViewTextBoxColumn82.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn82.Name = "dataGridViewTextBoxColumn82";
            this.dataGridViewTextBoxColumn82.ReadOnly = true;
            this.dataGridViewTextBoxColumn82.Width = 88;
            // 
            // dataGridViewTextBoxColumn83
            // 
            this.dataGridViewTextBoxColumn83.HeaderText = "H2S Peak (ppm)";
            this.dataGridViewTextBoxColumn83.Name = "dataGridViewTextBoxColumn83";
            this.dataGridViewTextBoxColumn83.ReadOnly = true;
            this.dataGridViewTextBoxColumn83.Width = 119;
            // 
            // dataGridViewTextBoxColumn84
            // 
            this.dataGridViewTextBoxColumn84.HeaderText = "CO Peak (ppm)";
            this.dataGridViewTextBoxColumn84.Name = "dataGridViewTextBoxColumn84";
            this.dataGridViewTextBoxColumn84.ReadOnly = true;
            this.dataGridViewTextBoxColumn84.Width = 81;
            // 
            // dataGridViewTextBoxColumn85
            // 
            this.dataGridViewTextBoxColumn85.HeaderText = "O2 Peak (%Vol)";
            this.dataGridViewTextBoxColumn85.Name = "dataGridViewTextBoxColumn85";
            this.dataGridViewTextBoxColumn85.ReadOnly = true;
            this.dataGridViewTextBoxColumn85.Width = 81;
            // 
            // dataGridViewTextBoxColumn86
            // 
            this.dataGridViewTextBoxColumn86.HeaderText = "LEL Peak (%LEL)";
            this.dataGridViewTextBoxColumn86.Name = "dataGridViewTextBoxColumn86";
            this.dataGridViewTextBoxColumn86.ReadOnly = true;
            this.dataGridViewTextBoxColumn86.Width = 125;
            // 
            // dataGridViewTextBoxColumn87
            // 
            this.dataGridViewTextBoxColumn87.HeaderText = "H2S TWA";
            this.dataGridViewTextBoxColumn87.Name = "dataGridViewTextBoxColumn87";
            this.dataGridViewTextBoxColumn87.ReadOnly = true;
            this.dataGridViewTextBoxColumn87.Width = 56;
            // 
            // dataGridViewTextBoxColumn88
            // 
            this.dataGridViewTextBoxColumn88.HeaderText = "H2S STEL";
            this.dataGridViewTextBoxColumn88.Name = "dataGridViewTextBoxColumn88";
            this.dataGridViewTextBoxColumn88.ReadOnly = true;
            this.dataGridViewTextBoxColumn88.Width = 81;
            // 
            // dataGridViewTextBoxColumn89
            // 
            this.dataGridViewTextBoxColumn89.HeaderText = "CO TWA";
            this.dataGridViewTextBoxColumn89.Name = "dataGridViewTextBoxColumn89";
            this.dataGridViewTextBoxColumn89.ReadOnly = true;
            this.dataGridViewTextBoxColumn89.Width = 69;
            // 
            // dataGridViewTextBoxColumn90
            // 
            this.dataGridViewTextBoxColumn90.HeaderText = "CO STEL";
            this.dataGridViewTextBoxColumn90.Name = "dataGridViewTextBoxColumn90";
            this.dataGridViewTextBoxColumn90.ReadOnly = true;
            this.dataGridViewTextBoxColumn90.Width = 75;
            // 
            // dataGridViewTextBoxColumn91
            // 
            this.dataGridViewTextBoxColumn91.HeaderText = "Start Time in UTC";
            this.dataGridViewTextBoxColumn91.Name = "dataGridViewTextBoxColumn91";
            this.dataGridViewTextBoxColumn91.ReadOnly = true;
            this.dataGridViewTextBoxColumn91.Width = 119;
            // 
            // dataGridViewTextBoxColumn92
            // 
            this.dataGridViewTextBoxColumn92.HeaderText = "Temperature";
            this.dataGridViewTextBoxColumn92.Name = "dataGridViewTextBoxColumn92";
            this.dataGridViewTextBoxColumn92.ReadOnly = true;
            this.dataGridViewTextBoxColumn92.Width = 109;
            // 
            // dataGridViewTextBoxColumn93
            // 
            this.dataGridViewTextBoxColumn93.HeaderText = "Battery Voltage in Alarm";
            this.dataGridViewTextBoxColumn93.Name = "dataGridViewTextBoxColumn93";
            this.dataGridViewTextBoxColumn93.ReadOnly = true;
            this.dataGridViewTextBoxColumn93.Width = 150;
            // 
            // dataGridViewTextBoxColumn94
            // 
            this.dataGridViewTextBoxColumn94.HeaderText = "Firware Version";
            this.dataGridViewTextBoxColumn94.Name = "dataGridViewTextBoxColumn94";
            this.dataGridViewTextBoxColumn94.ReadOnly = true;
            this.dataGridViewTextBoxColumn94.Width = 81;
            // 
            // dataGridViewTextBoxColumn95
            // 
            this.dataGridViewTextBoxColumn95.HeaderText = "H2S Low Alarm Pt";
            this.dataGridViewTextBoxColumn95.Name = "dataGridViewTextBoxColumn95";
            this.dataGridViewTextBoxColumn95.ReadOnly = true;
            this.dataGridViewTextBoxColumn95.Width = 119;
            // 
            // dataGridViewTextBoxColumn96
            // 
            this.dataGridViewTextBoxColumn96.HeaderText = "H2S High Alarm Pt";
            this.dataGridViewTextBoxColumn96.Name = "dataGridViewTextBoxColumn96";
            this.dataGridViewTextBoxColumn96.ReadOnly = true;
            this.dataGridViewTextBoxColumn96.Width = 125;
            // 
            // dataGridViewTextBoxColumn97
            // 
            this.dataGridViewTextBoxColumn97.HeaderText = "H2S TWA Alarm Pt";
            this.dataGridViewTextBoxColumn97.Name = "dataGridViewTextBoxColumn97";
            this.dataGridViewTextBoxColumn97.ReadOnly = true;
            this.dataGridViewTextBoxColumn97.Width = 119;
            // 
            // dataGridViewTextBoxColumn98
            // 
            this.dataGridViewTextBoxColumn98.HeaderText = "H2S STEL Alarm Pt";
            this.dataGridViewTextBoxColumn98.Name = "dataGridViewTextBoxColumn98";
            this.dataGridViewTextBoxColumn98.ReadOnly = true;
            this.dataGridViewTextBoxColumn98.Width = 125;
            // 
            // dataGridViewTextBoxColumn99
            // 
            this.dataGridViewTextBoxColumn99.HeaderText = "CO Low Alarm Pt";
            this.dataGridViewTextBoxColumn99.Name = "dataGridViewTextBoxColumn99";
            this.dataGridViewTextBoxColumn99.ReadOnly = true;
            this.dataGridViewTextBoxColumn99.Width = 113;
            // 
            // dataGridViewTextBoxColumn100
            // 
            this.dataGridViewTextBoxColumn100.HeaderText = "CO High Alarm Pt";
            this.dataGridViewTextBoxColumn100.Name = "dataGridViewTextBoxColumn100";
            this.dataGridViewTextBoxColumn100.ReadOnly = true;
            this.dataGridViewTextBoxColumn100.Width = 119;
            // 
            // dataGridViewTextBoxColumn101
            // 
            this.dataGridViewTextBoxColumn101.HeaderText = "CO TWA Alarm Pt";
            this.dataGridViewTextBoxColumn101.Name = "dataGridViewTextBoxColumn101";
            this.dataGridViewTextBoxColumn101.ReadOnly = true;
            this.dataGridViewTextBoxColumn101.Width = 113;
            // 
            // dataGridViewTextBoxColumn102
            // 
            this.dataGridViewTextBoxColumn102.HeaderText = "CO STEL Alarm Pt";
            this.dataGridViewTextBoxColumn102.Name = "dataGridViewTextBoxColumn102";
            this.dataGridViewTextBoxColumn102.ReadOnly = true;
            this.dataGridViewTextBoxColumn102.Width = 119;
            // 
            // dataGridViewTextBoxColumn103
            // 
            this.dataGridViewTextBoxColumn103.HeaderText = "O2 Low Alarm Pt";
            this.dataGridViewTextBoxColumn103.Name = "dataGridViewTextBoxColumn103";
            this.dataGridViewTextBoxColumn103.ReadOnly = true;
            this.dataGridViewTextBoxColumn103.Width = 113;
            // 
            // dataGridViewTextBoxColumn104
            // 
            this.dataGridViewTextBoxColumn104.HeaderText = "O2 High Alarm Pt";
            this.dataGridViewTextBoxColumn104.Name = "dataGridViewTextBoxColumn104";
            this.dataGridViewTextBoxColumn104.ReadOnly = true;
            this.dataGridViewTextBoxColumn104.Width = 119;
            // 
            // dataGridViewTextBoxColumn105
            // 
            this.dataGridViewTextBoxColumn105.HeaderText = "LEL Low Alarm Pt";
            this.dataGridViewTextBoxColumn105.Name = "dataGridViewTextBoxColumn105";
            this.dataGridViewTextBoxColumn105.ReadOnly = true;
            this.dataGridViewTextBoxColumn105.Width = 119;
            // 
            // dataGridViewTextBoxColumn106
            // 
            this.dataGridViewTextBoxColumn106.HeaderText = "LEL High Alarm Pt";
            this.dataGridViewTextBoxColumn106.Name = "dataGridViewTextBoxColumn106";
            this.dataGridViewTextBoxColumn106.ReadOnly = true;
            this.dataGridViewTextBoxColumn106.Width = 125;
            // 
            // dataGridViewTextBoxColumn107
            // 
            this.dataGridViewTextBoxColumn107.HeaderText = "O2 Low Trigger";
            this.dataGridViewTextBoxColumn107.Name = "dataGridViewTextBoxColumn107";
            this.dataGridViewTextBoxColumn107.ReadOnly = true;
            this.dataGridViewTextBoxColumn107.Width = 119;
            // 
            // dataGridViewTextBoxColumn108
            // 
            this.dataGridViewTextBoxColumn108.HeaderText = "O2 High Trigger";
            this.dataGridViewTextBoxColumn108.Name = "dataGridViewTextBoxColumn108";
            this.dataGridViewTextBoxColumn108.ReadOnly = true;
            this.dataGridViewTextBoxColumn108.Width = 81;
            // 
            // dataGridViewTextBoxColumn109
            // 
            this.dataGridViewTextBoxColumn109.HeaderText = "Total Self Tests";
            this.dataGridViewTextBoxColumn109.Name = "dataGridViewTextBoxColumn109";
            this.dataGridViewTextBoxColumn109.ReadOnly = true;
            this.dataGridViewTextBoxColumn109.Width = 132;
            // 
            // dataGridViewTextBoxColumn110
            // 
            this.dataGridViewTextBoxColumn110.HeaderText = "Total event time(seconds)";
            this.dataGridViewTextBoxColumn110.Name = "dataGridViewTextBoxColumn110";
            this.dataGridViewTextBoxColumn110.ReadOnly = true;
            this.dataGridViewTextBoxColumn110.Width = 188;
            // 
            // dataGridViewTextBoxColumn111
            // 
            this.dataGridViewTextBoxColumn111.HeaderText = "Number of event trasfered";
            this.dataGridViewTextBoxColumn111.Name = "dataGridViewTextBoxColumn111";
            this.dataGridViewTextBoxColumn111.ReadOnly = true;
            this.dataGridViewTextBoxColumn111.Width = 188;
            // 
            // dataGridViewTextBoxColumn112
            // 
            this.dataGridViewTextBoxColumn112.HeaderText = "Device Status";
            this.dataGridViewTextBoxColumn112.Name = "dataGridViewTextBoxColumn112";
            this.dataGridViewTextBoxColumn112.ReadOnly = true;
            this.dataGridViewTextBoxColumn112.Width = 75;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage5.Controls.Add(this.tabControl3);
            this.tabPage5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage5.Location = new System.Drawing.Point(4, 23);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(888, 630);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Datalog";
            // 
            // tabControl3
            // 
            this.tabControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Controls.Add(this.tabPage7);
            this.tabControl3.Controls.Add(this.tabPage8);
            this.tabControl3.Controls.Add(this.tabPage10);
            this.tabControl3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl3.Location = new System.Drawing.Point(4, 6);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(879, 618);
            this.tabControl3.TabIndex = 9;
            this.tabControl3.SelectedIndexChanged += new System.EventHandler(this.tabcontol_index_change);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tableLayoutPanel10);
            this.tabPage6.Controls.Add(this.tableLayoutPanel11);
            this.tabPage6.Controls.Add(this.tableLayoutPanel12);
            this.tabPage6.Location = new System.Drawing.Point(4, 23);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(871, 591);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "MaxXT";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel10.AutoSize = true;
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.button7, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.button8, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(708, 488);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(160, 105);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(3, 57);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 45);
            this.button7.TabIndex = 5;
            this.button7.Text = "save to csv";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.SaveToCSV_button_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(3, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(154, 45);
            this.button8.TabIndex = 0;
            this.button8.Text = "Import";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.MaxXT_Datalog_import_button_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.textBox4, 0, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 488);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 1;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(702, 103);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(3, 3);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(696, 97);
            this.textBox4.TabIndex = 2;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.dataGridView4, 0, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 388F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(869, 484);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView4.AllowDrop = true;
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowTemplate.Height = 23;
            this.dataGridView4.Size = new System.Drawing.Size(863, 478);
            this.dataGridView4.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Serial Number";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 75;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 69;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "Event Type";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 69;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.ReadOnly = true;
            this.dataGridViewTextBoxColumn20.Width = 88;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "H2S Status";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.ReadOnly = true;
            this.dataGridViewTextBoxColumn21.Width = 94;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "H2S Peak (ppm)";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Width = 119;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.HeaderText = "CO Status";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 87;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "CO Peak (ppm)";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 81;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.HeaderText = "O2 Status";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            this.dataGridViewTextBoxColumn25.Width = 87;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.HeaderText = "O2 Peak (%Vol)";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.ReadOnly = true;
            this.dataGridViewTextBoxColumn26.Width = 81;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.HeaderText = "LEL Status";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.ReadOnly = true;
            this.dataGridViewTextBoxColumn27.Width = 94;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.HeaderText = "LEL Peak (%LEL)";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.ReadOnly = true;
            this.dataGridViewTextBoxColumn28.Width = 125;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.tableLayoutPanel13);
            this.tabPage7.Controls.Add(this.tableLayoutPanel14);
            this.tabPage7.Controls.Add(this.tableLayoutPanel15);
            this.tabPage7.Location = new System.Drawing.Point(4, 23);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(871, 591);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "MicroClip";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel13.AutoSize = true;
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.button9, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.button10, 0, 0);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(708, 488);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(160, 105);
            this.tableLayoutPanel13.TabIndex = 2;
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(3, 57);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(154, 45);
            this.button9.TabIndex = 5;
            this.button9.Text = "save to csv";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.SaveToCSV_button_Click);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(3, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(154, 45);
            this.button10.TabIndex = 0;
            this.button10.Text = "Import";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.MicroClip_Datalog_import_button_Click);
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Controls.Add(this.textBox5, 0, 0);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(1, 488);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(702, 103);
            this.tableLayoutPanel14.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(3, 3);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(696, 97);
            this.textBox5.TabIndex = 2;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Controls.Add(this.dataGridView5, 0, 0);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 388F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(869, 484);
            this.tableLayoutPanel15.TabIndex = 0;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowDrop = true;
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36,
            this.dataGridViewTextBoxColumn37,
            this.dataGridViewTextBoxColumn38});
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.RowTemplate.Height = 23;
            this.dataGridView5.Size = new System.Drawing.Size(863, 478);
            this.dataGridView5.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.HeaderText = "Serial Number";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.ReadOnly = true;
            this.dataGridViewTextBoxColumn29.Width = 75;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.ReadOnly = true;
            this.dataGridViewTextBoxColumn30.Width = 69;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.HeaderText = "Event Type";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.ReadOnly = true;
            this.dataGridViewTextBoxColumn31.Width = 69;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.HeaderText = "Bump?";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.ReadOnly = true;
            this.dataGridViewTextBoxColumn32.Width = 67;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.HeaderText = "H2S Peak (ppm)";
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.ReadOnly = true;
            this.dataGridViewTextBoxColumn33.Width = 119;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.HeaderText = "CO Peak (ppm)";
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.ReadOnly = true;
            this.dataGridViewTextBoxColumn34.Width = 81;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.HeaderText = "O2 Peak (%Vol)";
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.ReadOnly = true;
            this.dataGridViewTextBoxColumn35.Width = 81;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.HeaderText = "LEL Peak (%LEL)";
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.ReadOnly = true;
            this.dataGridViewTextBoxColumn36.Width = 125;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.ReadOnly = true;
            this.dataGridViewTextBoxColumn37.Width = 88;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.HeaderText = "Device Status";
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.ReadOnly = true;
            this.dataGridViewTextBoxColumn38.Width = 75;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.tableLayoutPanel16);
            this.tabPage8.Controls.Add(this.tableLayoutPanel17);
            this.tabPage8.Controls.Add(this.tableLayoutPanel18);
            this.tabPage8.Location = new System.Drawing.Point(4, 23);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(871, 591);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "BW Clip4";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Controls.Add(this.button11, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.button12, 0, 0);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(708, 488);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(160, 105);
            this.tableLayoutPanel16.TabIndex = 0;
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(3, 57);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(154, 45);
            this.button11.TabIndex = 6;
            this.button11.Text = "save to csv";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.SaveToCSV_button_Click);
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(3, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(154, 45);
            this.button12.TabIndex = 1;
            this.button12.Text = "Import";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.BWClip4_Datalog_import_button_Click);
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Controls.Add(this.textBox6, 0, 0);
            this.tableLayoutPanel17.Location = new System.Drawing.Point(1, 488);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 1;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(702, 103);
            this.tableLayoutPanel17.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(3, 3);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(696, 97);
            this.textBox6.TabIndex = 3;
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel18.ColumnCount = 1;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Controls.Add(this.dataGridView6, 0, 0);
            this.tableLayoutPanel18.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 1;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(869, 485);
            this.tableLayoutPanel18.TabIndex = 0;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowDrop = true;
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn39,
            this.dataGridViewTextBoxColumn40,
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44,
            this.dataGridViewTextBoxColumn45,
            this.dataGridViewTextBoxColumn46,
            this.dataGridViewTextBoxColumn47,
            this.dataGridViewTextBoxColumn48,
            this.dataGridViewTextBoxColumn49,
            this.dataGridViewTextBoxColumn50,
            this.dataGridViewTextBoxColumn51,
            this.dataGridViewTextBoxColumn52,
            this.dataGridViewTextBoxColumn53,
            this.dataGridViewTextBoxColumn54,
            this.dataGridViewTextBoxColumn55,
            this.dataGridViewTextBoxColumn56,
            this.dataGridViewTextBoxColumn57,
            this.dataGridViewTextBoxColumn58,
            this.dataGridViewTextBoxColumn59,
            this.dataGridViewTextBoxColumn60,
            this.dataGridViewTextBoxColumn61,
            this.dataGridViewTextBoxColumn62,
            this.dataGridViewTextBoxColumn63,
            this.dataGridViewTextBoxColumn64,
            this.dataGridViewTextBoxColumn65,
            this.dataGridViewTextBoxColumn66,
            this.dataGridViewTextBoxColumn67,
            this.dataGridViewTextBoxColumn68,
            this.dataGridViewTextBoxColumn69,
            this.dataGridViewTextBoxColumn70,
            this.dataGridViewTextBoxColumn71,
            this.dataGridViewTextBoxColumn72,
            this.dataGridViewTextBoxColumn73,
            this.dataGridViewTextBoxColumn74,
            this.dataGridViewTextBoxColumn75});
            this.dataGridView6.Location = new System.Drawing.Point(3, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.RowTemplate.Height = 23;
            this.dataGridView6.Size = new System.Drawing.Size(863, 479);
            this.dataGridView6.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.HeaderText = "Serial Number";
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.ReadOnly = true;
            this.dataGridViewTextBoxColumn39.Width = 75;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.ReadOnly = true;
            this.dataGridViewTextBoxColumn40.Width = 69;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.HeaderText = "Remaining Seconds";
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.ReadOnly = true;
            this.dataGridViewTextBoxColumn41.Width = 138;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.HeaderText = "Device\'s Remaining Lifetime";
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.ReadOnly = true;
            this.dataGridViewTextBoxColumn42.Width = 201;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.HeaderText = "Event Type";
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.ReadOnly = true;
            this.dataGridViewTextBoxColumn43.Width = 69;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.HeaderText = "Channel";
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.ReadOnly = true;
            this.dataGridViewTextBoxColumn44.Width = 81;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.ReadOnly = true;
            this.dataGridViewTextBoxColumn45.Width = 88;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.HeaderText = "H2S Peak (ppm)";
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.ReadOnly = true;
            this.dataGridViewTextBoxColumn46.Width = 119;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.HeaderText = "CO Peak (ppm)";
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.ReadOnly = true;
            this.dataGridViewTextBoxColumn47.Width = 81;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.HeaderText = "O2 Peak (%Vol)";
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.ReadOnly = true;
            this.dataGridViewTextBoxColumn48.Width = 81;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.HeaderText = "LEL Peak (%LEL)";
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.ReadOnly = true;
            this.dataGridViewTextBoxColumn49.Width = 125;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.HeaderText = "H2S TWA";
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.ReadOnly = true;
            this.dataGridViewTextBoxColumn50.Width = 56;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.HeaderText = "H2S STEL";
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.ReadOnly = true;
            this.dataGridViewTextBoxColumn51.Width = 81;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.HeaderText = "CO TWA";
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.ReadOnly = true;
            this.dataGridViewTextBoxColumn52.Width = 69;
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.HeaderText = "CO STEL";
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.ReadOnly = true;
            this.dataGridViewTextBoxColumn53.Width = 75;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.HeaderText = "Start Time in UTC";
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.ReadOnly = true;
            this.dataGridViewTextBoxColumn54.Width = 119;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.HeaderText = "Temperature";
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.ReadOnly = true;
            this.dataGridViewTextBoxColumn55.Width = 109;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.HeaderText = "Battery Voltage in Alarm";
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.ReadOnly = true;
            this.dataGridViewTextBoxColumn56.Width = 150;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.HeaderText = "Firware Version";
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.ReadOnly = true;
            this.dataGridViewTextBoxColumn57.Width = 81;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.HeaderText = "H2S Low Alarm Pt";
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.ReadOnly = true;
            this.dataGridViewTextBoxColumn58.Width = 119;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.HeaderText = "H2S High Alarm Pt";
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.ReadOnly = true;
            this.dataGridViewTextBoxColumn59.Width = 125;
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.HeaderText = "H2S TWA Alarm Pt";
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.ReadOnly = true;
            this.dataGridViewTextBoxColumn60.Width = 119;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.HeaderText = "H2S STEL Alarm Pt";
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.ReadOnly = true;
            this.dataGridViewTextBoxColumn61.Width = 125;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.HeaderText = "CO Low Alarm Pt";
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.ReadOnly = true;
            this.dataGridViewTextBoxColumn62.Width = 113;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.HeaderText = "CO High Alarm Pt";
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.ReadOnly = true;
            this.dataGridViewTextBoxColumn63.Width = 119;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.HeaderText = "CO TWA Alarm Pt";
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            this.dataGridViewTextBoxColumn64.ReadOnly = true;
            this.dataGridViewTextBoxColumn64.Width = 113;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.HeaderText = "CO STEL Alarm Pt";
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            this.dataGridViewTextBoxColumn65.ReadOnly = true;
            this.dataGridViewTextBoxColumn65.Width = 119;
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.HeaderText = "O2 Low Alarm Pt";
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            this.dataGridViewTextBoxColumn66.ReadOnly = true;
            this.dataGridViewTextBoxColumn66.Width = 113;
            // 
            // dataGridViewTextBoxColumn67
            // 
            this.dataGridViewTextBoxColumn67.HeaderText = "O2 High Alarm Pt";
            this.dataGridViewTextBoxColumn67.Name = "dataGridViewTextBoxColumn67";
            this.dataGridViewTextBoxColumn67.ReadOnly = true;
            this.dataGridViewTextBoxColumn67.Width = 119;
            // 
            // dataGridViewTextBoxColumn68
            // 
            this.dataGridViewTextBoxColumn68.HeaderText = "LEL Low Alarm Pt";
            this.dataGridViewTextBoxColumn68.Name = "dataGridViewTextBoxColumn68";
            this.dataGridViewTextBoxColumn68.ReadOnly = true;
            this.dataGridViewTextBoxColumn68.Width = 119;
            // 
            // dataGridViewTextBoxColumn69
            // 
            this.dataGridViewTextBoxColumn69.HeaderText = "LEL High Alarm Pt";
            this.dataGridViewTextBoxColumn69.Name = "dataGridViewTextBoxColumn69";
            this.dataGridViewTextBoxColumn69.ReadOnly = true;
            this.dataGridViewTextBoxColumn69.Width = 125;
            // 
            // dataGridViewTextBoxColumn70
            // 
            this.dataGridViewTextBoxColumn70.HeaderText = "O2 Low Trigger";
            this.dataGridViewTextBoxColumn70.Name = "dataGridViewTextBoxColumn70";
            this.dataGridViewTextBoxColumn70.ReadOnly = true;
            this.dataGridViewTextBoxColumn70.Width = 119;
            // 
            // dataGridViewTextBoxColumn71
            // 
            this.dataGridViewTextBoxColumn71.HeaderText = "O2 High Trigger";
            this.dataGridViewTextBoxColumn71.Name = "dataGridViewTextBoxColumn71";
            this.dataGridViewTextBoxColumn71.ReadOnly = true;
            this.dataGridViewTextBoxColumn71.Width = 81;
            // 
            // dataGridViewTextBoxColumn72
            // 
            this.dataGridViewTextBoxColumn72.HeaderText = "Total Self Tests";
            this.dataGridViewTextBoxColumn72.Name = "dataGridViewTextBoxColumn72";
            this.dataGridViewTextBoxColumn72.ReadOnly = true;
            this.dataGridViewTextBoxColumn72.Width = 132;
            // 
            // dataGridViewTextBoxColumn73
            // 
            this.dataGridViewTextBoxColumn73.HeaderText = "Total event time(seconds)";
            this.dataGridViewTextBoxColumn73.Name = "dataGridViewTextBoxColumn73";
            this.dataGridViewTextBoxColumn73.ReadOnly = true;
            this.dataGridViewTextBoxColumn73.Width = 188;
            // 
            // dataGridViewTextBoxColumn74
            // 
            this.dataGridViewTextBoxColumn74.HeaderText = "Number of event trasfered";
            this.dataGridViewTextBoxColumn74.Name = "dataGridViewTextBoxColumn74";
            this.dataGridViewTextBoxColumn74.ReadOnly = true;
            this.dataGridViewTextBoxColumn74.Width = 188;
            // 
            // dataGridViewTextBoxColumn75
            // 
            this.dataGridViewTextBoxColumn75.HeaderText = "Device Status";
            this.dataGridViewTextBoxColumn75.Name = "dataGridViewTextBoxColumn75";
            this.dataGridViewTextBoxColumn75.ReadOnly = true;
            this.dataGridViewTextBoxColumn75.Width = 75;
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.tableLayoutPanel22);
            this.tabPage10.Controls.Add(this.tableLayoutPanel23);
            this.tabPage10.Controls.Add(this.tableLayoutPanel24);
            this.tabPage10.Location = new System.Drawing.Point(4, 23);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(871, 591);
            this.tabPage10.TabIndex = 4;
            this.tabPage10.Text = "BW Clip";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel22
            // 
            this.tableLayoutPanel22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel22.ColumnCount = 1;
            this.tableLayoutPanel22.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel22.Controls.Add(this.textBox8, 0, 0);
            this.tableLayoutPanel22.Location = new System.Drawing.Point(1, 488);
            this.tableLayoutPanel22.Name = "tableLayoutPanel22";
            this.tableLayoutPanel22.RowCount = 1;
            this.tableLayoutPanel22.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel22.Size = new System.Drawing.Size(702, 103);
            this.tableLayoutPanel22.TabIndex = 4;
            // 
            // textBox8
            // 
            this.textBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox8.Location = new System.Drawing.Point(3, 3);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox8.Size = new System.Drawing.Size(696, 97);
            this.textBox8.TabIndex = 3;
            // 
            // tableLayoutPanel23
            // 
            this.tableLayoutPanel23.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel23.ColumnCount = 1;
            this.tableLayoutPanel23.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.Controls.Add(this.dataGridView8, 0, 0);
            this.tableLayoutPanel23.Location = new System.Drawing.Point(2, 1);
            this.tableLayoutPanel23.Name = "tableLayoutPanel23";
            this.tableLayoutPanel23.RowCount = 1;
            this.tableLayoutPanel23.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel23.Size = new System.Drawing.Size(869, 485);
            this.tableLayoutPanel23.TabIndex = 2;
            // 
            // dataGridView8
            // 
            this.dataGridView8.AllowDrop = true;
            this.dataGridView8.AllowUserToAddRows = false;
            this.dataGridView8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView8.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView8.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn113,
            this.dataGridViewTextBoxColumn114,
            this.dataGridViewTextBoxColumn115,
            this.dataGridViewTextBoxColumn116,
            this.dataGridViewTextBoxColumn117,
            this.dataGridViewTextBoxColumn118,
            this.dataGridViewTextBoxColumn119,
            this.dataGridViewTextBoxColumn120,
            this.dataGridViewTextBoxColumn121,
            this.dataGridViewTextBoxColumn122,
            this.dataGridViewTextBoxColumn123,
            this.dataGridViewTextBoxColumn124,
            this.dataGridViewTextBoxColumn125,
            this.dataGridViewTextBoxColumn126,
            this.dataGridViewTextBoxColumn127,
            this.dataGridViewTextBoxColumn128,
            this.dataGridViewTextBoxColumn129,
            this.dataGridViewTextBoxColumn130,
            this.dataGridViewTextBoxColumn131,
            this.dataGridViewTextBoxColumn132,
            this.dataGridViewTextBoxColumn133,
            this.dataGridViewTextBoxColumn134,
            this.dataGridViewTextBoxColumn135,
            this.dataGridViewTextBoxColumn136,
            this.dataGridViewTextBoxColumn137,
            this.dataGridViewTextBoxColumn138,
            this.dataGridViewTextBoxColumn139,
            this.dataGridViewTextBoxColumn140,
            this.dataGridViewTextBoxColumn141,
            this.dataGridViewTextBoxColumn142,
            this.dataGridViewTextBoxColumn143,
            this.dataGridViewTextBoxColumn144,
            this.dataGridViewTextBoxColumn145,
            this.dataGridViewTextBoxColumn146,
            this.dataGridViewTextBoxColumn147,
            this.dataGridViewTextBoxColumn148,
            this.dataGridViewTextBoxColumn149});
            this.dataGridView8.Location = new System.Drawing.Point(3, 3);
            this.dataGridView8.Name = "dataGridView8";
            this.dataGridView8.ReadOnly = true;
            this.dataGridView8.RowTemplate.Height = 23;
            this.dataGridView8.Size = new System.Drawing.Size(863, 479);
            this.dataGridView8.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn113
            // 
            this.dataGridViewTextBoxColumn113.HeaderText = "Serial Number";
            this.dataGridViewTextBoxColumn113.Name = "dataGridViewTextBoxColumn113";
            this.dataGridViewTextBoxColumn113.ReadOnly = true;
            this.dataGridViewTextBoxColumn113.Width = 75;
            // 
            // dataGridViewTextBoxColumn114
            // 
            this.dataGridViewTextBoxColumn114.HeaderText = "Start Time";
            this.dataGridViewTextBoxColumn114.Name = "dataGridViewTextBoxColumn114";
            this.dataGridViewTextBoxColumn114.ReadOnly = true;
            this.dataGridViewTextBoxColumn114.Width = 69;
            // 
            // dataGridViewTextBoxColumn115
            // 
            this.dataGridViewTextBoxColumn115.HeaderText = "Remaining Seconds";
            this.dataGridViewTextBoxColumn115.Name = "dataGridViewTextBoxColumn115";
            this.dataGridViewTextBoxColumn115.ReadOnly = true;
            this.dataGridViewTextBoxColumn115.Width = 138;
            // 
            // dataGridViewTextBoxColumn116
            // 
            this.dataGridViewTextBoxColumn116.HeaderText = "Device\'s Remaining Lifetime";
            this.dataGridViewTextBoxColumn116.Name = "dataGridViewTextBoxColumn116";
            this.dataGridViewTextBoxColumn116.ReadOnly = true;
            this.dataGridViewTextBoxColumn116.Width = 201;
            // 
            // dataGridViewTextBoxColumn117
            // 
            this.dataGridViewTextBoxColumn117.HeaderText = "Event Type";
            this.dataGridViewTextBoxColumn117.Name = "dataGridViewTextBoxColumn117";
            this.dataGridViewTextBoxColumn117.ReadOnly = true;
            this.dataGridViewTextBoxColumn117.Width = 69;
            // 
            // dataGridViewTextBoxColumn118
            // 
            this.dataGridViewTextBoxColumn118.HeaderText = "Channel";
            this.dataGridViewTextBoxColumn118.Name = "dataGridViewTextBoxColumn118";
            this.dataGridViewTextBoxColumn118.ReadOnly = true;
            this.dataGridViewTextBoxColumn118.Width = 81;
            // 
            // dataGridViewTextBoxColumn119
            // 
            this.dataGridViewTextBoxColumn119.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn119.Name = "dataGridViewTextBoxColumn119";
            this.dataGridViewTextBoxColumn119.ReadOnly = true;
            this.dataGridViewTextBoxColumn119.Width = 88;
            // 
            // dataGridViewTextBoxColumn120
            // 
            this.dataGridViewTextBoxColumn120.HeaderText = "H2S Peak (ppm)";
            this.dataGridViewTextBoxColumn120.Name = "dataGridViewTextBoxColumn120";
            this.dataGridViewTextBoxColumn120.ReadOnly = true;
            this.dataGridViewTextBoxColumn120.Width = 119;
            // 
            // dataGridViewTextBoxColumn121
            // 
            this.dataGridViewTextBoxColumn121.HeaderText = "CO Peak (ppm)";
            this.dataGridViewTextBoxColumn121.Name = "dataGridViewTextBoxColumn121";
            this.dataGridViewTextBoxColumn121.ReadOnly = true;
            this.dataGridViewTextBoxColumn121.Width = 81;
            // 
            // dataGridViewTextBoxColumn122
            // 
            this.dataGridViewTextBoxColumn122.HeaderText = "O2 Peak (%Vol)";
            this.dataGridViewTextBoxColumn122.Name = "dataGridViewTextBoxColumn122";
            this.dataGridViewTextBoxColumn122.ReadOnly = true;
            this.dataGridViewTextBoxColumn122.Width = 81;
            // 
            // dataGridViewTextBoxColumn123
            // 
            this.dataGridViewTextBoxColumn123.HeaderText = "LEL Peak (%LEL)";
            this.dataGridViewTextBoxColumn123.Name = "dataGridViewTextBoxColumn123";
            this.dataGridViewTextBoxColumn123.ReadOnly = true;
            this.dataGridViewTextBoxColumn123.Width = 125;
            // 
            // dataGridViewTextBoxColumn124
            // 
            this.dataGridViewTextBoxColumn124.HeaderText = "H2S TWA";
            this.dataGridViewTextBoxColumn124.Name = "dataGridViewTextBoxColumn124";
            this.dataGridViewTextBoxColumn124.ReadOnly = true;
            this.dataGridViewTextBoxColumn124.Width = 56;
            // 
            // dataGridViewTextBoxColumn125
            // 
            this.dataGridViewTextBoxColumn125.HeaderText = "H2S STEL";
            this.dataGridViewTextBoxColumn125.Name = "dataGridViewTextBoxColumn125";
            this.dataGridViewTextBoxColumn125.ReadOnly = true;
            this.dataGridViewTextBoxColumn125.Width = 81;
            // 
            // dataGridViewTextBoxColumn126
            // 
            this.dataGridViewTextBoxColumn126.HeaderText = "CO TWA";
            this.dataGridViewTextBoxColumn126.Name = "dataGridViewTextBoxColumn126";
            this.dataGridViewTextBoxColumn126.ReadOnly = true;
            this.dataGridViewTextBoxColumn126.Width = 69;
            // 
            // dataGridViewTextBoxColumn127
            // 
            this.dataGridViewTextBoxColumn127.HeaderText = "CO STEL";
            this.dataGridViewTextBoxColumn127.Name = "dataGridViewTextBoxColumn127";
            this.dataGridViewTextBoxColumn127.ReadOnly = true;
            this.dataGridViewTextBoxColumn127.Width = 75;
            // 
            // dataGridViewTextBoxColumn128
            // 
            this.dataGridViewTextBoxColumn128.HeaderText = "Start Time in UTC";
            this.dataGridViewTextBoxColumn128.Name = "dataGridViewTextBoxColumn128";
            this.dataGridViewTextBoxColumn128.ReadOnly = true;
            this.dataGridViewTextBoxColumn128.Width = 119;
            // 
            // dataGridViewTextBoxColumn129
            // 
            this.dataGridViewTextBoxColumn129.HeaderText = "Temperature";
            this.dataGridViewTextBoxColumn129.Name = "dataGridViewTextBoxColumn129";
            this.dataGridViewTextBoxColumn129.ReadOnly = true;
            this.dataGridViewTextBoxColumn129.Width = 109;
            // 
            // dataGridViewTextBoxColumn130
            // 
            this.dataGridViewTextBoxColumn130.HeaderText = "Battery Voltage in Alarm";
            this.dataGridViewTextBoxColumn130.Name = "dataGridViewTextBoxColumn130";
            this.dataGridViewTextBoxColumn130.ReadOnly = true;
            this.dataGridViewTextBoxColumn130.Width = 150;
            // 
            // dataGridViewTextBoxColumn131
            // 
            this.dataGridViewTextBoxColumn131.HeaderText = "Firware Version";
            this.dataGridViewTextBoxColumn131.Name = "dataGridViewTextBoxColumn131";
            this.dataGridViewTextBoxColumn131.ReadOnly = true;
            this.dataGridViewTextBoxColumn131.Width = 81;
            // 
            // dataGridViewTextBoxColumn132
            // 
            this.dataGridViewTextBoxColumn132.HeaderText = "H2S Low Alarm Pt";
            this.dataGridViewTextBoxColumn132.Name = "dataGridViewTextBoxColumn132";
            this.dataGridViewTextBoxColumn132.ReadOnly = true;
            this.dataGridViewTextBoxColumn132.Width = 119;
            // 
            // dataGridViewTextBoxColumn133
            // 
            this.dataGridViewTextBoxColumn133.HeaderText = "H2S High Alarm Pt";
            this.dataGridViewTextBoxColumn133.Name = "dataGridViewTextBoxColumn133";
            this.dataGridViewTextBoxColumn133.ReadOnly = true;
            this.dataGridViewTextBoxColumn133.Width = 125;
            // 
            // dataGridViewTextBoxColumn134
            // 
            this.dataGridViewTextBoxColumn134.HeaderText = "H2S TWA Alarm Pt";
            this.dataGridViewTextBoxColumn134.Name = "dataGridViewTextBoxColumn134";
            this.dataGridViewTextBoxColumn134.ReadOnly = true;
            this.dataGridViewTextBoxColumn134.Width = 119;
            // 
            // dataGridViewTextBoxColumn135
            // 
            this.dataGridViewTextBoxColumn135.HeaderText = "H2S STEL Alarm Pt";
            this.dataGridViewTextBoxColumn135.Name = "dataGridViewTextBoxColumn135";
            this.dataGridViewTextBoxColumn135.ReadOnly = true;
            this.dataGridViewTextBoxColumn135.Width = 125;
            // 
            // dataGridViewTextBoxColumn136
            // 
            this.dataGridViewTextBoxColumn136.HeaderText = "CO Low Alarm Pt";
            this.dataGridViewTextBoxColumn136.Name = "dataGridViewTextBoxColumn136";
            this.dataGridViewTextBoxColumn136.ReadOnly = true;
            this.dataGridViewTextBoxColumn136.Width = 113;
            // 
            // dataGridViewTextBoxColumn137
            // 
            this.dataGridViewTextBoxColumn137.HeaderText = "CO High Alarm Pt";
            this.dataGridViewTextBoxColumn137.Name = "dataGridViewTextBoxColumn137";
            this.dataGridViewTextBoxColumn137.ReadOnly = true;
            this.dataGridViewTextBoxColumn137.Width = 119;
            // 
            // dataGridViewTextBoxColumn138
            // 
            this.dataGridViewTextBoxColumn138.HeaderText = "CO TWA Alarm Pt";
            this.dataGridViewTextBoxColumn138.Name = "dataGridViewTextBoxColumn138";
            this.dataGridViewTextBoxColumn138.ReadOnly = true;
            this.dataGridViewTextBoxColumn138.Width = 113;
            // 
            // dataGridViewTextBoxColumn139
            // 
            this.dataGridViewTextBoxColumn139.HeaderText = "CO STEL Alarm Pt";
            this.dataGridViewTextBoxColumn139.Name = "dataGridViewTextBoxColumn139";
            this.dataGridViewTextBoxColumn139.ReadOnly = true;
            this.dataGridViewTextBoxColumn139.Width = 119;
            // 
            // dataGridViewTextBoxColumn140
            // 
            this.dataGridViewTextBoxColumn140.HeaderText = "O2 Low Alarm Pt";
            this.dataGridViewTextBoxColumn140.Name = "dataGridViewTextBoxColumn140";
            this.dataGridViewTextBoxColumn140.ReadOnly = true;
            this.dataGridViewTextBoxColumn140.Width = 113;
            // 
            // dataGridViewTextBoxColumn141
            // 
            this.dataGridViewTextBoxColumn141.HeaderText = "O2 High Alarm Pt";
            this.dataGridViewTextBoxColumn141.Name = "dataGridViewTextBoxColumn141";
            this.dataGridViewTextBoxColumn141.ReadOnly = true;
            this.dataGridViewTextBoxColumn141.Width = 119;
            // 
            // dataGridViewTextBoxColumn142
            // 
            this.dataGridViewTextBoxColumn142.HeaderText = "LEL Low Alarm Pt";
            this.dataGridViewTextBoxColumn142.Name = "dataGridViewTextBoxColumn142";
            this.dataGridViewTextBoxColumn142.ReadOnly = true;
            this.dataGridViewTextBoxColumn142.Width = 119;
            // 
            // dataGridViewTextBoxColumn143
            // 
            this.dataGridViewTextBoxColumn143.HeaderText = "LEL High Alarm Pt";
            this.dataGridViewTextBoxColumn143.Name = "dataGridViewTextBoxColumn143";
            this.dataGridViewTextBoxColumn143.ReadOnly = true;
            this.dataGridViewTextBoxColumn143.Width = 125;
            // 
            // dataGridViewTextBoxColumn144
            // 
            this.dataGridViewTextBoxColumn144.HeaderText = "O2 Low Trigger";
            this.dataGridViewTextBoxColumn144.Name = "dataGridViewTextBoxColumn144";
            this.dataGridViewTextBoxColumn144.ReadOnly = true;
            this.dataGridViewTextBoxColumn144.Width = 119;
            // 
            // dataGridViewTextBoxColumn145
            // 
            this.dataGridViewTextBoxColumn145.HeaderText = "O2 High Trigger";
            this.dataGridViewTextBoxColumn145.Name = "dataGridViewTextBoxColumn145";
            this.dataGridViewTextBoxColumn145.ReadOnly = true;
            this.dataGridViewTextBoxColumn145.Width = 81;
            // 
            // dataGridViewTextBoxColumn146
            // 
            this.dataGridViewTextBoxColumn146.HeaderText = "Total Self Tests";
            this.dataGridViewTextBoxColumn146.Name = "dataGridViewTextBoxColumn146";
            this.dataGridViewTextBoxColumn146.ReadOnly = true;
            this.dataGridViewTextBoxColumn146.Width = 132;
            // 
            // dataGridViewTextBoxColumn147
            // 
            this.dataGridViewTextBoxColumn147.HeaderText = "Total event time(seconds)";
            this.dataGridViewTextBoxColumn147.Name = "dataGridViewTextBoxColumn147";
            this.dataGridViewTextBoxColumn147.ReadOnly = true;
            this.dataGridViewTextBoxColumn147.Width = 188;
            // 
            // dataGridViewTextBoxColumn148
            // 
            this.dataGridViewTextBoxColumn148.HeaderText = "Number of event trasfered";
            this.dataGridViewTextBoxColumn148.Name = "dataGridViewTextBoxColumn148";
            this.dataGridViewTextBoxColumn148.ReadOnly = true;
            this.dataGridViewTextBoxColumn148.Width = 188;
            // 
            // dataGridViewTextBoxColumn149
            // 
            this.dataGridViewTextBoxColumn149.HeaderText = "Device Status";
            this.dataGridViewTextBoxColumn149.Name = "dataGridViewTextBoxColumn149";
            this.dataGridViewTextBoxColumn149.ReadOnly = true;
            this.dataGridViewTextBoxColumn149.Width = 75;
            // 
            // tableLayoutPanel24
            // 
            this.tableLayoutPanel24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel24.ColumnCount = 1;
            this.tableLayoutPanel24.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel24.Controls.Add(this.button15, 0, 1);
            this.tableLayoutPanel24.Controls.Add(this.button16, 0, 0);
            this.tableLayoutPanel24.Location = new System.Drawing.Point(708, 488);
            this.tableLayoutPanel24.Name = "tableLayoutPanel24";
            this.tableLayoutPanel24.RowCount = 2;
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel24.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel24.Size = new System.Drawing.Size(160, 105);
            this.tableLayoutPanel24.TabIndex = 3;
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(3, 57);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(154, 45);
            this.button15.TabIndex = 6;
            this.button15.Text = "save to csv";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.SaveToCSV_button_Click);
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.Location = new System.Drawing.Point(3, 4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(154, 45);
            this.button16.TabIndex = 1;
            this.button16.Text = "Import";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.BWClip_Datalog_import_button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.LightPink;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(781, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 22);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Skip Zero";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(898, 682);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tabControl2);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(914, 720);
            this.Name = "Form1";
            this.Text = "Log Parser";
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.tableLayoutPanel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tableLayoutPanel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.tableLayoutPanel22.ResumeLayout(false);
            this.tableLayoutPanel22.PerformLayout();
            this.tableLayoutPanel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView8)).EndInit();
            this.tableLayoutPanel24.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn H2S_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn H2S_Peak;
        private System.Windows.Forms.DataGridViewTextBoxColumn CO_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn CO_Peak;
        private System.Windows.Forms.DataGridViewTextBoxColumn O2_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn O2_Peak;
        private System.Windows.Forms.DataGridViewTextBoxColumn LEL_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LEL_Peak;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn microclip_duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn microclip_status;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemainingSeconds;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceRemainingLifetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Eventype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Channel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn H2STWA;
        private System.Windows.Forms.DataGridViewTextBoxColumn H2SSTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn COTWA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTimeinUTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn BatteryVoltageinAlarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirwareVersion;
        private System.Windows.Forms.DataGridViewTextBoxColumn H2SLowAlarmPt;
        private System.Windows.Forms.DataGridViewTextBoxColumn H2SHighAlarmPt;
        private System.Windows.Forms.DataGridViewTextBoxColumn H2STWAAlarmPt;
        private System.Windows.Forms.DataGridViewTextBoxColumn H2SSTELAlarmPt;
        private System.Windows.Forms.DataGridViewTextBoxColumn COLowAlarmPt;
        private System.Windows.Forms.DataGridViewTextBoxColumn COHighAlarmPt;
        private System.Windows.Forms.DataGridViewTextBoxColumn COTWAAlarmPt;
        private System.Windows.Forms.DataGridViewTextBoxColumn COSTELAlarmPt;
        private System.Windows.Forms.DataGridViewTextBoxColumn O2LowAlarmPt;
        private System.Windows.Forms.DataGridViewTextBoxColumn O2HighAlarmPt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LELLowAlarmPt;
        private System.Windows.Forms.DataGridViewTextBoxColumn LELHighAlarmPt;
        private System.Windows.Forms.DataGridViewTextBoxColumn O2LowTrigger;
        private System.Windows.Forms.DataGridViewTextBoxColumn O2HighTrigger;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSelfTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn Totaleventtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numberofeventtrasfered;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn76;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn77;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn81;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn82;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn83;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn84;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn85;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn86;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn87;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn88;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn89;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn90;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn91;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn92;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn93;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn94;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn95;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn96;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn97;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn98;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn99;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn100;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn101;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn102;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn103;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn104;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn105;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn106;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn107;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn108;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn109;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn110;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn111;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn112;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel22;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel23;
        private System.Windows.Forms.DataGridView dataGridView8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn113;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn114;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn115;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn116;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn117;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn118;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn119;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn120;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn121;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn122;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn123;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn124;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn125;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn126;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn127;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn128;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn129;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn130;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn131;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn132;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn133;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn134;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn135;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn136;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn137;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn138;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn139;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn140;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn141;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn142;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn143;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn144;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn145;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn146;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn147;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn148;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn149;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel24;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
    }
}

