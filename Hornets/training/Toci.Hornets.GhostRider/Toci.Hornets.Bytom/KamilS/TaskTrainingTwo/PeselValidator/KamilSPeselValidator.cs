using System;

namespace Toci.Hornets.Bytom.KamilS.TaskTrainingTwo.PeselValidator
{
    public class KamilSPeselValidator : GhostRider.YourWork.TasksTrainingTwo.PeselValidator
    {
        protected override string CutOffDate(string pesel)
        {
            return pesel.Substring(0, 6);
        }

        protected override bool Checksum(string pesel)
        {
            char[] charPesel = pesel.ToCharArray();
            int[] peselArray = Array.ConvertAll(charPesel, c => (int)char.GetNumericValue(c));
            int sum = (peselArray[0] + 3 * peselArray[1] + 7 * peselArray[2] + 9 * peselArray[3] +
                      peselArray[4] + 3 * peselArray[5] + 7 * peselArray[6] + 9 * peselArray[7] +
                      peselArray[8] + 3 * peselArray[9] + peselArray[10]) % 10;
            if (10 - sum == peselArray[10])
            {
                return true;
            }
            return false;
        }

        protected override bool ValidateDate(int year, int month, int day)
        {
            if (month >= 81 && month <= 92)
            {
                year += 1800;
                month -= 80;
            }
            else if (month >= 1 && month <= 12)
            {
                year += 1900;
            }
            else if (month >= 21 && month <= 32)
            {
                year += 2000;
                month -= 20;
            }
            else if (month >= 41 && month <= 52)
            {
                year += 2100;
                month -= 40;
            }
            else if (month >= 61 && month <= 72)
            {
                year += 2200;
                month -= 60;
            }
            else
            {
                return false;
            }
            if (month > 0 && month <= 12)
            {
                if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                {
                    if (day > 0 && day <= 31)
                    {
                        return true;
                    }
                    else { return false;}
                }
                if (month == 4 || month == 6 || month == 9 || month == 11)
                {
                    if (day > 0 && day <= 30)
                    {
                        return true;
                    }
                    else { return false;}
                }
                if (month == 2)
                {
                    if ((year%4 == 0) && (year%100 != 0) || (year%400 == 0))
                    {
                        if (day > 0 && day <= 29)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        if(day>0 && day<=28)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public override string GetNick()
        {
            return "KamilS";
        }

        public override bool IsPeselValid(string pesel)
        {
            string date = CutOffDate(pesel);
            int year = Convert.ToInt32(date.Substring(0, 2));
            int month = Convert.ToInt32(date.Substring(2, 2));
            int day = Convert.ToInt32(date.Substring(4, 2));
            if (pesel.Length == 11)
            {
                if (ValidateDate(year, month, day))
                {
                    if (Checksum(pesel))
                    {
                        return true;
                    }
                }
<<<<<<< HEAD:Hornets/training/Toci.Hornets.GhostRider/Toci.Hornets.Bytom/KamilS/TaskTrainingTwo/PeselValidator/KamilSPeselValidator.cs
            }
            return false;
=======
            }     
	        return false;

>>>>>>> master:Hornets/training/Toci.Hornets.GhostRider/Toci.Hornets.Bytom/KamilS/TaskTrainingTwo/PeselValidator/PeselValidator.cs
        }
    }
}