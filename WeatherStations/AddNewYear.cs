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
    public partial class frmAddNewYear : Form
    {
        int locationRef;
        public frmAddNewYear(int inLocationRef)
        {
            InitializeComponent();
            //save a reference to the selected location
            locationRef = inLocationRef;
            //calls the form to set up the datagrid ready for new monthly observations to be input
            SetUpMonthlyObservations();
        }
        //sets up the datagrid to display all of the 12 months with null values
        public void SetUpMonthlyObservations()
        {
            //adds 12 blank rows
            dgdMonthlyObservations.Rows.Add(12);
            for (int m = 0; m < 12; m++)
            {
                //sets up all of the monthid's
                dgdMonthlyObservations.Rows[m].Cells[0].Value = m+1;
               
            }
        }

        private void frmAddNewYear_Load(object sender, EventArgs e)
        {

        }

        private void dgdMonthlyObservationsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveNewYear();
        }
        //saves all of the data input into the form
        public void SaveNewYear()
        {
            //creates a place to store data temporarily
            Year tempYear = new Year();
            MonthlyObservations[] tempMonthlyObservations = new MonthlyObservations[12];
            //loops through all of the 12 rows storing the data in the temporary objects
            for (int month = 0; month < 12; month++)
            {
                tempMonthlyObservations[month] = new MonthlyObservations();
                try
                {
                    tempYear.SetYear(Convert.ToInt32(txtYear.Text));
                    tempMonthlyObservations[month].SetMonthIdNumber(Convert.ToInt32(dgdMonthlyObservations.Rows[month].Cells[0].Value));
                    tempMonthlyObservations[month].SetMaxTemp(Convert.ToDouble(dgdMonthlyObservations.Rows[month].Cells[1].Value));
                    tempMonthlyObservations[month].SetMinTemp(Convert.ToDouble(dgdMonthlyObservations.Rows[month].Cells[2].Value));
                    tempMonthlyObservations[month].SetNumOfAirFrostDays(Convert.ToInt32(dgdMonthlyObservations.Rows[month].Cells[3].Value));
                    tempMonthlyObservations[month].SetMillimetresRainfall(Convert.ToDouble(dgdMonthlyObservations.Rows[month].Cells[4].Value));
                    tempMonthlyObservations[month].SetHoursOfSunshine(Convert.ToDouble(dgdMonthlyObservations.Rows[month].Cells[5].Value));
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show(string.Format("Error: {0} \nPlease make sure the inputs are valid.", e.Message));
                    return;
                }
                
            }
            //if nothing is stored in the year desc then it will store a message of no desc available
            if ( txtYearDesc.Text != "" )
            {
                tempYear.SetYearDescription(txtYearDesc.Text);
            }
            else
            {
                tempYear.SetYearDescription("no description available");
            }
            //store the temp monthly observations in the temp year
            tempYear.SetMonthlyObservations(tempMonthlyObservations);

            //stores the data in the locations object
            Data.Locations[locationRef].AddNewYear(locationRef, tempYear);
            MessageBox.Show("New year saved");

            //resets the page
            dgdMonthlyObservations.Rows.Clear();
            txtYear.Clear();
            txtYearDesc.Clear();
            SetUpMonthlyObservations();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddNewYear_FormClosing(object sender, FormClosingEventArgs e)
        {
            //checks that the location has at least one year in it if not it cancels the close
            //this is mainly of when they add a new location they need to have one year
            if (Data.Locations[locationRef].GetYears().Length == 0)
            {
                MessageBox.Show("Please add at least one year");
                e.Cancel = true;
            }
        }
    }
}
