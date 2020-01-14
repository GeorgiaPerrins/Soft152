namespace WeatherStations
{
    partial class frmEditYearDescription
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
            this.lblYearDescription = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYearDescription = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYearDescription
            // 
            this.lblYearDescription.AutoSize = true;
            this.lblYearDescription.Location = new System.Drawing.Point(55, 89);
            this.lblYearDescription.Name = "lblYearDescription";
            this.lblYearDescription.Size = new System.Drawing.Size(88, 13);
            this.lblYearDescription.TabIndex = 0;
            this.lblYearDescription.Text = "Year Description:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(55, 61);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 1;
            this.lblYear.Text = "Year:";
            // 
            // txtYearDescription
            // 
            this.txtYearDescription.Location = new System.Drawing.Point(149, 86);
            this.txtYearDescription.Name = "txtYearDescription";
            this.txtYearDescription.Size = new System.Drawing.Size(242, 20);
            this.txtYearDescription.TabIndex = 2;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(149, 58);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(64, 20);
            this.txtYear.TabIndex = 3;
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
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(194, 130);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmEditYearDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 197);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtYearDescription);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblYearDescription);
            this.Name = "frmEditYearDescription";
            this.Text = "Edit Year Description";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYearDescription;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYearDescription;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
    }
}