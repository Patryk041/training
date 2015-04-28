using Toci.BeginnersTrainingLibrary.TrainingOne.Rubi.Interfaces;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Rubi
{
    public class YearValidation:IYearValidation
    {

        private const int MinYear = 0;
        public bool ValidYear(int year)
        {
            return year > MinYear;
        }


        public bool ValidLeapsed(int year)
        {
            return year % 4 == 0 ? true : false;
        }
    }
}
