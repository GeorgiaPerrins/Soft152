namespace WeatherStations
{
    partial class frmEditMonthlyObservation
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
            this.txtMonthId = new System.Windows.Forms.TextBox();
            this.lblMonthID = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.txtMaxTemp = new System.Windows.Forms.TextBox();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.txtMinTemp = new System.Windows.Forms.TextBox();
            this.lblNumAirFrost = new System.Windows.Forms.Label();
            this.txtNumOfAirFrost = new System.Windows.Forms.TextBox();
            this.lblMmsOfRainfall = new System.Windows.Forms.Label();
            this.txtMmsOfRainfall = new System.Windows.Forms.TextBox();
            this.lblHoursOfSunshine = new System.Windows.Forms.Label();
            this.txtHoursOfSunshine = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMonthId
            // 
            this.txtMonthId.Location = new System.Drawing.Point(184, 63);
            this.txtMonthId.Name = "txtMonthId";
            this.txtMonthId.ReadOnly = true;
            this.txtMonthId.Size = new System.Drawing.Size(100, 20);
            this.txtMonthId.TabIndex = 0;
            // 
            // lblMonthID
            // 
            this.lblMonthID.AutoSize = true;
            this.lblMonthID.Location = new System.Drawing.Point(36, 66);
            this.lblMonthID.Name = "lblMonthID";
            this.lblMonthID.Size = new System.Drawing.Size(51, 13);
            this.lblMonthID.TabIndex = 1;
            this.lblMonthID.Text = "MonthID:";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Location = new System.Drawing.Point(36, 95);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(117, 13);
            this.lblMaxTemp.TabIndex = 3;
            this.lblMaxTemp.Text = "Maximum Temperature:";
            // 
            // txtMaxTemp
            // 
            this.txtMaxTemp.Location = new System.Drawing.Point(184, 92);
            this.txtMaxTemp.Name = "txtMaxTemp";
            this.txtMaxTemp.Size = new System.Drawing.Size(100, 20);
            this.txtMaxTemp.TabIndex = 2;
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Location = new System.Drawing.Point(36, 124);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(114, 13);
            this.lblMinTemp.TabIndex = 5;
            this.lblMinTemp.Text = "Minimum Temperature:";
            // 
            // txtMinTemp
            // 
            this.txtMinTemp.Location = new System.Drawing.Point(184, 121);
            this.txtMinTemp.Name = "txtMinTemp";
            this.txtMinTemp.Size = new System.Drawing.Size(100, 20);
            this.txtMinTemp.TabIndex = 4;
            // 
            // lblNumAirFrost
            // 
            this.lblNumAirFrost.AutoSize = true;
            this.lblNumAirFrost.Location = new System.Drawing.Point(36, 153);
            this.lblNumAirFrost.Name = "lblNumAirFrost";
            this.lblNumAirFrost.Size = new System.Drawing.Size(129, 13);
            this.lblNumAirFrost.TabIndex = 7;
            this.lblNumAirFrost.Text = "Number Of Air Frost Days:";
            // 
            // txtNumOfAirFrost
            // 
            this.txtNumOfAirFrost.Location = new System.Drawing.Point(184, 150);
            this.txtNumOfAirFrost.Name = "txtNumOfAirFrost";
            this.txtNumOfAirFrost.Size = new System.Drawing.Size(100, 20);
            this.txtNumOfAirFrost.TabIndex = 6;
            // 
            // lblMmsOfRainfall
            // 
            this.lblMmsOfRainfall.AutoSize = true;
            this.lblMmsOfRainfall.Location = new System.Drawing.Point(36, 182);
            this.lblMmsOfRainfall.Name = "lblMmsOfRainfall";
            this.lblMmsOfRainfall.Size = new System.Drawing.Size(113, 13);
            this.lblMmsOfRainfall.TabIndex = 9;
            this.lblMmsOfRainfall.Text = "Millimetres Of Rainfall: ";
            // 
            // txtMmsOfRainfall
            // 
            this.txtMmsOfRainfall.Location = new System.Drawing.Point(184, 179);
            this.txtMmsOfRainfall.Name = "txtMmsOfRainfall";
            this.txtMmsOfRainfall.Size = new System.Drawing.Size(100, 20);
            this.txtMmsOfRainfall.TabIndex = 8;
            // 
            // lblHoursOfSunshine
            // 
            this.lblHoursOfSunshine.AutoSize = true;
            this.lblHoursOfSunshine.Location = new System.Drawing.Point(36, 211);
            this.lblHoursOfSunshine.Name = "lblHoursOfSunshine";
            this.lblHoursOfSunshine.Size = new System.Drawing.Size(99, 13);
            this.lblHoursOfSunshine.TabIndex = 11;
            this.lblHoursOfSunshine.Text = "Hours Of Sunshine:";
            // 
            // txtHoursOfSunshine
            // 
            this.txtHoursOfSunshine.Location = new System.Drawing.Point(184, 208);
            this.txtHoursOfSunshine.Name = "txtHoursOfSunshine";
            this.txtHoursOfSunshine.Size = new System.Drawing.Size(100, 20);
            this.txtHoursOfSunshine.TabIndex = 10;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(200, 243);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEditMonthlyObservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 304);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblHoursOfSunshine);
            this.Controls.Add(this.txtHoursOfSunshine);
            this.Controls.Add(this.lblMmsOfRainfall);
            this.Controls.Add(this.txtMmsOfRainfall);
            this.Controls.Add(this.lblNumAirFrost);
            this.Controls.Add(this.txtNumOfAirFrost);
            this.Controls.Add(this.lblMinTemp);
            this.Controls.Add(this.txtMinTemp);
            this.Controls.Add(this.lblMaxTemp);
            this.Controls.Add(this.txtMaxTemp);
            this.Controls.Add(this.lblMonthID);
            this.Controls.Add(this.txtMonthId);
            this.Name = "frmEditMonthlyObservation";
            this.Text = "Edit Monthly Observation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonthId;
        private System.Windows.Forms.Label lblMonthID;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.TextBox txtMaxTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.TextBox txtMinTemp;
        private System.Windows.Forms.Label lblNumAirFrost;
        private System.Windows.Forms.TextBox txtNumOfAirFrost;
        private System.Windows.Forms.Label lblMmsOfRainfall;
        private System.Windows.Forms.TextBox txtMmsOfRainfall;
        private System.Windows.Forms.Label lblHoursOfSunshine;
        private System.Windows.Forms.TextBox txtHoursOfSunshine;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
    }
}