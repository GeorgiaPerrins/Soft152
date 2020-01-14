namespace WeatherStations
{
    partial class frmAddNewYear
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYearDescription = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtYearDesc = new System.Windows.Forms.TextBox();
            this.dgdMonthlyObservations = new System.Windows.Forms.DataGridView();
            this.MonthId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MinTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumOfAirFrost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mmsOfRainfall = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursOfSunshine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMonthlyObservations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(55, 56);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 14;
            this.lblYear.Text = "Year:";
            // 
            // lblYearDescription
            // 
            this.lblYearDescription.AutoSize = true;
            this.lblYearDescription.Location = new System.Drawing.Point(55, 90);
            this.lblYearDescription.Name = "lblYearDescription";
            this.lblYearDescription.Size = new System.Drawing.Size(88, 13);
            this.lblYearDescription.TabIndex = 15;
            this.lblYearDescription.Text = "Year Description:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(158, 53);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 16;
            // 
            // txtYearDesc
            // 
            this.txtYearDesc.Location = new System.Drawing.Point(158, 87);
            this.txtYearDesc.Name = "txtYearDesc";
            this.txtYearDesc.Size = new System.Drawing.Size(100, 20);
            this.txtYearDesc.TabIndex = 17;
            // 
            // dgdMonthlyObservations
            // 
            this.dgdMonthlyObservations.AllowUserToAddRows = false;
            this.dgdMonthlyObservations.AllowUserToDeleteRows = false;
            this.dgdMonthlyObservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdMonthlyObservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MonthId,
            this.MaxTemp,
            this.MinTemp,
            this.NumOfAirFrost,
            this.mmsOfRainfall,
            this.hoursOfSunshine});
            this.dgdMonthlyObservations.Location = new System.Drawing.Point(58, 130);
            this.dgdMonthlyObservations.Name = "dgdMonthlyObservations";
            this.dgdMonthlyObservations.RowHeadersVisible = false;
            dataGridViewCellStyle7.NullValue = "0";
            this.dgdMonthlyObservations.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgdMonthlyObservations.RowTemplate.DefaultCellStyle.NullValue = "0";
            this.dgdMonthlyObservations.Size = new System.Drawing.Size(615, 285);
            this.dgdMonthlyObservations.TabIndex = 18;
            this.dgdMonthlyObservations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdMonthlyObservationsView_CellContentClick);
            // 
            // MonthId
            // 
            this.MonthId.DataPropertyName = "dgdMonthlyObs";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.MonthId.DefaultCellStyle = dataGridViewCellStyle1;
            this.MonthId.HeaderText = "Month ID";
            this.MonthId.Name = "MonthId";
            this.MonthId.ReadOnly = true;
            // 
            // MaxTemp
            // 
            dataGridViewCellStyle2.Format = "N1";
            dataGridViewCellStyle2.NullValue = "0";
            this.MaxTemp.DefaultCellStyle = dataGridViewCellStyle2;
            this.MaxTemp.HeaderText = "Maximum Temperature";
            this.MaxTemp.Name = "MaxTemp";
            // 
            // MinTemp
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = "0";
            this.MinTemp.DefaultCellStyle = dataGridViewCellStyle3;
            this.MinTemp.HeaderText = "Minimum Temperature";
            this.MinTemp.Name = "MinTemp";
            // 
            // NumOfAirFrost
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.NumOfAirFrost.DefaultCellStyle = dataGridViewCellStyle4;
            this.NumOfAirFrost.HeaderText = "Number Of Air Frost Days";
            this.NumOfAirFrost.Name = "NumOfAirFrost";
            // 
            // mmsOfRainfall
            // 
            dataGridViewCellStyle5.Format = "N1";
            dataGridViewCellStyle5.NullValue = "0";
            this.mmsOfRainfall.DefaultCellStyle = dataGridViewCellStyle5;
            this.mmsOfRainfall.HeaderText = "Millimetres Of Rainfall";
            this.mmsOfRainfall.Name = "mmsOfRainfall";
            // 
            // hoursOfSunshine
            // 
            dataGridViewCellStyle6.Format = "N1";
            dataGridViewCellStyle6.NullValue = "0";
            this.hoursOfSunshine.DefaultCellStyle = dataGridViewCellStyle6;
            this.hoursOfSunshine.HeaderText = "Hours Of Sunshine";
            this.hoursOfSunshine.Name = "hoursOfSunshine";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(598, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddNewYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgdMonthlyObservations);
            this.Controls.Add(this.txtYearDesc);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYearDescription);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnBack);
            this.Name = "frmAddNewYear";
            this.Text = "Add New Year";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddNewYear_FormClosing);
            this.Load += new System.EventHandler(this.frmAddNewYear_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdMonthlyObservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblYearDescription;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtYearDesc;
        private System.Windows.Forms.DataGridView dgdMonthlyObservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumOfAirFrost;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmsOfRainfall;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursOfSunshine;
        private System.Windows.Forms.Button btnSave;
    }
}