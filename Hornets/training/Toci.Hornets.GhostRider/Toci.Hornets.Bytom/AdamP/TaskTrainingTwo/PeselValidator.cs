using System;

namespace Toci.Hornets.Bytom.AdamP.TaskTrainingTwo
{
    public class PeselValidator : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        private SimpleDate ParseDate(string peselDate)
        {
            SimpleDate date;
            try
            {
                date = new SimpleDate(Int32.Parse(peselDate.Substring(0, 2)), Int32.Parse(peselDate.Substring(2, 2)), Int32.Parse(peselDate.Substring(4, 2)));
            }
            catch (FormatException exc)
            {
                throw exc;
            }
            return date;
        }

        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0, 6);
        }

        protected override bool Checksum(string pesel)
        {
            if (String.IsNullOrEmpty(pesel) || pesel.Length > 11)
            {
                throw new System.ArgumentNullException();
            }
            else
            {
                int[] weights = { 1, 3, 7, 9 };
                int sum = 0;

                for (int peselCounter = 0, weightsCounter = 0; peselCounter < 10; peselCounter++, weightsCounter++)
                {
                    if (weightsCounter > 3) weightsCounter = 0;
                    sum += weights[weightsCounter] * int.Parse(pesel.Substring(peselCounter, 1));
                }

                int lastNumber = int.Parse(pesel.Substring(10, 1));

                int controlValue = sum % 10;

                if (controlValue == 0)
                {
                    return (lastNumber == 0);
                }
                else
                {
                    return (lastNumber == (10 - controlValue));
                }
            }
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            if ((month == 0) || (day == 0))
                return false;

            bool monthIsValid = false;

            int monthCounter;

            for (monthCounter = 1; (monthCounter < 13)&&(!monthIsValid); monthCounter++)
            {
                monthIsValid = (month - monthCounter)%20 == 0;
            }

            if ((day < 29) && monthIsValid)
            {
                return true;
            }

            if (monthIsValid)
            {
                int[] possibleDayNumbers = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
                if (day <= possibleDayNumbers[monthCounter])
                    return true;
                if ((monthCounter == 2) && (day == 29))
                {
                    if (((year%4) == 0) && (year > 0))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override string GetNick()
        {
            return "AdamP";
        }

        public override bool IsPeselValid(string pesel)
        {
            SimpleDate date;
            try
            {
                date = ParseDate(CutOffDate(pesel));
            }
            catch (FormatException)
            {
                date = null;
            }

            return (ValidateDate(date.getYear(), date.getMonth(), date.getDay()) && Checksum(pesel));

        }
    }
}