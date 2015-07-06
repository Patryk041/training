namespace Toci.Hornets.Bytom.Pr0fes0r.TrainingTwo.PeselValidator.Date
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
                    { return Thirtyone(days); break; }
                case 4:
                case 6:
                case 9:
                case 11: { return Thirty(days); break; }
                case 2:
                    { return February(year, days); break; }

                  
                default:{return false;}

            }

            }
        

        protected bool Thirtyone(int days)
        {
            if (days < 32)
            {
                return true;
            }
            return false;
        }

        protected bool Thirty(int days)
        {
            if (days < 31)
            {
                return true;
            }
            return false;
        }

        protected bool February(int year, int days)
        {
            var years = year%4;
            if (years == 0 && days<30)
            {
                return true;
            }
            if (years != 0 && days < 29)
            {
                return true;
            }
            return false;
        }
        
    }
}