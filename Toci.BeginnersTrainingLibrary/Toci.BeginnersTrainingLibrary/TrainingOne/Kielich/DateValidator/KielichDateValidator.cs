namespace Toci.BeginnersTrainingLibrary.TrainingOne.Kielich.DateValidator
{
    public class KielichDateValidator : Excercise.IDateValidator
    {
        public bool CheckDate(int year, int month, int day)
        {
            Validator vali = new Validator();
            return vali.Validation(year, month, day);
        }

        public string GetNick()
        {
            return "Kielich";
        }
    }
}
