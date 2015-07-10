using Toci.Hornets.Bytom.Pr0fes0r.TrainingTwo.PeselValidator.Checsum;
using Toci.Hornets.Bytom.Pr0fes0r.TrainingTwo.PeselValidator.Date;

namespace Toci.Hornets.Bytom.Pr0fes0r.TrainingTwo.PeselValidator
{
    public class Pesel:GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        
        protected override string CutOffDate(string pesel)
        {
            DataExtractor data = new DataExtractor();
            var str = data.GetPesel(pesel);
            string nicedata = str.day + "-" + str.month%20 + "-" + str.year;
            return nicedata;



        }

        protected override bool Checksum(string pesel)
        {
            if (pesel.Length != 11)
            {
                return false;
            }
            else
            {
                Sum sum = new Sum();
                return (sum.Suma(pesel) % 10 == 0);
            }
            

        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            Days _day = new Days();
            return Years.Year(year) && Months.Month(month) && _day.Day(year, month, day);
        }

        public override bool IsPeselValid(string pesel)
        {
            DataExtractor dataExtractor = new DataExtractor();
            var nice = dataExtractor.GetPesel(pesel);
            CutOffDate(pesel);
            return Checksum(pesel) && ValidateDate(nice.year,nice.month,nice.day);

        }
        
        public override string GetNick()
        {
            return "Pr0fes0r";
        }

    }
}