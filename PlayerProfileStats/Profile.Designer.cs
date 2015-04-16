namespace PlayerProfileStats
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.button1 = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPlayerLoad = new System.Windows.Forms.TabPage();
            this.playerSetNow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.player1Month = new System.Windows.Forms.RadioButton();
            this.player7Days = new System.Windows.Forms.RadioButton();
            this.player12Months = new System.Windows.Forms.RadioButton();
            this.player24Hours = new System.Windows.Forms.RadioButton();
            this.playerEndDate = new System.Windows.Forms.Label();
            this.playerStartDate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.playerStart = new System.Windows.Forms.DateTimePicker();
            this.loadPlayerLoad = new System.Windows.Forms.Button();
            this.chartPlayerLoad = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabTop10 = new System.Windows.Forms.TabPage();
            this.Top10AvgSetNow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Top10Avg1Month = new System.Windows.Forms.RadioButton();
            this.Top10Avg7Days = new System.Windows.Forms.RadioButton();
            this.Top10Avg12Months = new System.Windows.Forms.RadioButton();
            this.Top10Avg24Hours = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.top10AvgStart = new System.Windows.Forms.DateTimePicker();
            this.loadPlayerAverageLoad = new System.Windows.Forms.Button();
            this.chartTop10PlayerAverage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPlayerCount = new System.Windows.Forms.TabPage();
            this.Top10CountSetNow = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.top10Count1Month = new System.Windows.Forms.RadioButton();
            this.top10Count7Days = new System.Windows.Forms.RadioButton();
            this.top10Count12Months = new System.Windows.Forms.RadioButton();
            this.top10Count24Hours = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.top10CountStart = new System.Windows.Forms.DateTimePicker();
            this.loadPlayerCountLoad = new System.Windows.Forms.Button();
            this.chartTop10PlayerCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serverAddress = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPlayerLoad.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlayerLoad)).BeginInit();
            this.tabTop10.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop10PlayerAverage)).BeginInit();
            this.tabPlayerCount.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop10PlayerCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(833, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Settings";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblVersion
            // 
            this.lblVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVersion.Location = new System.Drawing.Point(679, 573);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(229, 15);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPlayerLoad);
            this.tabControl1.Controls.Add(this.tabTop10);
            this.tabControl1.Controls.Add(this.tabPlayerCount);
            this.tabControl1.Location = new System.Drawing.Point(6, 76);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 494);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPlayerLoad
            // 
            this.tabPlayerLoad.Controls.Add(this.playerSetNow);
            this.tabPlayerLoad.Controls.Add(this.groupBox1);
            this.tabPlayerLoad.Controls.Add(this.playerEndDate);
            this.tabPlayerLoad.Controls.Add(this.playerStartDate);
            this.tabPlayerLoad.Controls.Add(this.dateTimePicker2);
            this.tabPlayerLoad.Controls.Add(this.playerStart);
            this.tabPlayerLoad.Controls.Add(this.loadPlayerLoad);
            this.tabPlayerLoad.Controls.Add(this.chartPlayerLoad);
            this.tabPlayerLoad.Location = new System.Drawing.Point(4, 22);
            this.tabPlayerLoad.Name = "tabPlayerLoad";
            this.tabPlayerLoad.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayerLoad.Size = new System.Drawing.Size(808, 468);
            this.tabPlayerLoad.TabIndex = 1;
            this.tabPlayerLoad.Text = "Player Load";
            this.tabPlayerLoad.UseVisualStyleBackColor = true;
            // 
            // playerSetNow
            // 
            this.playerSetNow.Location = new System.Drawing.Point(276, 21);
            this.playerSetNow.Name = "playerSetNow";
            this.playerSetNow.Size = new System.Drawing.Size(55, 23);
            this.playerSetNow.TabIndex = 14;
            this.playerSetNow.Text = "<==Now";
            this.playerSetNow.UseVisualStyleBackColor = true;
            this.playerSetNow.Click += new System.EventHandler(this.playerSetNow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.player1Month);
            this.groupBox1.Controls.Add(this.player7Days);
            this.groupBox1.Controls.Add(this.player12Months);
            this.groupBox1.Controls.Add(this.player24Hours);
            this.groupBox1.Location = new System.Drawing.Point(369, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 106);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection Range";
            // 
            // player1Month
            // 
            this.player1Month.AutoSize = true;
            this.player1Month.Location = new System.Drawing.Point(21, 60);
            this.player1Month.Name = "player1Month";
            this.player1Month.Size = new System.Drawing.Size(64, 17);
            this.player1Month.TabIndex = 13;
            this.player1Month.TabStop = true;
            this.player1Month.Text = "1 Month";
            this.player1Month.UseVisualStyleBackColor = true;
            // 
            // player7Days
            // 
            this.player7Days.AutoSize = true;
            this.player7Days.Location = new System.Drawing.Point(21, 40);
            this.player7Days.Name = "player7Days";
            this.player7Days.Size = new System.Drawing.Size(58, 17);
            this.player7Days.TabIndex = 11;
            this.player7Days.TabStop = true;
            this.player7Days.Text = "7 Days";
            this.player7Days.UseVisualStyleBackColor = true;
            // 
            // player12Months
            // 
            this.player12Months.AutoSize = true;
            this.player12Months.Location = new System.Drawing.Point(21, 80);
            this.player12Months.Name = "player12Months";
            this.player12Months.Size = new System.Drawing.Size(75, 17);
            this.player12Months.TabIndex = 12;
            this.player12Months.TabStop = true;
            this.player12Months.Text = "12 Months";
            this.player12Months.UseVisualStyleBackColor = true;
            // 
            // player24Hours
            // 
            this.player24Hours.AutoSize = true;
            this.player24Hours.Location = new System.Drawing.Point(21, 20);
            this.player24Hours.Name = "player24Hours";
            this.player24Hours.Size = new System.Drawing.Size(68, 17);
            this.player24Hours.TabIndex = 10;
            this.player24Hours.TabStop = true;
            this.player24Hours.Text = "24 Hours";
            this.player24Hours.UseVisualStyleBackColor = true;
            // 
            // playerEndDate
            // 
            this.playerEndDate.AutoSize = true;
            this.playerEndDate.Location = new System.Drawing.Point(106, 59);
            this.playerEndDate.Name = "playerEndDate";
            this.playerEndDate.Size = new System.Drawing.Size(29, 13);
            this.playerEndDate.TabIndex = 9;
            this.playerEndDate.Text = "End:";
            this.playerEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.playerEndDate.Visible = false;
            // 
            // playerStartDate
            // 
            this.playerStartDate.AutoSize = true;
            this.playerStartDate.Location = new System.Drawing.Point(106, 26);
            this.playerStartDate.Name = "playerStartDate";
            this.playerStartDate.Size = new System.Drawing.Size(32, 13);
            this.playerStartDate.TabIndex = 8;
            this.playerStartDate.Text = "Start:";
            this.playerStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/dd/yyyy HH:mm";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(144, 55);
            this.dateTimePicker2.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker2.TabIndex = 7;
            this.dateTimePicker2.Visible = false;
            // 
            // playerStart
            // 
            this.playerStart.CustomFormat = "MM/dd/yyyy HH:mm";
            this.playerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.playerStart.Location = new System.Drawing.Point(144, 22);
            this.playerStart.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.playerStart.Name = "playerStart";
            this.playerStart.Size = new System.Drawing.Size(126, 20);
            this.playerStart.TabIndex = 6;
            // 
            // loadPlayerLoad
            // 
            this.loadPlayerLoad.Location = new System.Drawing.Point(618, 26);
            this.loadPlayerLoad.Name = "loadPlayerLoad";
            this.loadPlayerLoad.Size = new System.Drawing.Size(75, 23);
            this.loadPlayerLoad.TabIndex = 5;
            this.loadPlayerLoad.Text = "Submit";
            this.loadPlayerLoad.UseVisualStyleBackColor = true;
            this.loadPlayerLoad.Click += new System.EventHandler(this.loadPlayerLoad_Click);
            // 
            // chartPlayerLoad
            // 
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartPlayerLoad";
            this.chartPlayerLoad.ChartAreas.Add(chartArea1);
            this.chartPlayerLoad.Location = new System.Drawing.Point(10, 100);
            this.chartPlayerLoad.Name = "chartPlayerLoad";
            this.chartPlayerLoad.Size = new System.Drawing.Size(790, 350);
            this.chartPlayerLoad.TabIndex = 0;
            this.chartPlayerLoad.Text = "Player Load";
            // 
            // tabTop10
            // 
            this.tabTop10.Controls.Add(this.Top10AvgSetNow);
            this.tabTop10.Controls.Add(this.groupBox2);
            this.tabTop10.Controls.Add(this.label1);
            this.tabTop10.Controls.Add(this.label2);
            this.tabTop10.Controls.Add(this.dateTimePicker1);
            this.tabTop10.Controls.Add(this.top10AvgStart);
            this.tabTop10.Controls.Add(this.loadPlayerAverageLoad);
            this.tabTop10.Controls.Add(this.chartTop10PlayerAverage);
            this.tabTop10.Location = new System.Drawing.Point(4, 22);
            this.tabTop10.Name = "tabTop10";
            this.tabTop10.Padding = new System.Windows.Forms.Padding(3);
            this.tabTop10.Size = new System.Drawing.Size(808, 468);
            this.tabTop10.TabIndex = 0;
            this.tabTop10.Text = "Top 10 Players";
            this.tabTop10.UseVisualStyleBackColor = true;
            // 
            // Top10AvgSetNow
            // 
            this.Top10AvgSetNow.Location = new System.Drawing.Point(276, 21);
            this.Top10AvgSetNow.Name = "Top10AvgSetNow";
            this.Top10AvgSetNow.Size = new System.Drawing.Size(55, 23);
            this.Top10AvgSetNow.TabIndex = 21;
            this.Top10AvgSetNow.Text = "<==Now";
            this.Top10AvgSetNow.UseVisualStyleBackColor = true;
            this.Top10AvgSetNow.Click += new System.EventHandler(this.playerAvgSetNow_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Top10Avg1Month);
            this.groupBox2.Controls.Add(this.Top10Avg7Days);
            this.groupBox2.Controls.Add(this.Top10Avg12Months);
            this.groupBox2.Controls.Add(this.Top10Avg24Hours);
            this.groupBox2.Location = new System.Drawing.Point(369, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 105);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection Range";
            // 
            // Top10Avg1Month
            // 
            this.Top10Avg1Month.AutoSize = true;
            this.Top10Avg1Month.Location = new System.Drawing.Point(21, 60);
            this.Top10Avg1Month.Name = "Top10Avg1Month";
            this.Top10Avg1Month.Size = new System.Drawing.Size(64, 17);
            this.Top10Avg1Month.TabIndex = 13;
            this.Top10Avg1Month.TabStop = true;
            this.Top10Avg1Month.Text = "1 Month";
            this.Top10Avg1Month.UseVisualStyleBackColor = true;
            // 
            // Top10Avg7Days
            // 
            this.Top10Avg7Days.AutoSize = true;
            this.Top10Avg7Days.Location = new System.Drawing.Point(21, 40);
            this.Top10Avg7Days.Name = "Top10Avg7Days";
            this.Top10Avg7Days.Size = new System.Drawing.Size(58, 17);
            this.Top10Avg7Days.TabIndex = 11;
            this.Top10Avg7Days.TabStop = true;
            this.Top10Avg7Days.Text = "7 Days";
            this.Top10Avg7Days.UseVisualStyleBackColor = true;
            // 
            // Top10Avg12Months
            // 
            this.Top10Avg12Months.AutoSize = true;
            this.Top10Avg12Months.Location = new System.Drawing.Point(21, 80);
            this.Top10Avg12Months.Name = "Top10Avg12Months";
            this.Top10Avg12Months.Size = new System.Drawing.Size(75, 17);
            this.Top10Avg12Months.TabIndex = 12;
            this.Top10Avg12Months.TabStop = true;
            this.Top10Avg12Months.Text = "12 Months";
            this.Top10Avg12Months.UseVisualStyleBackColor = true;
            // 
            // Top10Avg24Hours
            // 
            this.Top10Avg24Hours.AutoSize = true;
            this.Top10Avg24Hours.Location = new System.Drawing.Point(21, 20);
            this.Top10Avg24Hours.Name = "Top10Avg24Hours";
            this.Top10Avg24Hours.Size = new System.Drawing.Size(68, 17);
            this.Top10Avg24Hours.TabIndex = 10;
            this.Top10Avg24Hours.TabStop = true;
            this.Top10Avg24Hours.Text = "24 Hours";
            this.Top10Avg24Hours.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "End:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Start:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/dd/yyyy HH:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 55);
            this.dateTimePicker1.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(136, 20);
            this.dateTimePicker1.TabIndex = 17;
            this.dateTimePicker1.Visible = false;
            // 
            // top10AvgStart
            // 
            this.top10AvgStart.CustomFormat = "MM/dd/yyyy HH:mm";
            this.top10AvgStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.top10AvgStart.Location = new System.Drawing.Point(144, 22);
            this.top10AvgStart.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.top10AvgStart.Name = "top10AvgStart";
            this.top10AvgStart.Size = new System.Drawing.Size(126, 20);
            this.top10AvgStart.TabIndex = 16;
            // 
            // loadPlayerAverageLoad
            // 
            this.loadPlayerAverageLoad.Location = new System.Drawing.Point(618, 26);
            this.loadPlayerAverageLoad.Name = "loadPlayerAverageLoad";
            this.loadPlayerAverageLoad.Size = new System.Drawing.Size(75, 23);
            this.loadPlayerAverageLoad.TabIndex = 15;
            this.loadPlayerAverageLoad.Text = "Submit";
            this.loadPlayerAverageLoad.UseVisualStyleBackColor = true;
            this.loadPlayerAverageLoad.Click += new System.EventHandler(this.loadPlayerAverageLoad_Click);
            // 
            // chartTop10PlayerAverage
            // 
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartTop10PlayerAverage";
            this.chartTop10PlayerAverage.ChartAreas.Add(chartArea2);
            this.chartTop10PlayerAverage.Location = new System.Drawing.Point(10, 100);
            this.chartTop10PlayerAverage.Name = "chartTop10PlayerAverage";
            this.chartTop10PlayerAverage.Size = new System.Drawing.Size(790, 350);
            this.chartTop10PlayerAverage.TabIndex = 0;
            this.chartTop10PlayerAverage.Text = "Top Ten";
            // 
            // tabPlayerCount
            // 
            this.tabPlayerCount.Controls.Add(this.Top10CountSetNow);
            this.tabPlayerCount.Controls.Add(this.groupBox3);
            this.tabPlayerCount.Controls.Add(this.label4);
            this.tabPlayerCount.Controls.Add(this.top10CountStart);
            this.tabPlayerCount.Controls.Add(this.loadPlayerCountLoad);
            this.tabPlayerCount.Controls.Add(this.chartTop10PlayerCount);
            this.tabPlayerCount.Location = new System.Drawing.Point(4, 22);
            this.tabPlayerCount.Name = "tabPlayerCount";
            this.tabPlayerCount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlayerCount.Size = new System.Drawing.Size(808, 468);
            this.tabPlayerCount.TabIndex = 2;
            this.tabPlayerCount.Text = "Top 10 Logins";
            this.tabPlayerCount.UseVisualStyleBackColor = true;
            // 
            // Top10CountSetNow
            // 
            this.Top10CountSetNow.Location = new System.Drawing.Point(276, 21);
            this.Top10CountSetNow.Name = "Top10CountSetNow";
            this.Top10CountSetNow.Size = new System.Drawing.Size(55, 23);
            this.Top10CountSetNow.TabIndex = 22;
            this.Top10CountSetNow.Text = "<==Now";
            this.Top10CountSetNow.UseVisualStyleBackColor = true;
            this.Top10CountSetNow.Click += new System.EventHandler(this.Top10CountSetNow_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.top10Count1Month);
            this.groupBox3.Controls.Add(this.top10Count7Days);
            this.groupBox3.Controls.Add(this.top10Count12Months);
            this.groupBox3.Controls.Add(this.top10Count24Hours);
            this.groupBox3.Location = new System.Drawing.Point(369, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 106);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Selection Range";
            // 
            // top10Count1Month
            // 
            this.top10Count1Month.AutoSize = true;
            this.top10Count1Month.Location = new System.Drawing.Point(21, 60);
            this.top10Count1Month.Name = "top10Count1Month";
            this.top10Count1Month.Size = new System.Drawing.Size(64, 17);
            this.top10Count1Month.TabIndex = 13;
            this.top10Count1Month.TabStop = true;
            this.top10Count1Month.Text = "1 Month";
            this.top10Count1Month.UseVisualStyleBackColor = true;
            // 
            // top10Count7Days
            // 
            this.top10Count7Days.AutoSize = true;
            this.top10Count7Days.Location = new System.Drawing.Point(21, 40);
            this.top10Count7Days.Name = "top10Count7Days";
            this.top10Count7Days.Size = new System.Drawing.Size(58, 17);
            this.top10Count7Days.TabIndex = 11;
            this.top10Count7Days.TabStop = true;
            this.top10Count7Days.Text = "7 Days";
            this.top10Count7Days.UseVisualStyleBackColor = true;
            // 
            // top10Count12Months
            // 
            this.top10Count12Months.AutoSize = true;
            this.top10Count12Months.Location = new System.Drawing.Point(21, 80);
            this.top10Count12Months.Name = "top10Count12Months";
            this.top10Count12Months.Size = new System.Drawing.Size(75, 17);
            this.top10Count12Months.TabIndex = 12;
            this.top10Count12Months.TabStop = true;
            this.top10Count12Months.Text = "12 Months";
            this.top10Count12Months.UseVisualStyleBackColor = true;
            // 
            // top10Count24Hours
            // 
            this.top10Count24Hours.AutoSize = true;
            this.top10Count24Hours.Location = new System.Drawing.Point(21, 20);
            this.top10Count24Hours.Name = "top10Count24Hours";
            this.top10Count24Hours.Size = new System.Drawing.Size(68, 17);
            this.top10Count24Hours.TabIndex = 10;
            this.top10Count24Hours.TabStop = true;
            this.top10Count24Hours.Text = "24 Hours";
            this.top10Count24Hours.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Start:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // top10CountStart
            // 
            this.top10CountStart.CustomFormat = "MM/dd/yyyy HH:mm";
            this.top10CountStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.top10CountStart.Location = new System.Drawing.Point(144, 22);
            this.top10CountStart.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.top10CountStart.Name = "top10CountStart";
            this.top10CountStart.Size = new System.Drawing.Size(126, 20);
            this.top10CountStart.TabIndex = 17;
            // 
            // loadPlayerCountLoad
            // 
            this.loadPlayerCountLoad.Location = new System.Drawing.Point(618, 26);
            this.loadPlayerCountLoad.Name = "loadPlayerCountLoad";
            this.loadPlayerCountLoad.Size = new System.Drawing.Size(75, 23);
            this.loadPlayerCountLoad.TabIndex = 16;
            this.loadPlayerCountLoad.Text = "Submit";
            this.loadPlayerCountLoad.UseVisualStyleBackColor = true;
            this.loadPlayerCountLoad.Click += new System.EventHandler(this.loadPlayerCountLoad_Click);
            // 
            // chartTop10PlayerCount
            // 
            chartArea3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartTop10PlayerCount";
            this.chartTop10PlayerCount.ChartAreas.Add(chartArea3);
            this.chartTop10PlayerCount.Location = new System.Drawing.Point(10, 100);
            this.chartTop10PlayerCount.Name = "chartTop10PlayerCount";
            this.chartTop10PlayerCount.Size = new System.Drawing.Size(790, 350);
            this.chartTop10PlayerCount.TabIndex = 15;
            this.chartTop10PlayerCount.Text = "Player Load";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PlayerProfileStats.Properties.Resources.playerprofile;
            this.pictureBox1.Location = new System.Drawing.Point(20, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // serverAddress
            // 
            this.serverAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverAddress.Location = new System.Drawing.Point(305, 26);
            this.serverAddress.Name = "serverAddress";
            this.serverAddress.Size = new System.Drawing.Size(363, 23);
            this.serverAddress.TabIndex = 5;
            this.serverAddress.Text = "Not Connected";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 597);
            this.Controls.Add(this.serverAddress);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.button1);
            this.Name = "Profile";
            this.Text = "Inventory Profile";
            this.tabControl1.ResumeLayout(false);
            this.tabPlayerLoad.ResumeLayout(false);
            this.tabPlayerLoad.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPlayerLoad)).EndInit();
            this.tabTop10.ResumeLayout(false);
            this.tabTop10.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop10PlayerAverage)).EndInit();
            this.tabPlayerCount.ResumeLayout(false);
            this.tabPlayerCount.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop10PlayerCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabTop10;
        private System.Windows.Forms.TabPage tabPlayerLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop10PlayerAverage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPlayerLoad;
        private System.Windows.Forms.Button loadPlayerLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton player7Days;
        private System.Windows.Forms.RadioButton player12Months;
        private System.Windows.Forms.RadioButton player24Hours;
        private System.Windows.Forms.Label playerEndDate;
        private System.Windows.Forms.Label playerStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker playerStart;
        private System.Windows.Forms.Button playerSetNow;
        private System.Windows.Forms.Button Top10AvgSetNow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Top10Avg7Days;
        private System.Windows.Forms.RadioButton Top10Avg12Months;
        private System.Windows.Forms.RadioButton Top10Avg24Hours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker top10AvgStart;
        private System.Windows.Forms.Button loadPlayerAverageLoad;
        private System.Windows.Forms.RadioButton Top10Avg1Month;
        private System.Windows.Forms.RadioButton player1Month;
        private System.Windows.Forms.TabPage tabPlayerCount;
        private System.Windows.Forms.Button Top10CountSetNow;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton top10Count1Month;
        private System.Windows.Forms.RadioButton top10Count7Days;
        private System.Windows.Forms.RadioButton top10Count12Months;
        private System.Windows.Forms.RadioButton top10Count24Hours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker top10CountStart;
        private System.Windows.Forms.Button loadPlayerCountLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop10PlayerCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label serverAddress;
    }
}

