using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using InitialTrainingLibrary.Interfaces;

namespace InitialTrainingLibrary.Sito._1
{
    public class DateValidator:IDateValidator
    {
        private List<IDatePartValidator> partsValidators = new List<IDatePartValidator>();
        private Dictionary<List<int>, Func<int,int, bool>> monthsValidateDictionary = new Dictionary<List<int>, Func<int,int,bool>>();
        private Dictionary<int, Func<int, int, bool>> test = new Dictionary<int, Func<int, int, bool>>();
        public DateValidator()
        {        
            test.Add(1,(x,y)=>x==5);
            monthsValidateDictionary.Add(new List<int>() {2}, (d, y) =>
            {
                if (IsLeapYear(y))
                        return d > 0 && d < 30;
                    else
                        return d > 0 && d < 29;
            });
            monthsValidateDictionary.Add(new List<int>() { 1, 3, 5, 7, 8,10,12 }, (d,y) => d >0 && d<32);
            monthsValidateDictionary.Add(new List<int>() { 4,6,9,11 }, (d, y) => d > 0 && d < 31);
        }
        public bool DateValidate(int year, int month, int day)
        {
            partsValidators.Clear();
            partsValidators.Add(new MonthValidator(month));
            partsValidators.Add(new YearValidator(year));
            if (partsValidators.All(x=>x.ValidatePart()))
            {
                var key = monthsValidateDictionary.Keys.FirstOrDefault(x => x.Contains(month));
                
                return monthsValidateDictionary[key].Invoke(day, year);
            }
            
            return false;
        }

        public bool IsLeapYear(int year)
        {
            return ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0);
        }
        public string GetName()
        {
            return "Sito";
        }
    }
}
