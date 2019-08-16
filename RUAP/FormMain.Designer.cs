namespace RUAP
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.trackBarN = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxAge = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonPredict = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.trackBarSS = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.trackBarI = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBarO = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBarE = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxEthnicity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxEducation = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.chartResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxShowByAge = new System.Windows.Forms.ComboBox();
            this.buttonUpdateGraph = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarE)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarN
            // 
            this.trackBarN.Location = new System.Drawing.Point(72, 81);
            this.trackBarN.Maximum = 60;
            this.trackBarN.Minimum = 12;
            this.trackBarN.Name = "trackBarN";
            this.trackBarN.Size = new System.Drawing.Size(104, 45);
            this.trackBarN.TabIndex = 1;
            this.trackBarN.TickFrequency = 6;
            this.trackBarN.Value = 12;
            this.trackBarN.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Age: ";
            // 
            // comboBoxAge
            // 
            this.comboBoxAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAge.FormattingEnabled = true;
            this.comboBoxAge.Items.AddRange(new object[] {
            "18-24",
            "25-34",
            "35-44",
            "45-54",
            "55-64",
            "65+"});
            this.comboBoxAge.Location = new System.Drawing.Point(104, 44);
            this.comboBoxAge.Name = "comboBoxAge";
            this.comboBoxAge.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAge.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(766, 549);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.labelResult);
            this.tabPage1.Controls.Add(this.buttonPredict);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.comboBoxEthnicity);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.comboBoxCountry);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.comboBoxEducation);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBoxGender);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBoxAge);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(758, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "New patient";
            // 
            // buttonPredict
            // 
            this.buttonPredict.Location = new System.Drawing.Point(445, 42);
            this.buttonPredict.Name = "buttonPredict";
            this.buttonPredict.Size = new System.Drawing.Size(159, 23);
            this.buttonPredict.TabIndex = 14;
            this.buttonPredict.Text = "Predict Cocaine Use Risk";
            this.buttonPredict.UseVisualStyleBackColor = true;
            this.buttonPredict.Click += new System.EventHandler(this.buttonPredict_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.trackBarSS);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.trackBarI);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.trackBarC);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.trackBarA);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.trackBarO);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.trackBarE);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.trackBarN);
            this.groupBox1.Location = new System.Drawing.Point(25, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 303);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(409, 173);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Sensation-Seeking";
            this.toolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // trackBarSS
            // 
            this.trackBarSS.Location = new System.Drawing.Point(402, 188);
            this.trackBarSS.Maximum = 100;
            this.trackBarSS.Name = "trackBarSS";
            this.trackBarSS.Size = new System.Drawing.Size(104, 45);
            this.trackBarSS.TabIndex = 23;
            this.trackBarSS.TickFrequency = 10;
            this.trackBarSS.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(199, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Impulsiveness";
            this.toolTip1.SetToolTip(this.label11, "Impulsiveness is a tendency to act on a whim, displaying behavior characterized b" +
        "y little\r\nor no forethought, reflection, or consideration of the consequences.");
            // 
            // trackBarI
            // 
            this.trackBarI.Location = new System.Drawing.Point(182, 188);
            this.trackBarI.Maximum = 120;
            this.trackBarI.Minimum = 30;
            this.trackBarI.Name = "trackBarI";
            this.trackBarI.Size = new System.Drawing.Size(104, 45);
            this.trackBarI.TabIndex = 21;
            this.trackBarI.TickFrequency = 10;
            this.trackBarI.Value = 30;
            this.trackBarI.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(515, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Conscientiousness";
            this.toolTip1.SetToolTip(this.label10, "Conscientiousness is a tendency to be organized and dependable,\r\nstrong-willed, p" +
        "ersistent, reliable, and efficient.");
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(512, 81);
            this.trackBarC.Maximum = 60;
            this.trackBarC.Minimum = 12;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(104, 45);
            this.trackBarC.TabIndex = 19;
            this.trackBarC.TickFrequency = 6;
            this.trackBarC.Value = 12;
            this.trackBarC.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Agreeableness";
            this.toolTip1.SetToolTip(this.label9, "Agreeableness is a dimension of interpersonal relations, characterized by\r\naltrui" +
        "sm, trust, modesty, kindness, compassion and cooperativeness.");
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(402, 81);
            this.trackBarA.Maximum = 60;
            this.trackBarA.Minimum = 12;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(104, 45);
            this.trackBarA.TabIndex = 17;
            this.trackBarA.TickFrequency = 6;
            this.trackBarA.Value = 12;
            this.trackBarA.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(284, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Openness to experience";
            this.toolTip1.SetToolTip(this.label8, "Openness to experience is a general appreciation for art, unusual ideas, and\r\nima" +
        "ginative, creative, unconventional, and wide interests.");
            // 
            // trackBarO
            // 
            this.trackBarO.Location = new System.Drawing.Point(292, 81);
            this.trackBarO.Maximum = 60;
            this.trackBarO.Minimum = 12;
            this.trackBarO.Name = "trackBarO";
            this.trackBarO.Size = new System.Drawing.Size(104, 45);
            this.trackBarO.TabIndex = 15;
            this.trackBarO.TickFrequency = 6;
            this.trackBarO.Value = 12;
            this.trackBarO.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Extraversion";
            this.toolTip1.SetToolTip(this.label7, "Extraversion is manifested in outgoing, warm, active, assertive, talkative,\r\nchee" +
        "rful, and in search of stimulation characteristics.");
            // 
            // trackBarE
            // 
            this.trackBarE.Location = new System.Drawing.Point(182, 81);
            this.trackBarE.Maximum = 60;
            this.trackBarE.Minimum = 12;
            this.trackBarE.Name = "trackBarE";
            this.trackBarE.Size = new System.Drawing.Size(104, 45);
            this.trackBarE.TabIndex = 13;
            this.trackBarE.TickFrequency = 6;
            this.trackBarE.Value = 12;
            this.trackBarE.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Neuroticism";
            this.toolTip1.SetToolTip(this.label6, "Neuroticism is a long-term tendency to experience negative emotions such\r\nas nerv" +
        "ousness, tension, anxiety and depression.");
            // 
            // comboBoxEthnicity
            // 
            this.comboBoxEthnicity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEthnicity.FormattingEnabled = true;
            this.comboBoxEthnicity.Items.AddRange(new object[] {
            "Asian",
            "Black",
            "White",
            "Mixed-B/A",
            "Mixed-W/A",
            "Mixed-W/B",
            "Other"});
            this.comboBoxEthnicity.Location = new System.Drawing.Point(104, 152);
            this.comboBoxEthnicity.Name = "comboBoxEthnicity";
            this.comboBoxEthnicity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEthnicity.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ethnicity: ";
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Items.AddRange(new object[] {
            "AUS",
            "CAN",
            "GBR",
            "IRL",
            "NZL",
            "USA",
            "OTH"});
            this.comboBoxCountry.Location = new System.Drawing.Point(104, 125);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCountry.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Country: ";
            // 
            // comboBoxEducation
            // 
            this.comboBoxEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEducation.FormattingEnabled = true;
            this.comboBoxEducation.Items.AddRange(new object[] {
            "left before 16",
            "left at 16",
            "left at 17",
            "left at 18",
            "no degree",
            "certificate/diploma",
            "univ degree",
            "masters degree",
            "doctorate degree"});
            this.comboBoxEducation.Location = new System.Drawing.Point(104, 98);
            this.comboBoxEducation.Name = "comboBoxEducation";
            this.comboBoxEducation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEducation.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Education: ";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBoxGender.Location = new System.Drawing.Point(104, 71);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGender.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gender: ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.buttonUpdateGraph);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.comboBoxShowByAge);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.comboBoxPeriod);
            this.tabPage2.Controls.Add(this.chartResults);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(758, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Patient Statistics";
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Items.AddRange(new object[] {
            "Last Month",
            "Last Six Months",
            "Last Year",
            "Last Five Years",
            "Whole History"});
            this.comboBoxPeriod.Location = new System.Drawing.Point(20, 68);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPeriod.TabIndex = 2;
            // 
            // chartResults
            // 
            chartArea15.Name = "ChartArea1";
            this.chartResults.ChartAreas.Add(chartArea15);
            legend15.Name = "Legend1";
            this.chartResults.Legends.Add(legend15);
            this.chartResults.Location = new System.Drawing.Point(161, 28);
            this.chartResults.Name = "chartResults";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series15.IsVisibleInLegend = false;
            series15.Legend = "Legend1";
            series15.MarkerSize = 15;
            series15.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series15.Name = "Result";
            series15.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series15.YValuesPerPoint = 2;
            this.chartResults.Series.Add(series15);
            this.chartResults.Size = new System.Drawing.Size(577, 377);
            this.chartResults.TabIndex = 0;
            this.chartResults.Text = "Patients";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(45, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Show by date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(45, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Show by age";
            // 
            // comboBoxShowByAge
            // 
            this.comboBoxShowByAge.FormattingEnabled = true;
            this.comboBoxShowByAge.Items.AddRange(new object[] {
            "18-24",
            "24-35",
            "35-44",
            "45-54",
            "55-64",
            "65+",
            "All ages"});
            this.comboBoxShowByAge.Location = new System.Drawing.Point(20, 151);
            this.comboBoxShowByAge.Name = "comboBoxShowByAge";
            this.comboBoxShowByAge.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShowByAge.TabIndex = 4;
            // 
            // buttonUpdateGraph
            // 
            this.buttonUpdateGraph.Location = new System.Drawing.Point(37, 221);
            this.buttonUpdateGraph.Name = "buttonUpdateGraph";
            this.buttonUpdateGraph.Size = new System.Drawing.Size(88, 23);
            this.buttonUpdateGraph.TabIndex = 6;
            this.buttonUpdateGraph.Text = "Update Graph";
            this.buttonUpdateGraph.UseVisualStyleBackColor = true;
            this.buttonUpdateGraph.Click += new System.EventHandler(this.buttonUpdateGraph_Click);
            // 
            // labelResult
            // 
            this.labelResult.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelResult.Location = new System.Drawing.Point(424, 88);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(200, 80);
            this.labelResult.TabIndex = 15;
            this.labelResult.Text = "Insert Patient Data";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 573);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMain";
            this.Text = "Cocaine Risk App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarN)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarE)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxAge;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxEthnicity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxEducation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TrackBar trackBarSS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar trackBarI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar trackBarC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBarO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBarE;
        private System.Windows.Forms.Button buttonPredict;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResults;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxShowByAge;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonUpdateGraph;
        private System.Windows.Forms.Label labelResult;
    }
}

