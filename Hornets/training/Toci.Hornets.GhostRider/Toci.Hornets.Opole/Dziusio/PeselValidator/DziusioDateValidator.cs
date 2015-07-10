using System;

namespace Toci.Hornets.Opole.Dziusio.PeselValidator
{
    public class DziusioDateValidator
    {
        public String Date { get; set; }
 
        private int[] DaysMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        private int[] DaysMonthLeap = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };


        public int GetDay()
        {
            return Convert.ToInt32(Date.Substring(4, 2));
        }

        public int GetMonth()
        {
            return Convert.ToInt32(Date.Substring(2, 2));
        }


        public int GetYear()
        {
            return Convert.ToInt32(Date.Substring(0, 2));
        }


        public int TransformYear()
        {
            var a = GetMonth();
            if (a >= 1 && a <= 12)
            {
                return GetYear()+1900;
            }
            if (a >= 21 && a <= 32)
            {
                return GetYear() + 2000;
            }
            if (a >= 41 && a <= 52)
            {
                return GetYear() + 2100;
            }
            if (a >= 61 && a <= 72)
            {
                return GetYear() + 2200;
            }
            if (a >= 81 && a <= 92)
            {
                return GetYear() + 1800;
            }
            else return 1;
        }

        public int TransformMonth()
        {
            var a = GetMonth();
            if (a >= 1 && a <= 12)
            {
                return a;
            }
            if (a >= 21 && a <= 32)
            {
                return a-20;
            }
            if (a >= 41 && a <= 52)
            {
                return a-40;
            }
            if (a >= 61 && a <= 72)
            {
                return a-60;
            }
            if (a >= 81 && a <= 92)
            {
                return a - 80;
            }
            else return 0;
        }


        public bool CheckYearLeap()
        {
            if (TransformYear()%4 == 0 && TransformYear()%100 != 0 || TransformYear()%400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
    
        }


        public bool ValidateDay()
        {
            //year leap
            if (CheckYearLeap())
            {
                if (GetDay() == DaysMonthLeap[TransformMonth() - 1])
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
                //year normal
                if (GetDay() == DaysMonth[TransformMonth() - 1])
                {

                    return true;
                }
                else
                {
                    return false;
                }
                
            }
           

        }


    }
}