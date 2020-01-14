using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStations
{
    class Location
    {
        //class members
        private string locationName;
        private string streetNumberAndName;
        private string county;
        private string postcode;
        private double latitude;
        private double longitude;
        private Year[] years;

        //constructors
        public Location(string inLocationName, string inStreetNumAndName, string inCounty, 
            string inPostcode, double inLatitude, double inLongitude, Year[] inYears)
        {
            locationName = inLocationName;
            streetNumberAndName = inStreetNumAndName;
            county = inCounty;
            postcode = inPostcode;
            latitude = inLatitude;
            longitude = inLongitude;
            years = inYears;
        }
        public Location()
        {
            locationName = null;
            streetNumberAndName = null;
            county = null;
            postcode = null;
            latitude = 0;
            longitude = 0;
            years = new Year[0];
        }
        //all the setters
        public void SetLocationName(string inName)
        {
            locationName = inName;
        }

        public void SetStreetNumberAndName(string inStreetName)
        {
            streetNumberAndName = inStreetName;
        }
        public void SetCounty(string inStreetCounty)
        {
            county = inStreetCounty;
        }
        public void SetPostcode(string inPostcode)
        {
            postcode = inPostcode;
        }
        public void SetLatitude(double inLatitude)
        {
            latitude = inLatitude;
        }
        public void SetLongitude(double inLongitude)
        {
            longitude = inLongitude;
        }
        public void SetYears(Year[] inYears)
        {
            years = inYears;
        }

        //all the getters
        public string GetLocationName()
        {
            return locationName;
        }
        public string GetStreetNumberAndName()
        {
            return streetNumberAndName;
        }
        public string GetCounty()
        {
            return county;
        }
        public string GetPostcode()
        {
            return postcode;
        }
        public double GetLatitude()
        {
            return latitude;
        }
        public double GetLongitude()
        {
            return longitude;
        }
        public Year[] GetYears()
        {
            return years;
        }
        public void AddNewYear(int locationRef, Year inNewYear)
        {  
            //resizes the years array and adds the new year
            int numOfYears = Data.Locations[locationRef].GetYears().Length + 1;
            Array.Resize(ref years, numOfYears);
            Data.Locations[locationRef].GetYears()[numOfYears - 1] = new Year();
            Data.Locations[locationRef].GetYears()[numOfYears - 1].SetYear(inNewYear.GetYear());
            Data.Locations[locationRef].GetYears()[numOfYears - 1].SetYearDescription(inNewYear.GetYearDescription());
            Data.Locations[locationRef].GetYears()[numOfYears - 1].SetMonthlyObservations(inNewYear.GetMonthlyObservations());
        }
      
    }
}
