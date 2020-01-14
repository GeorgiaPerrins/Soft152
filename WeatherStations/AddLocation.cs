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
    public partial class frmAddLocation : Form
    {
        public frmAddLocation()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //shows the main form and closes this one
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddLocation();
        }
        public void AddLocation()
        {
            Location tempLocation = new Location();

            //saves the new values into the array
            tempLocation.SetLocationName(txtLocationName.Text);
            tempLocation.SetStreetNumberAndName(txtStreet.Text);
            tempLocation.SetCounty(txtCounty.Text);
            tempLocation.SetPostcode(txtPostcode.Text);
            //catch any incorrect inputs from the user when they try to input a string rather than a number
            try
            {
                tempLocation.SetLatitude(Convert.ToDouble(txtLatitude.Text));
            }
            catch (Exception E)
            {
                MessageBox.Show(string.Format("Error: {0} \nPlease enter a valid number for latitude.", E.Message));
                return;
            }
            try
            {
                tempLocation.SetLongitude(Convert.ToDouble(txtLongitude.Text));
            }
            catch (Exception E)
            {
                MessageBox.Show(string.Format("Error: {0} \nPlease enter a valid number for longitude.", E.Message));
                return;
            }
            MessageBox.Show("New locations added.");

            //resizes the array so a location can be added
            Array.Resize(ref Data.Locations, Data.Locations.Length + 1);
            Data.Locations[Data.Locations.Length - 1] = new Location();
            //set the temp to the main array
            Data.Locations[Data.Locations.Length - 1] = tempLocation;

            //creates a new instance of the form add year as there should be at least one year in a location
            frmAddNewYear tempFrmAddNewYear = new frmAddNewYear(Data.Locations.Length -1);
            tempFrmAddNewYear.ShowDialog();

            //resets the text boxes
            txtLocationName.Clear();
            txtStreet.Clear();
            txtCounty.Clear();
            txtPostcode.Clear();
            txtLatitude.Clear();
            txtLongitude.Clear();

        }
    }
}
