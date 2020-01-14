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
    public partial class frmEditLocation : Form
    {
        int locationReference;
        public frmEditLocation( int locationRef)
        {
            //stores the value for the form we just came from

            locationReference = locationRef;
            InitializeComponent();
            //calls the method to load values into the text box
            LoadInValues();
        }
        public void LoadInValues()
        {
            //Loads the values into the text boxes so they can be edited
            txtLocationName.Text = Data.Locations[locationReference].GetLocationName();
            txtStreet.Text = Data.Locations[locationReference].GetStreetNumberAndName();
            txtCounty.Text = Data.Locations[locationReference].GetCounty();
            txtPostcode.Text = Data.Locations[locationReference].GetPostcode();
            txtLatitude.Text = Data.Locations[locationReference].GetLatitude().ToString();
            txtLongitude.Text = Data.Locations[locationReference].GetLongitude().ToString();
        }
        private void frmEditLocation_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //closes this form
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //updates and sets the variables for the locations selected
            Data.Locations[locationReference].SetLocationName(txtLocationName.Text);
            Data.Locations[locationReference].SetStreetNumberAndName(txtStreet.Text);
            Data.Locations[locationReference].SetCounty(txtCounty.Text);
            Data.Locations[locationReference].SetPostcode(txtPostcode.Text);
            //catch any incorrect inputs from the user when they try to input a string rather than a number
            try
            {
                Data.Locations[locationReference].SetLatitude(Convert.ToDouble(txtLatitude.Text));
            }
            catch (Exception E)
            {
                MessageBox.Show(string.Format("Error: {0} \nPlease enter a valid number for latitude.", E.Message));
            }
            try
            {
                Data.Locations[locationReference].SetLongitude(Convert.ToDouble(txtLongitude.Text));
            }
            catch (Exception E)
            {
                MessageBox.Show(string.Format("Error: {0} \nPlease enter a valid number for longitude.", E.Message));
            }
            MessageBox.Show("Correct data has been updated.");
        }
    }
}
