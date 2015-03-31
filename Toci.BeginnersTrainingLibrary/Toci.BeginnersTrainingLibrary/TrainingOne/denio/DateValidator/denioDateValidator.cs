using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.denio.DateValidator
{
    public class DenioDateValidator : IDateValidator
    {

        public bool CheckDate(int year, int month, int day)
        {
            
            Day d = new Day();
            Month m = new Month();
            Year y = new Year();

            return d.ValidDay(day, month, year) && m.ValidMonth(month) && y.ValidYear(year);
        }

        public string GetNick()
        {
            return "denio";
        }
    }
}
