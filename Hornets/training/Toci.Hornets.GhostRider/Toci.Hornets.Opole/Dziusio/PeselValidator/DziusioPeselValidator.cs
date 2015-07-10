namespace Toci.Hornets.Opole.Dziusio.PeselValidator
{
    public class DziusioPeselValidator : Hornets.GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        public  DziusioDateValidator DateValidator = new DziusioDateValidator();

        protected override string CutOffDate(string pesel)
        {
            DateValidator.Date=pesel.Substring(0, 5);

            return DateValidator.Date;
        }

        protected override bool Checksum(string pesel)
        {
           var a= (1*pesel[0] + 3*pesel[1] + 7*pesel[2] + 9*pesel[3] + 1*pesel[4] + 3*pesel[5] + 7*pesel[6] + 9*pesel[7] + 1*pesel[8] + 3*pesel[9])%10;
            if (a == pesel[10])
            {
                return true;
            }
            else
            {
                return false;
            }


           
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            DateValidator.Date = year.ToString() + month.ToString() + day.ToString();
            if (DateValidator.TransformMonth() >= 1 && DateValidator.TransformMonth() <= 12 &&
                DateValidator.TransformYear() > 1800 && DateValidator.TransformYear() < 2300 &&
                DateValidator.ValidateDay())
            {
                return true;
            }
            else
            {
                return false;
            }
            

        }

        public override string GetNick()
        {
            return "Dziusio";
        }

        public override bool IsPeselValid(string pesel)
        {
            DateValidator.Date = CutOffDate(pesel);
            if (ValidateDate(DateValidator.GetYear(), DateValidator.TransformMonth(), DateValidator.GetDay()) ||
                Checksum(pesel))
            {
                return true;
            }

            return false;


        }
    }
}