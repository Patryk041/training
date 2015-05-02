using Toci.BeginnersTrainingLibrary.TrainingOne.Rubi.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Rubi
{
    public class MonthValidation:IMonthValidation
    {
        private const int MinMonthIndex = 0;
        private const int MaxMonthIndex = 12;

        public bool ValidMonth(int month)
        {
            return month>MinMonthIndex && month<=MaxMonthIndex;
        }


        public bool CheckMonth(int month)
        {
            return month%2==0 && month!=2;
        }

        public bool CheckFebruary(int month)
        {
            return month == 2; 
        }
    }
}
