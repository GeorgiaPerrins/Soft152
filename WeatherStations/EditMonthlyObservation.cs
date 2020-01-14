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
    public partial class frmEditMonthlyObservation : Form
    {
        int locationRef, yearRef, monthRef;
        MonthlyObservations selectedMonth;
        public frmEditMonthlyObservation(int inLocationRef, int inYearRef, int inMonthRef)
        {
            InitializeComponent();
            //stores the references to the selected indexs in the main form
            locationRef = inLocationRef;
            yearRef = inYearRef;
            monthRef = inMonthRef;
            //stores the relevant month in a temporary array
            selectedMonth = Data.Locations[locationRef].GetYears()[yearRef].GetMonthlyObservations()[monthRef];
            //goes to a method that inputs the data to the text boxes
            LoadInData();
        }
        public void LoadInData()
        {
            //reads the data from the array and adds it to the correct text boxes
            txtMonthId.Text = selectedMonth.GetMonthId().ToString();
            txtMaxTemp.Text = selectedMonth.GetMaxTemp().ToString();
            txtMinTemp.Text = selectedMonth.GetMinTemp().ToString();
            txtNumOfAirFrost.Text = selectedMonth.GetNumAirFrostDays().ToString();
            txtMmsOfRainfall.Text = selectedMonth.GetMmsOfRainfall().ToString();
            txtHoursOfSunshine.Text = selectedMonth.GetHoursOfSunshine().ToString();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            //closes this form
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //calls the save method
            SaveObservations();
        }
        public void SaveObservations()
        {
            //trys to set the value in the array and if they have incorrect data types it displays a message
            try
            {
                selectedMonth.SetMaxTemp(Convert.ToDouble(txtMaxTemp.Text));
            }
            catch (Exception E)
            {
                MessageBox.Show(string.Format("Error: {0} \nPlease enter a valid number for maximum temperature.", E.Message));
            }
            try
            {
                selectedMonth.SetMinTemp(Convert.ToDouble(txtMinTemp.Text));
            }
            catch (Exception E)
            {
                MessageBox.Show(string.Format("Error: {0} \nPlease enter a valid number for minimum temperature.", E.Message));
            }
            try
            {
                selectedMonth.SetNumOfAirFrostDays(Convert.ToInt32(txtNumOfAirFrost.Text));
            }
            catch (Exception E)
            {
                MessageBox.Show(string.Format("Error: {0} \nPlease enter a valid number for number of air frost days.", E.Message));
            }
            try
            {
                selectedMonth.SetMillimetresRainfall(Convert.ToDouble(txtMmsOfRainfall.Text));
            }
            catch (Exception E)
            {
                MessageBox.Show(string.Format("Error: {0} \nPlease enter a valid number for millimetres of rainfall.", E.Message));
            }
            try
            {
                selectedMonth.SetHoursOfSunshine(Convert.ToDouble(txtHoursOfSunshine.Text));

            }
            catch (Exception E)
            {
                MessageBox.Show(string.Format("Error: {0} \nPlease enter a valid number for the hours of sunshine.", E.Message));
            }
            MessageBox.Show("Data has been updated if it was valid.");
        }
    }
}
