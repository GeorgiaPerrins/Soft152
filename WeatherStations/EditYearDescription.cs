using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStations
{
    public partial class frmEditYearDescription : Form
    {
        //creates variables to store the locataion and year reference numbers
        int locationReference, yearReference;
        public frmEditYearDescription(int locationRef, int yearRef)
        {
            //save the reference to the year and location you are editing
            locationReference = locationRef;
            yearReference = yearRef;
            InitializeComponent();
            //calls the method that fills the text boxes
            FillTextBoxes();
        }
        public void FillTextBoxes()
        {
            //fills in the text box with the correct details
            txtYear.Text = Data.Locations[locationReference].GetYears()[yearReference].GetYear().ToString();
            txtYearDescription.Text = Data.Locations[locationReference].GetYears()[yearReference].GetYearDescription();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //closes this form
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //sets the new year description for the correct year if it is emty inputs no description available
            if (txtYearDescription.Text == "")
            {
                Data.Locations[locationReference].GetYears()[yearReference].SetYearDescription("no description available");
            }
            else
            {
                Data.Locations[locationReference].GetYears()[yearReference].SetYearDescription(txtYearDescription.Text);
            }
            MessageBox.Show("Updated the year description");
        }
    }
}
