using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WeatherStations
{
    public partial class frmWeatherStations : Form
    {
        public frmWeatherStations()
        {
            InitializeComponent();
            ReadInData();
            FillLocations();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void FillMonths()
        {
            MonthlyObservations[] tempMonths;
            //clears the months already in the list box
            lstMonths.Items.Clear();
            //stores a temporary array of the monthly observations for the year
            tempMonths = Data.Locations[lstLocationNames.SelectedIndex].GetYears()[lstYears.SelectedIndex].GetMonthlyObservations();
            //displays all of the monthly obseravtions in the list box
            for (int i = 0; i < 12; i++)
            {
                lstMonths.Items.Add(tempMonths[i].GetMonthId().ToString());
            }
            //selects the top item in the list box
            lstMonths.SetSelected(0, true);
        }

        public void LoadObseravations()
        {
            //adds all of the info to the observations list box
            lstObservations.Items.Clear();
            MonthlyObservations tempMonth = Data.Locations[lstLocationNames.SelectedIndex].GetYears()[lstYears.SelectedIndex].GetMonthlyObservations()[lstMonths.SelectedIndex];
            lstObservations.Items.Add("MonthID; " + tempMonth.GetMonthId().ToString());
            lstObservations.Items.Add("MaxTemp: " + tempMonth.GetMaxTemp().ToString());
            lstObservations.Items.Add("MinTemp: " + tempMonth.GetMinTemp().ToString());
            lstObservations.Items.Add("Number Of Days Of Air Frost: " + tempMonth.GetNumAirFrostDays().ToString());
            lstObservations.Items.Add("Millimetres Of Rainfall: " + tempMonth.GetMmsOfRainfall().ToString());
            lstObservations.Items.Add("Hours Of Sunshine: " + tempMonth.GetHoursOfSunshine().ToString());
        }

        public void FillYears()
        {
            int numOfYears = Data.Locations[lstLocationNames.SelectedIndex].GetYears().Length;
            string yearDetails;
            Year[] tempYears;
            //clears the years list box
            lstYears.Items.Clear();

            //displays the years in the list box
            for (int i = 0; i < numOfYears ; i++)
            {
                tempYears = Data.Locations[lstLocationNames.SelectedIndex].GetYears();
                yearDetails = string.Format("{0}: {1}", tempYears[i].GetYear(), tempYears[i].GetYearDescription());
                lstYears.Items.Add(yearDetails);
            }
            lstYears.SetSelected(0, true);
            //calls the fill months method that fills in the monthly observations list box
            FillMonths();
        }

        public void FillLocations()
        {
            //clears the list box
            lstLocationNames.Items.Clear();
            //displays the locations in the list boxs 
            for (int i = 0; i < Data.Locations.Length; i++)
            {
                lstLocationNames.Items.Add(Data.Locations[i].GetLocationName());
            }
            //selects the top item in the list box
            lstLocationNames.SetSelected(0, true);

            //calls the fill years method that fill in the years list box
            FillYears();
        }

        public void LoadLocationDetails()
        {
            //clears and adds all of the details to the location info list box
            lstLocationInfo.Items.Clear();
            lstLocationInfo.Items.Add(Data.Locations[lstLocationNames.SelectedIndex].GetLocationName());
            lstLocationInfo.Items.Add(Data.Locations[lstLocationNames.SelectedIndex].GetStreetNumberAndName());
            lstLocationInfo.Items.Add(Data.Locations[lstLocationNames.SelectedIndex].GetCounty());
            lstLocationInfo.Items.Add(Data.Locations[lstLocationNames.SelectedIndex].GetPostcode());
            lstLocationInfo.Items.Add("Latitude: " + Data.Locations[lstLocationNames.SelectedIndex].GetLatitude());
            lstLocationInfo.Items.Add("Longitude: " + Data.Locations[lstLocationNames.SelectedIndex].GetLongitude());
        }
        
        //Reads in the data from the file
        public void ReadInData()
        {
            int numOfYears, numOfLocations;
            
            Location tempLocation;
            Year[] tempYears =null ;
            MonthlyObservations[] tempMonthlyObservations =null ;
            
            StreamReader readInputs = new StreamReader("inputExtended.txt");
            
            //read the number of locations in the file
            numOfLocations = Convert.ToInt32(readInputs.ReadLine());

            //Read the locations data and set it in a temporary object
            for (int l = 0; l < numOfLocations; l++)
            { 
                tempLocation = new Location();
                tempLocation.SetLocationName(readInputs.ReadLine());
                tempLocation.SetStreetNumberAndName(readInputs.ReadLine());
                tempLocation.SetCounty(readInputs.ReadLine());
                tempLocation.SetPostcode(readInputs.ReadLine());
                tempLocation.SetLatitude(Convert.ToDouble(readInputs.ReadLine()));
                tempLocation.SetLongitude(Convert.ToDouble(readInputs.ReadLine()));
                numOfYears = Convert.ToInt32(readInputs.ReadLine());

                //Read the years for the locations and set it in a temporary object
                tempYears = new Year[numOfYears];
                for (int y = 0; y <numOfYears; y++)
                {
                    tempYears[y] = new Year();
                    tempYears[y].SetYearDescription(readInputs.ReadLine());
                    
                    //Read the monthly observations for the years and set it in a temporary object
                    tempMonthlyObservations = new MonthlyObservations[12];
                    for (int m = 0; m < 12; m++)
                    {
                        tempYears[y].SetYear(Convert.ToInt32(readInputs.ReadLine()));
                        tempMonthlyObservations[m] = new MonthlyObservations();
                        tempMonthlyObservations[m].SetMonthIdNumber(Convert.ToInt32(readInputs.ReadLine()));
                        tempMonthlyObservations[m].SetMaxTemp(Convert.ToDouble(readInputs.ReadLine()));
                        tempMonthlyObservations[m].SetMinTemp(Convert.ToDouble(readInputs.ReadLine()));
                        tempMonthlyObservations[m].SetNumOfAirFrostDays(Convert.ToInt32(readInputs.ReadLine()));
                        tempMonthlyObservations[m].SetMillimetresRainfall(Convert.ToDouble(readInputs.ReadLine()));
                        tempMonthlyObservations[m].SetHoursOfSunshine(Convert.ToDouble(readInputs.ReadLine()));
                    }
                    //stores the monthly observations in the temp years object
                    tempYears[y].SetMonthlyObservations(tempMonthlyObservations);
                }
                //stores stores the years in the temp locations object
                tempLocation.SetYears(tempYears);
                //store all of the information in the array
                Array.Resize(ref Data.Locations, l + 1);
                Data.Locations[l] = tempLocation;
            }
            //closes the stream reader
            readInputs.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string locationSearch;
            bool found = false;
            //stores the input in a variable
            locationSearch = txtSearchLocation.Text;
            //searches for the input in the locations
            for (int i = 0; i < Data.Locations.Length; i++)
            {
                //compares the input name to the stored name
                if (locationSearch.ToUpper() == Data.Locations[i].GetLocationName().ToUpper())
                {
                    //selects the value input into the search if a match is found
                    lstLocationNames.SetSelected(i, true);
                    found = true;
                }
            }
            //if an item is not found it displays a message
            if (found == false)
            {
                MessageBox.Show("Invalid input. Location was not found.");
            }
        }

        private void btnEditLocation_Click(object sender, EventArgs e)
        {
            //hides this form and opens the edit location form
            frmEditLocation tempEditLocation = new frmEditLocation(lstLocationNames.SelectedIndex);
            tempEditLocation.ShowDialog();
            //saves the data to the file
            SaveToFile();
            FillLocations();
        }

        private void lstLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when someone selects a new item in the locations list box it calls to change the years list box
            FillYears();
            LoadLocationDetails();
        }

        private void lstYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when someone selects a new item in the years list box it calls to change the monthly observations list box
            FillMonths();
        }

        private void btnSearchYear_Click(object sender, EventArgs e)
        {
            //sets varaibles
            bool found = false;
            int y = 0; ;
            //stores the search string 
            string yearSearch = txtSearchYear.Text;
            do
            {
                //compares the input with the year 
                if (yearSearch == Data.Locations[lstLocationNames.SelectedIndex].GetYears()[y].GetYear().ToString())
                {
                    found = true;
                    lstYears.SetSelected(y, true);
                }
                y = y + 1;
                //if it is found and if it has reached the end of the array the loop terminates
            } while ((found == false) && (y != Data.Locations[lstLocationNames.SelectedIndex].GetYears().Length));
            //if the result was not found a message box is shown 
            if (found == false)
            {
                MessageBox.Show("Input invalid. No year found.");
            }
        }

        private void btnEditYearDesc_Click(object sender, EventArgs e)
        {
            //creates an instance of a new edit description form
            frmEditYearDescription tempEditYearDesc = new frmEditYearDescription(lstLocationNames.SelectedIndex, lstYears.SelectedIndex);
            tempEditYearDesc.ShowDialog();
            //saves the data to the file
            SaveToFile();
            //updates the list boxes
            FillYears();
        }

        private void btnAddNewYear_Click(object sender, EventArgs e)
        {
            //creates an instance of the add year form
            frmAddNewYear tempAddYear = new frmAddNewYear(lstLocationNames.SelectedIndex);
            tempAddYear.ShowDialog();
            //saves the data to the file
            SaveToFile();
            //updates the list boxes
            FillYears();
        }

        private void lstMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            //when someone selects a new item in the months list box this gets called to change the observation list box
            LoadObseravations();
        }

        private void btnEditMonthlyObservation_Click(object sender, EventArgs e)
        {
            //creates an instance of the form edit observations 
            frmEditMonthlyObservation tempEditObservation = new frmEditMonthlyObservation(lstLocationNames.SelectedIndex, lstYears.SelectedIndex, lstMonths.SelectedIndex);
            tempEditObservation.ShowDialog();
            //saves the data to the file
            SaveToFile();
            //reloads the data in for the observations
            LoadObseravations();
        }

        private void btnSubmitAnalysis_Click(object sender, EventArgs e)
        {
            //refreshes the page so the graph updates
            Refresh();
        }

        private void pnlGraph_Paint(object sender, PaintEventArgs e)
        {
            Year tempYear = Data.Locations[lstLocationNames.SelectedIndex].GetYears()[lstYears.SelectedIndex];
            float[] barHeights = new float[12] ;
            int  months = 12, start = 5, barWidth = 20; float xAxis, totalValue = 0;

            //finds out which radio button is selected and sets the bar height for them
            if (radYearMaxTemp.Checked == true)
            //loops through all of the months and saves the bar heights in an array 
            {for (int i = 0; i < months; i++)
                { barHeights[i] = Convert.ToSingle(tempYear.GetMonthlyObservations()[i].GetMaxTemp()); }
            }
            //does this for the next several radio buttons
            if (radYearMinTemp.Checked == true)
            {
                for (int i = 0; i < months; i++)
                { barHeights[i] = Convert.ToSingle(tempYear.GetMonthlyObservations()[i].GetMinTemp()) ; }
            }
            if (radYearNumAirFrost.Checked == true)
            {
                for (int i = 0; i < months; i++)
                { barHeights[i] = Convert.ToSingle(tempYear.GetMonthlyObservations()[i].GetNumAirFrostDays()) ; }
            }
            if (radYearMmsRainfall.Checked == true)
            {
                for (int i = 0; i < months; i++)
                { barHeights[i] = Convert.ToSingle(tempYear.GetMonthlyObservations()[i].GetMmsOfRainfall()) ; }
            }
            if (radYearHoursSunshine.Checked == true)
            {
                for (int i = 0; i < months; i++)
                { barHeights[i] = Convert.ToSingle(tempYear.GetMonthlyObservations()[i].GetHoursOfSunshine()) ; }
            }
            if (radLocMaxTemp.Checked == true)
            {
                //loops through all of the months and years calculating the average for each month
                for (int m = 0; m < months; m++)
                {
                    //resets the total value to 0
                    totalValue = 0;
                    //calculates the average
                    for (int y = 0; y < Data.Locations[lstLocationNames.SelectedIndex].GetYears().Length; y++)
                    {
                        totalValue = totalValue + Convert.ToSingle(Data.Locations[lstLocationNames.SelectedIndex].GetYears()[y].GetMonthlyObservations()[m].GetMaxTemp());
                    }
                    //stores the average in the bar height array
                    barHeights[m] = (totalValue / Data.Locations[lstLocationNames.SelectedIndex].GetYears().Length) ;
                }
            }
            //does this for the next serveral radio buttons

            if (radLocMinTemp.Checked == true)
            {
                for (int m = 0; m < months; m++)
                {
                    totalValue = 0;
                    for (int y = 0; y < Data.Locations[lstLocationNames.SelectedIndex].GetYears().Length; y++)
                    {
                        totalValue = totalValue + Convert.ToSingle(Data.Locations[lstLocationNames.SelectedIndex].GetYears()[y].GetMonthlyObservations()[m].GetMinTemp());
                    }
                    barHeights[m] = (totalValue / Data.Locations[lstLocationNames.SelectedIndex].GetYears().Length) ;
                }
            }
            if (radLocNumAirFrost.Checked == true)
            {
                for (int m = 0; m < months; m++)
                {
                    totalValue = 0;
                    for (int y = 0; y < Data.Locations[lstLocationNames.SelectedIndex].GetYears().Length; y++)
                    {
                        totalValue = totalValue + Convert.ToSingle(Data.Locations[lstLocationNames.SelectedIndex].GetYears()[y].GetMonthlyObservations()[m].GetNumAirFrostDays());
                    }
                    barHeights[m] = (totalValue / Data.Locations[lstLocationNames.SelectedIndex].GetYears().Length);
                }
            }
            if (radLocMmsRainfall.Checked == true)
            {
                for (int m = 0; m < months; m++)
                {
                    totalValue = 0;
                    for (int y = 0; y < Data.Locations[lstLocationNames.SelectedIndex].GetYears().Length; y++)
                    {
                        totalValue = totalValue + Convert.ToSingle(Data.Locations[lstLocationNames.SelectedIndex].GetYears()[y].GetMonthlyObservations()[m].GetMmsOfRainfall());
                    }
                    barHeights[m] = (totalValue / Data.Locations[lstLocationNames.SelectedIndex].GetYears().Length) ;
                }
            }
            if (radLocHoursSunshine.Checked == true)
            {
                for (int m = 0; m < months; m++)
                {
                    totalValue = 0;
                    for (int y = 0; y < Data.Locations[lstLocationNames.SelectedIndex].GetYears().Length; y++)
                    {
                        totalValue = totalValue + Convert.ToSingle(Data.Locations[lstLocationNames.SelectedIndex].GetYears()[y].GetMonthlyObservations()[m].GetHoursOfSunshine());
                    }
                    barHeights[m] = (totalValue / Data.Locations[lstLocationNames.SelectedIndex].GetYears().Length) ;
                }
            }
            //uses graphics to paint the graph
            using (Graphics graph = pnlGraph.CreateGraphics())
            using (Pen pen = new Pen(Color.Gray, 2)) //creates the pen to use
            {
                //draws the x and y axis
                graph.DrawLine(pen, 1, 230, 350, 230); 
                graph.DrawLine(pen, 1, 1, 1, 230);
                
                for (int i = 0; i < months; i++)
                {
                    xAxis = 230f;
                    //caculates where it needs to draw the bar down from
                    xAxis = xAxis - barHeights[i];
                    
                    //draws the bars
                    graph.DrawRectangle(pen, start, xAxis, barWidth, barHeights[i]);  
                    using (Font labels = new Font("Microsoft Sans Serif", 6))
                    {
                        //writes the values of the bars                                              //so its in the middle of the bar and slightly above it
                        graph.DrawString(string.Format("{0:00}", (barHeights[i])), labels, Brushes.Black, start + 5, xAxis - 10);
                        //writes the months under the bars    //so that it is slightly below the xaxis
                        graph.DrawString((i+1).ToString(), labels, Brushes.Black, start + 5, 235f); 
                    }
                    //states where the start of the bar 
                    start = start + 25;
                }
            }

           

        }
        public void SaveToFile()
        {
            //opens the stream writer to write the data to the files
            StreamWriter saveFile = new StreamWriter("inputExtended.txt");
            Year tempYear;
            MonthlyObservations tempMonth;

            //saves the number of locations to the file
            saveFile.WriteLine(Data.Locations.Length);
            for (int l = 0; l < Data.Locations.Length; l++)
            {
                //saves all of the locations information to the file
                saveFile.WriteLine(Data.Locations[l].GetLocationName());
                saveFile.WriteLine(Data.Locations[l].GetStreetNumberAndName());
                saveFile.WriteLine(Data.Locations[l].GetCounty());
                saveFile.WriteLine(Data.Locations[l].GetPostcode());
                saveFile.WriteLine(Data.Locations[l].GetLatitude());
                saveFile.WriteLine(Data.Locations[l].GetLongitude());
                saveFile.WriteLine(Data.Locations[l].GetYears().Length);
                
                //saves the number of years in the location to the file
                for (int y = 0; y < Data.Locations[l].GetYears().Length; y++)
                {
                    tempYear = Data.Locations[l].GetYears()[y];
                    //saves the year data to the file
                    saveFile.WriteLine(tempYear.GetYearDescription());

                    for (int m = 0; m < 12; m++)
                    {
                        tempMonth = Data.Locations[l].GetYears()[y].GetMonthlyObservations()[m];
                        saveFile.WriteLine(tempYear.GetYear());
                        //saves the monthly observations to the file
                        saveFile.WriteLine(tempMonth.GetMonthId());
                        saveFile.WriteLine(tempMonth.GetMaxTemp());
                        saveFile.WriteLine(tempMonth.GetMinTemp());
                        saveFile.WriteLine(tempMonth.GetNumAirFrostDays());
                        saveFile.WriteLine(tempMonth.GetMmsOfRainfall());
                        saveFile.WriteLine(tempMonth.GetHoursOfSunshine());
                    }
                }
            }
            //closes the stream reader
            saveFile.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmWeatherStations_FormClosing(object sender, FormClosingEventArgs e)
        {
            //show a message box to confirm the close of the application
            var result = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSearchMonth_Click(object sender, EventArgs e)
        {
            MonthlyObservations tempMonth;
            bool found = false;
            //searches for the month in the month array
            for (int m = 0; m < 12; m++)
            {
                //sets the month in a temporaty array
                tempMonth = Data.Locations[lstLocationNames.SelectedIndex].GetYears()[lstYears.SelectedIndex].GetMonthlyObservations()[m];
                if (tempMonth.GetMonthId().ToString() == txtMonthNum.Text)
                {
                    //matches the input with the number, if found sets the found variable and highlights in the list box
                    lstMonths.SetSelected(m, true);
                    found = true;
                }
                if (found == false)
                {
                    MessageBox.Show("Input invalid. Month could not be found.");
                }
            }
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            //Hides this form and opens the add location form
            frmAddLocation tempAddLocation = new frmAddLocation();
            tempAddLocation.ShowDialog();
            //saves the data to the file
            SaveToFile();
            //updates the list boxes
            FillLocations();
        }
    }
}
