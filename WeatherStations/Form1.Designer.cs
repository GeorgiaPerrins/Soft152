namespace WeatherStations
{
    partial class frmWeatherStations
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
            this.txtSearchLocation = new System.Windows.Forms.TextBox();
            this.lblLocationName = new System.Windows.Forms.Label();
            this.btnSearchLocation = new System.Windows.Forms.Button();
            this.lstLocationNames = new System.Windows.Forms.ListBox();
            this.btnEditLocation = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.lstYears = new System.Windows.Forms.ListBox();
            this.lstMonths = new System.Windows.Forms.ListBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnSearchYear = new System.Windows.Forms.Button();
            this.txtSearchYear = new System.Windows.Forms.TextBox();
            this.btnEditYearDesc = new System.Windows.Forms.Button();
            this.btnAddNewYear = new System.Windows.Forms.Button();
            this.lstLocationInfo = new System.Windows.Forms.ListBox();
            this.lstObservations = new System.Windows.Forms.ListBox();
            this.grpLocations = new System.Windows.Forms.GroupBox();
            this.grpYears = new System.Windows.Forms.GroupBox();
            this.grpMonths = new System.Windows.Forms.GroupBox();
            this.btnSearchMonth = new System.Windows.Forms.Button();
            this.lblMonthNum = new System.Windows.Forms.Label();
            this.txtMonthNum = new System.Windows.Forms.TextBox();
            this.btnEditMonthlyObservation = new System.Windows.Forms.Button();
            this.picMetLogo = new System.Windows.Forms.PictureBox();
            this.grpAnalysis = new System.Windows.Forms.GroupBox();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.lblGraphMonth = new System.Windows.Forms.Label();
            this.grpAnalysisChoice = new System.Windows.Forms.GroupBox();
            this.btnSubmitAnalysis = new System.Windows.Forms.Button();
            this.radLocHoursSunshine = new System.Windows.Forms.RadioButton();
            this.radLocMmsRainfall = new System.Windows.Forms.RadioButton();
            this.radLocNumAirFrost = new System.Windows.Forms.RadioButton();
            this.radLocMinTemp = new System.Windows.Forms.RadioButton();
            this.radLocMaxTemp = new System.Windows.Forms.RadioButton();
            this.radYearHoursSunshine = new System.Windows.Forms.RadioButton();
            this.radYearMmsRainfall = new System.Windows.Forms.RadioButton();
            this.radYearNumAirFrost = new System.Windows.Forms.RadioButton();
            this.radYearMinTemp = new System.Windows.Forms.RadioButton();
            this.radYearMaxTemp = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpLocations.SuspendLayout();
            this.grpYears.SuspendLayout();
            this.grpMonths.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMetLogo)).BeginInit();
            this.grpAnalysis.SuspendLayout();
            this.pnlGraph.SuspendLayout();
            this.grpAnalysisChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchLocation
            // 
            this.txtSearchLocation.Location = new System.Drawing.Point(93, 39);
            this.txtSearchLocation.Name = "txtSearchLocation";
            this.txtSearchLocation.Size = new System.Drawing.Size(100, 20);
            this.txtSearchLocation.TabIndex = 0;
            // 
            // lblLocationName
            // 
            this.lblLocationName.AutoSize = true;
            this.lblLocationName.Location = new System.Drawing.Point(8, 42);
            this.lblLocationName.Name = "lblLocationName";
            this.lblLocationName.Size = new System.Drawing.Size(82, 13);
            this.lblLocationName.TabIndex = 1;
            this.lblLocationName.Text = "Location Name:";
            // 
            // btnSearchLocation
            // 
            this.btnSearchLocation.Location = new System.Drawing.Point(211, 37);
            this.btnSearchLocation.Name = "btnSearchLocation";
            this.btnSearchLocation.Size = new System.Drawing.Size(50, 23);
            this.btnSearchLocation.TabIndex = 2;
            this.btnSearchLocation.Text = "Search";
            this.btnSearchLocation.UseVisualStyleBackColor = true;
            this.btnSearchLocation.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstLocationNames
            // 
            this.lstLocationNames.FormattingEnabled = true;
            this.lstLocationNames.Location = new System.Drawing.Point(11, 65);
            this.lstLocationNames.Name = "lstLocationNames";
            this.lstLocationNames.Size = new System.Drawing.Size(250, 160);
            this.lstLocationNames.TabIndex = 3;
            this.lstLocationNames.SelectedIndexChanged += new System.EventHandler(this.lstLocations_SelectedIndexChanged);
            // 
            // btnEditLocation
            // 
            this.btnEditLocation.Location = new System.Drawing.Point(570, 97);
            this.btnEditLocation.Name = "btnEditLocation";
            this.btnEditLocation.Size = new System.Drawing.Size(92, 39);
            this.btnEditLocation.TabIndex = 4;
            this.btnEditLocation.Text = "Edit Location";
            this.btnEditLocation.UseVisualStyleBackColor = true;
            this.btnEditLocation.Click += new System.EventHandler(this.btnEditLocation_Click);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.Location = new System.Drawing.Point(570, 142);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(92, 39);
            this.btnAddLocation.TabIndex = 5;
            this.btnAddLocation.Text = "Add New Location";
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // lstYears
            // 
            this.lstYears.FormattingEnabled = true;
            this.lstYears.Location = new System.Drawing.Point(15, 65);
            this.lstYears.Name = "lstYears";
            this.lstYears.Size = new System.Drawing.Size(524, 160);
            this.lstYears.TabIndex = 7;
            this.lstYears.SelectedIndexChanged += new System.EventHandler(this.lstYears_SelectedIndexChanged);
            // 
            // lstMonths
            // 
            this.lstMonths.FormattingEnabled = true;
            this.lstMonths.Location = new System.Drawing.Point(11, 62);
            this.lstMonths.Name = "lstMonths";
            this.lstMonths.Size = new System.Drawing.Size(250, 160);
            this.lstMonths.TabIndex = 8;
            this.lstMonths.SelectedIndexChanged += new System.EventHandler(this.lstMonths_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 42);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 9;
            this.lblYear.Text = "Year:";
            // 
            // btnSearchYear
            // 
            this.btnSearchYear.Location = new System.Drawing.Point(215, 37);
            this.btnSearchYear.Name = "btnSearchYear";
            this.btnSearchYear.Size = new System.Drawing.Size(50, 23);
            this.btnSearchYear.TabIndex = 11;
            this.btnSearchYear.Text = "Search";
            this.btnSearchYear.UseVisualStyleBackColor = true;
            this.btnSearchYear.Click += new System.EventHandler(this.btnSearchYear_Click);
            // 
            // txtSearchYear
            // 
            this.txtSearchYear.Location = new System.Drawing.Point(97, 39);
            this.txtSearchYear.Name = "txtSearchYear";
            this.txtSearchYear.Size = new System.Drawing.Size(100, 20);
            this.txtSearchYear.TabIndex = 10;
            // 
            // btnEditYearDesc
            // 
            this.btnEditYearDesc.Location = new System.Drawing.Point(570, 97);
            this.btnEditYearDesc.Name = "btnEditYearDesc";
            this.btnEditYearDesc.Size = new System.Drawing.Size(92, 39);
            this.btnEditYearDesc.TabIndex = 12;
            this.btnEditYearDesc.Text = "Edit Year Description";
            this.btnEditYearDesc.UseVisualStyleBackColor = true;
            this.btnEditYearDesc.Click += new System.EventHandler(this.btnEditYearDesc_Click);
            // 
            // btnAddNewYear
            // 
            this.btnAddNewYear.Location = new System.Drawing.Point(570, 142);
            this.btnAddNewYear.Name = "btnAddNewYear";
            this.btnAddNewYear.Size = new System.Drawing.Size(92, 39);
            this.btnAddNewYear.TabIndex = 13;
            this.btnAddNewYear.Text = "Add New Year";
            this.btnAddNewYear.UseVisualStyleBackColor = true;
            this.btnAddNewYear.Click += new System.EventHandler(this.btnAddNewYear_Click);
            // 
            // lstLocationInfo
            // 
            this.lstLocationInfo.FormattingEnabled = true;
            this.lstLocationInfo.Location = new System.Drawing.Point(290, 65);
            this.lstLocationInfo.Name = "lstLocationInfo";
            this.lstLocationInfo.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstLocationInfo.Size = new System.Drawing.Size(250, 160);
            this.lstLocationInfo.TabIndex = 14;
            // 
            // lstObservations
            // 
            this.lstObservations.FormattingEnabled = true;
            this.lstObservations.Location = new System.Drawing.Point(290, 62);
            this.lstObservations.Name = "lstObservations";
            this.lstObservations.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstObservations.Size = new System.Drawing.Size(250, 160);
            this.lstObservations.TabIndex = 15;
            // 
            // grpLocations
            // 
            this.grpLocations.Controls.Add(this.lstLocationInfo);
            this.grpLocations.Controls.Add(this.lstLocationNames);
            this.grpLocations.Controls.Add(this.btnSearchLocation);
            this.grpLocations.Controls.Add(this.lblLocationName);
            this.grpLocations.Controls.Add(this.txtSearchLocation);
            this.grpLocations.Controls.Add(this.btnEditLocation);
            this.grpLocations.Controls.Add(this.btnAddLocation);
            this.grpLocations.Location = new System.Drawing.Point(12, 136);
            this.grpLocations.Name = "grpLocations";
            this.grpLocations.Size = new System.Drawing.Size(689, 273);
            this.grpLocations.TabIndex = 16;
            this.grpLocations.TabStop = false;
            this.grpLocations.Text = "Locations";
            // 
            // grpYears
            // 
            this.grpYears.Controls.Add(this.btnAddNewYear);
            this.grpYears.Controls.Add(this.btnEditYearDesc);
            this.grpYears.Controls.Add(this.btnSearchYear);
            this.grpYears.Controls.Add(this.txtSearchYear);
            this.grpYears.Controls.Add(this.lblYear);
            this.grpYears.Controls.Add(this.lstYears);
            this.grpYears.Location = new System.Drawing.Point(707, 136);
            this.grpYears.Name = "grpYears";
            this.grpYears.Size = new System.Drawing.Size(689, 273);
            this.grpYears.TabIndex = 17;
            this.grpYears.TabStop = false;
            this.grpYears.Text = "Years";
            // 
            // grpMonths
            // 
            this.grpMonths.Controls.Add(this.btnSearchMonth);
            this.grpMonths.Controls.Add(this.lblMonthNum);
            this.grpMonths.Controls.Add(this.txtMonthNum);
            this.grpMonths.Controls.Add(this.btnEditMonthlyObservation);
            this.grpMonths.Controls.Add(this.lstObservations);
            this.grpMonths.Controls.Add(this.lstMonths);
            this.grpMonths.Location = new System.Drawing.Point(12, 415);
            this.grpMonths.Name = "grpMonths";
            this.grpMonths.Size = new System.Drawing.Size(689, 273);
            this.grpMonths.TabIndex = 18;
            this.grpMonths.TabStop = false;
            this.grpMonths.Text = "Months";
            // 
            // btnSearchMonth
            // 
            this.btnSearchMonth.Location = new System.Drawing.Point(211, 34);
            this.btnSearchMonth.Name = "btnSearchMonth";
            this.btnSearchMonth.Size = new System.Drawing.Size(50, 23);
            this.btnSearchMonth.TabIndex = 18;
            this.btnSearchMonth.Text = "Search";
            this.btnSearchMonth.UseVisualStyleBackColor = true;
            this.btnSearchMonth.Click += new System.EventHandler(this.btnSearchMonth_Click);
            // 
            // lblMonthNum
            // 
            this.lblMonthNum.AutoSize = true;
            this.lblMonthNum.Location = new System.Drawing.Point(8, 39);
            this.lblMonthNum.Name = "lblMonthNum";
            this.lblMonthNum.Size = new System.Drawing.Size(40, 13);
            this.lblMonthNum.TabIndex = 17;
            this.lblMonthNum.Text = "Month:";
            // 
            // txtMonthNum
            // 
            this.txtMonthNum.Location = new System.Drawing.Point(93, 36);
            this.txtMonthNum.Name = "txtMonthNum";
            this.txtMonthNum.Size = new System.Drawing.Size(100, 20);
            this.txtMonthNum.TabIndex = 16;
            // 
            // btnEditMonthlyObservation
            // 
            this.btnEditMonthlyObservation.Location = new System.Drawing.Point(570, 120);
            this.btnEditMonthlyObservation.Name = "btnEditMonthlyObservation";
            this.btnEditMonthlyObservation.Size = new System.Drawing.Size(92, 39);
            this.btnEditMonthlyObservation.TabIndex = 14;
            this.btnEditMonthlyObservation.Text = "Edit Monthly Obervation";
            this.btnEditMonthlyObservation.UseVisualStyleBackColor = true;
            this.btnEditMonthlyObservation.Click += new System.EventHandler(this.btnEditMonthlyObservation_Click);
            // 
            // picMetLogo
            // 
            this.picMetLogo.Image = global::WeatherStations.Properties.Resources.MetOfficeLogo;
            this.picMetLogo.Location = new System.Drawing.Point(12, 12);
            this.picMetLogo.Name = "picMetLogo";
            this.picMetLogo.Size = new System.Drawing.Size(525, 113);
            this.picMetLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMetLogo.TabIndex = 19;
            this.picMetLogo.TabStop = false;
            // 
            // grpAnalysis
            // 
            this.grpAnalysis.Controls.Add(this.pnlGraph);
            this.grpAnalysis.Controls.Add(this.grpAnalysisChoice);
            this.grpAnalysis.Location = new System.Drawing.Point(707, 415);
            this.grpAnalysis.Name = "grpAnalysis";
            this.grpAnalysis.Size = new System.Drawing.Size(689, 273);
            this.grpAnalysis.TabIndex = 20;
            this.grpAnalysis.TabStop = false;
            this.grpAnalysis.Text = "Analysis";
            // 
            // pnlGraph
            // 
            this.pnlGraph.Controls.Add(this.lblGraphMonth);
            this.pnlGraph.Location = new System.Drawing.Point(318, 10);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(355, 257);
            this.pnlGraph.TabIndex = 1;
            this.pnlGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGraph_Paint);
            // 
            // lblGraphMonth
            // 
            this.lblGraphMonth.AutoSize = true;
            this.lblGraphMonth.Location = new System.Drawing.Point(164, 244);
            this.lblGraphMonth.Name = "lblGraphMonth";
            this.lblGraphMonth.Size = new System.Drawing.Size(37, 13);
            this.lblGraphMonth.TabIndex = 0;
            this.lblGraphMonth.Text = "Month";
            // 
            // grpAnalysisChoice
            // 
            this.grpAnalysisChoice.Controls.Add(this.btnSubmitAnalysis);
            this.grpAnalysisChoice.Controls.Add(this.radLocHoursSunshine);
            this.grpAnalysisChoice.Controls.Add(this.radLocMmsRainfall);
            this.grpAnalysisChoice.Controls.Add(this.radLocNumAirFrost);
            this.grpAnalysisChoice.Controls.Add(this.radLocMinTemp);
            this.grpAnalysisChoice.Controls.Add(this.radLocMaxTemp);
            this.grpAnalysisChoice.Controls.Add(this.radYearHoursSunshine);
            this.grpAnalysisChoice.Controls.Add(this.radYearMmsRainfall);
            this.grpAnalysisChoice.Controls.Add(this.radYearNumAirFrost);
            this.grpAnalysisChoice.Controls.Add(this.radYearMinTemp);
            this.grpAnalysisChoice.Controls.Add(this.radYearMaxTemp);
            this.grpAnalysisChoice.Location = new System.Drawing.Point(15, 27);
            this.grpAnalysisChoice.Name = "grpAnalysisChoice";
            this.grpAnalysisChoice.Size = new System.Drawing.Size(293, 240);
            this.grpAnalysisChoice.TabIndex = 0;
            this.grpAnalysisChoice.TabStop = false;
            this.grpAnalysisChoice.Text = "Select one:";
            // 
            // btnSubmitAnalysis
            // 
            this.btnSubmitAnalysis.Location = new System.Drawing.Point(223, 17);
            this.btnSubmitAnalysis.Name = "btnSubmitAnalysis";
            this.btnSubmitAnalysis.Size = new System.Drawing.Size(55, 23);
            this.btnSubmitAnalysis.TabIndex = 10;
            this.btnSubmitAnalysis.Text = "Submit";
            this.btnSubmitAnalysis.UseVisualStyleBackColor = true;
            this.btnSubmitAnalysis.Click += new System.EventHandler(this.btnSubmitAnalysis_Click);
            // 
            // radLocHoursSunshine
            // 
            this.radLocHoursSunshine.AutoSize = true;
            this.radLocHoursSunshine.Location = new System.Drawing.Point(10, 212);
            this.radLocHoursSunshine.Name = "radLocHoursSunshine";
            this.radLocHoursSunshine.Size = new System.Drawing.Size(241, 17);
            this.radLocHoursSunshine.TabIndex = 9;
            this.radLocHoursSunshine.Text = "Average Hours Of Sunshine For The Location";
            this.radLocHoursSunshine.UseVisualStyleBackColor = true;
            // 
            // radLocMmsRainfall
            // 
            this.radLocMmsRainfall.AutoSize = true;
            this.radLocMmsRainfall.Location = new System.Drawing.Point(10, 191);
            this.radLocMmsRainfall.Name = "radLocMmsRainfall";
            this.radLocMmsRainfall.Size = new System.Drawing.Size(281, 17);
            this.radLocMmsRainfall.TabIndex = 8;
            this.radLocMmsRainfall.Text = "Average Millemetres Of Rainfall For The Location (mm)";
            this.radLocMmsRainfall.UseVisualStyleBackColor = true;
            // 
            // radLocNumAirFrost
            // 
            this.radLocNumAirFrost.AutoSize = true;
            this.radLocNumAirFrost.Location = new System.Drawing.Point(10, 170);
            this.radLocNumAirFrost.Name = "radLocNumAirFrost";
            this.radLocNumAirFrost.Size = new System.Drawing.Size(269, 17);
            this.radLocNumAirFrost.TabIndex = 7;
            this.radLocNumAirFrost.Text = "Average Number of Air Frost Days For The Location";
            this.radLocNumAirFrost.UseVisualStyleBackColor = true;
            // 
            // radLocMinTemp
            // 
            this.radLocMinTemp.AutoSize = true;
            this.radLocMinTemp.Location = new System.Drawing.Point(10, 149);
            this.radLocMinTemp.Name = "radLocMinTemp";
            this.radLocMinTemp.Size = new System.Drawing.Size(276, 17);
            this.radLocMinTemp.TabIndex = 6;
            this.radLocMinTemp.Text = "Average Minimum Temperature For The Location (°C)";
            this.radLocMinTemp.UseVisualStyleBackColor = true;
            // 
            // radLocMaxTemp
            // 
            this.radLocMaxTemp.AutoSize = true;
            this.radLocMaxTemp.Location = new System.Drawing.Point(10, 128);
            this.radLocMaxTemp.Name = "radLocMaxTemp";
            this.radLocMaxTemp.Size = new System.Drawing.Size(275, 17);
            this.radLocMaxTemp.TabIndex = 5;
            this.radLocMaxTemp.Text = "Average Maximim Temperature For The Location (°C)";
            this.radLocMaxTemp.UseVisualStyleBackColor = true;
            // 
            // radYearHoursSunshine
            // 
            this.radYearHoursSunshine.AutoSize = true;
            this.radYearHoursSunshine.Location = new System.Drawing.Point(10, 107);
            this.radYearHoursSunshine.Name = "radYearHoursSunshine";
            this.radYearHoursSunshine.Size = new System.Drawing.Size(179, 17);
            this.radYearHoursSunshine.TabIndex = 4;
            this.radYearHoursSunshine.Text = "Hours Of Sunshine For The Year";
            this.radYearHoursSunshine.UseVisualStyleBackColor = true;
            // 
            // radYearMmsRainfall
            // 
            this.radYearMmsRainfall.AutoSize = true;
            this.radYearMmsRainfall.Location = new System.Drawing.Point(10, 86);
            this.radYearMmsRainfall.Name = "radYearMmsRainfall";
            this.radYearMmsRainfall.Size = new System.Drawing.Size(215, 17);
            this.radYearMmsRainfall.TabIndex = 3;
            this.radYearMmsRainfall.Text = "Millimetres Of Rainfall For The Year (mm)";
            this.radYearMmsRainfall.UseVisualStyleBackColor = true;
            // 
            // radYearNumAirFrost
            // 
            this.radYearNumAirFrost.AutoSize = true;
            this.radYearNumAirFrost.Location = new System.Drawing.Point(10, 65);
            this.radYearNumAirFrost.Name = "radYearNumAirFrost";
            this.radYearNumAirFrost.Size = new System.Drawing.Size(209, 17);
            this.radYearNumAirFrost.TabIndex = 2;
            this.radYearNumAirFrost.Text = "Number Of Air Frost Days For The Year";
            this.radYearNumAirFrost.UseVisualStyleBackColor = true;
            // 
            // radYearMinTemp
            // 
            this.radYearMinTemp.AutoSize = true;
            this.radYearMinTemp.Location = new System.Drawing.Point(10, 44);
            this.radYearMinTemp.Name = "radYearMinTemp";
            this.radYearMinTemp.Size = new System.Drawing.Size(214, 17);
            this.radYearMinTemp.TabIndex = 1;
            this.radYearMinTemp.Text = "Minimum Temperature For The Year (°C)";
            this.radYearMinTemp.UseVisualStyleBackColor = true;
            // 
            // radYearMaxTemp
            // 
            this.radYearMaxTemp.AutoSize = true;
            this.radYearMaxTemp.Checked = true;
            this.radYearMaxTemp.Location = new System.Drawing.Point(10, 23);
            this.radYearMaxTemp.Name = "radYearMaxTemp";
            this.radYearMaxTemp.Size = new System.Drawing.Size(213, 17);
            this.radYearMaxTemp.TabIndex = 0;
            this.radYearMaxTemp.TabStop = true;
            this.radYearMaxTemp.Text = "Maximim Temperature For The Year (°C)";
            this.radYearMaxTemp.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1338, 94);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 36);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmWeatherStations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1414, 721);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpAnalysis);
            this.Controls.Add(this.picMetLogo);
            this.Controls.Add(this.grpMonths);
            this.Controls.Add(this.grpYears);
            this.Controls.Add(this.grpLocations);
            this.Name = "frmWeatherStations";
            this.Text = "Weather Stations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmWeatherStations_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpLocations.ResumeLayout(false);
            this.grpLocations.PerformLayout();
            this.grpYears.ResumeLayout(false);
            this.grpYears.PerformLayout();
            this.grpMonths.ResumeLayout(false);
            this.grpMonths.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMetLogo)).EndInit();
            this.grpAnalysis.ResumeLayout(false);
            this.pnlGraph.ResumeLayout(false);
            this.pnlGraph.PerformLayout();
            this.grpAnalysisChoice.ResumeLayout(false);
            this.grpAnalysisChoice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearchLocation;
        private System.Windows.Forms.Label lblLocationName;
        private System.Windows.Forms.Button btnSearchLocation;
        private System.Windows.Forms.ListBox lstLocationNames;
        private System.Windows.Forms.Button btnEditLocation;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.ListBox lstYears;
        private System.Windows.Forms.ListBox lstMonths;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnSearchYear;
        private System.Windows.Forms.TextBox txtSearchYear;
        private System.Windows.Forms.Button btnEditYearDesc;
        private System.Windows.Forms.Button btnAddNewYear;
        private System.Windows.Forms.ListBox lstLocationInfo;
        private System.Windows.Forms.ListBox lstObservations;
        private System.Windows.Forms.GroupBox grpLocations;
        private System.Windows.Forms.GroupBox grpYears;
        private System.Windows.Forms.GroupBox grpMonths;
        private System.Windows.Forms.Button btnEditMonthlyObservation;
        private System.Windows.Forms.PictureBox picMetLogo;
        private System.Windows.Forms.GroupBox grpAnalysis;
        private System.Windows.Forms.GroupBox grpAnalysisChoice;
        private System.Windows.Forms.RadioButton radYearHoursSunshine;
        private System.Windows.Forms.RadioButton radYearMmsRainfall;
        private System.Windows.Forms.RadioButton radYearNumAirFrost;
        private System.Windows.Forms.RadioButton radYearMinTemp;
        private System.Windows.Forms.RadioButton radYearMaxTemp;
        private System.Windows.Forms.RadioButton radLocHoursSunshine;
        private System.Windows.Forms.RadioButton radLocMmsRainfall;
        private System.Windows.Forms.RadioButton radLocNumAirFrost;
        private System.Windows.Forms.RadioButton radLocMinTemp;
        private System.Windows.Forms.RadioButton radLocMaxTemp;
        private System.Windows.Forms.Button btnSubmitAnalysis;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblGraphMonth;
        private System.Windows.Forms.Button btnSearchMonth;
        private System.Windows.Forms.Label lblMonthNum;
        private System.Windows.Forms.TextBox txtMonthNum;
    }
}

