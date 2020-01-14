using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStations
{
    class Year
    {
        //class members
        private int year;
        private string yearDescription;
        private MonthlyObservations[] monthlyObservations = new MonthlyObservations[12];

        //constructors
        public Year(int inYear, string inYearDescription, MonthlyObservations[] inMonthlyObservations)
        {
            year = inYear;
            yearDescription = inYearDescription;
            monthlyObservations = inMonthlyObservations;
        }
        public Year(int inYear, MonthlyObservations[] inMonthlyObservations)
        {
            year = inYear;
            yearDescription = "no description available";
            monthlyObservations = inMonthlyObservations;
        }
        public Year()
        {
            year = 0;
            yearDescription = null;
            monthlyObservations = null;
        }
        //all the setters
        public void SetYear(int inYear)
        {
            year = inYear;
        }
        public void SetYearDescription(string inYearDescription)
        {
            yearDescription = inYearDescription;
        }
        public void SetMonthlyObservations(MonthlyObservations[] inMonthlyObservations)
        {
            monthlyObservations = inMonthlyObservations;
        }
        //all the getters
        public int GetYear()
        {
            return year;
        }
        public string GetYearDescription()
        {
            return yearDescription;
        }
        public MonthlyObservations[] GetMonthlyObservations()
        {
            return monthlyObservations;
        }
       
    }
}
