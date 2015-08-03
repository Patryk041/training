namespace Toci.Hornets.Bytom.Szary.TrainingTwo.DateOperations
{
    public class Days
    {
        public bool Day(int year, int month, int days)
        {
            var months = month % 20;
            switch (months)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    { return Thirtyone(days); }
                case 4:
                case 6:
                case 9:
                case 11: { return Thirty(days);  }
                case 2:
                    { return February(year, days);
                    }

                  
                default:{return false;}

            }

            }
        

        protected bool Thirtyone(int days)
        {
            return days < 32;
        }

        protected bool Thirty(int days)
        {
            return days < 31;
        }

        protected bool February(int year, int days)
        {
            var years = year%4;
            if (years == 0 && days<30)
            {
                return true;
            }
            return years != 0 && days < 29;
        }
    } 
}
