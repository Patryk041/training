using System.Text.RegularExpressions;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.Interfaces;
using Toci.Hornets.Legnica.Patryk_Stulczewski.Utils;

namespace Toci.Hornets.Legnica.Patryk_Stulczewski.TrainingTwo.MyPeselValidator
{
    public class PatrykPeselValidator : PeselValidator
    {
        private IDateValidator _dateValidator;
        private IChecksumValidator _checksumValidator;
        private const int StartOfCheksum = 6;

        public PatrykPeselValidator() : this(new PeselDateValidator(), new ChecksumValidator())
        {  
        }

        public PatrykPeselValidator(IDateValidator dateValidator, IChecksumValidator checksumValidator)
        {
            _dateValidator = dateValidator;
            _checksumValidator = checksumValidator;
        }

        protected override string CutOffDate(string pesel)
        {
            return  pesel.Substring(0,StartOfCheksum);
        }

        protected override bool Checksum(string pesel)
        {
            return _checksumValidator.ValidateChecksum(pesel);
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            return _dateValidator.ValidateDate(year,month,day);
        }

        public override string GetNick()
        {
            return "Patryk Stulczewski";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (pesel == null || !(Regex.IsMatch(pesel, "^[0-9]{11}$")))
                return false;

            return ValidateDate(pesel.SubstringToInt(0, 2),
                                 pesel.SubstringToInt(2, 2),
                                 pesel.SubstringToInt(4, 2))
                    && Checksum(pesel);
        }
    }

}
