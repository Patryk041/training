using Toci.Hornets.Legnica.Amman.PeselValidator.Workers.DateValidation;

namespace Toci.Hornets.Legnica.Amman.PeselValidator.Workers
{
    public class PeselValidatorWorker
    {
        static public bool IsValid(string psl)
        {
            return ChksumValidator.Check(psl) && DateValidator.IsValid(DayValidator.GetDay(psl),MonthValidator.GetMonth(psl),YearValidator.GetYear(psl));
        }
    }
}