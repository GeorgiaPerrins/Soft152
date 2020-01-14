using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStations
{
    class MonthlyObservations
    {
        //class members
        private int monthID;
        private double maxTemp;
        private double minTemp;
        private int numOfAirFrostDays;
        private double mmsOfRainfall;
        private double hoursOfSunshine;
        
        
        //constructors
        public MonthlyObservations(int inMonthIdNumber, double inMaximumTemperature, double inMinimumTemperature,
            int inNumberOfDayWithAirFrost, double inMillimetresOfRainfall, double inHoursOfSunshine)
        {
            monthID = inMonthIdNumber;
            maxTemp = inMaximumTemperature;
            minTemp = inMinimumTemperature;
            numOfAirFrostDays = inNumberOfDayWithAirFrost;
            mmsOfRainfall = inMillimetresOfRainfall;
            hoursOfSunshine = inHoursOfSunshine;
        }
        public MonthlyObservations()
        {
            monthID = 0;
            maxTemp = 0;
            minTemp = 0;
            numOfAirFrostDays = 0;
            mmsOfRainfall = 0;
            hoursOfSunshine = 0;
        }

        //all the setters
        public void SetMonthIdNumber(int inMonthIdNumber)
        {
            monthID = inMonthIdNumber;
        }
        public void SetMaxTemp(double inMaxTemp)
        {
            maxTemp = inMaxTemp;
        }
        public void SetMinTemp(double inMinTemp)
        {
            minTemp = inMinTemp;
        }
        public void SetNumOfAirFrostDays(int inNumAirFrostDays)
        {
            numOfAirFrostDays =inNumAirFrostDays;
        }
        public void SetMillimetresRainfall(double inMmsOfRainfall)
        {
            mmsOfRainfall = inMmsOfRainfall;
        }
        public void SetHoursOfSunshine(double inHoursOfSunshine)
        {
            hoursOfSunshine = inHoursOfSunshine;
        }

        //all the getters
        public int GetMonthId()
        {
            return monthID;
        }
        public double GetMaxTemp()
        {
            return maxTemp;
        }
        public double GetMinTemp()
        {
            return minTemp;
        }
        public int GetNumAirFrostDays()
        {
            return numOfAirFrostDays;
        }
        public double GetMmsOfRainfall()
        {
            return mmsOfRainfall;
        }
        public double GetHoursOfSunshine()
        {
            return hoursOfSunshine;
        }

    }
}
