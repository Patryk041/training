using System;

namespace Toci.Hornets.Bytom.Coffee13.TaskTrainingTwo.PeselValidator
{
    public class CoffeePeselValidator : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            var date = pesel.Substring(0, 6);
            return date;
        }

        protected override bool Checksum(string pesel)
        {
            int[] weight = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sum = 0;

            for (var i = 0; i < 10; i++)
            {
                sum += Convert.ToInt32(pesel.Substring(i, 1)) * weight[i];
            }

            sum %= 10;
            sum = 10 - sum;
            sum %= 10;

            return Convert.ToString(sum) == pesel.Substring(10, 1);
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            if (year > 0)
            {
                if (month > 0 && month < 13)
                {
                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    {
                        if (day > 0 && day < 32)
                        {
                            return true;
                        }
                        return false;
                    }
                    if (month == 4 || month == 6 || month == 9 || month == 11)
                    {
                        if (day > 0 && day < 31)
                        {
                            return true;
                        }
                        return false;
                    }
                    if (month == 2)
                    {
                        if (year % 4 == 0 || year % 100 == 0)
                        {
                            if (day > 0 && day < 30)
                            {
                                return true;
                            }

                            if (day > 0 || day < 29)
                            {
                                return true;
                            }
                            return false;
                        }
                    }

                }

            }
            return false;
        }

        public override string GetNick()
        {
            return "Coffee13";
        }

        public override bool IsPeselValid(string pesel)
        {
            if (pesel.Length != 11)
            {
                return false;
            }

            var date = CutOffDate(pesel);
            var year = Convert.ToInt32(date.Substring(0, 2));
            var month = Convert.ToInt32(date.Substring(2, 2));
            var day = Convert.ToInt32(date.Substring(4, 2));

            if (ValidateDate(year, month, day))
            {
                if (Checksum(pesel))
                {
                    return true;
                }

            }
            return false;
        }
    }
}