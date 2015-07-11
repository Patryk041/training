using System;

namespace Toci.Hornets.Gliwice.MoWerr.PeselValidator
{
    public class MoWerrPeselValidator : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            return pesel.Remove(6);
        }

        protected override bool Checksum(string pesel)
        {
            var peselCharArray = pesel.ToCharArray();
            var peselArray = Array.ConvertAll(peselCharArray, c => (int)char.GetNumericValue(c));

            var sum = peselArray[0] + 3*peselArray[1] + 7*peselArray[2] + 9*peselArray[3] +
                      peselArray[4] + 3*peselArray[5] + 7*peselArray[6] + 9*peselArray[7] +
                      peselArray[8] + 3*peselArray[9] +
                      peselArray[10];

            var control = sum%10;

            return control == 0;
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            return MoWerrPeselDateValidator.IsDateValid(year, month, day);
        }

        public override string GetNick()
        {
            return "MoWerr";
        }

        public override bool IsPeselValid(string pesel)
        {
            int year, month, day;
            SeparateDate(CutOffDate(pesel), out year, out month, out day);

            return Checksum(pesel) && ValidateDate(year, month, day);
        }

        protected void SeparateDate(string date, out int year, out int month, out int day)
        {
            year = int.Parse(date.Remove(2, 4));
            month = int.Parse(date.Remove(0, 2).Remove(2,2));
            day = int.Parse(date.Remove(0, 4));
        }
    }
}