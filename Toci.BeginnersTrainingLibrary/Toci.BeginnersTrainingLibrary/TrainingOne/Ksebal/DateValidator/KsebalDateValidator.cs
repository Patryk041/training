using Toci.BeginnersTrainingLibrary.TrainingOne.Excercise;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Ksebal.DateValidator

{
    public class KsebalDateValidator : IDateValidator
    {
      


        public bool CheckDate(int year, int month, int day)
        {   
            return ValidatorStaticClass.ValidateDate(year, month, day);
        }

        public string GetNick()
        {
            return "Ksebal";
        }
    }
}