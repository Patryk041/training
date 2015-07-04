namespace Toci.Hornets.Opole.S2yfr4nt.Homework
{
    public abstract class PeselValidator
    {
        public virtual bool IsPeselValid(string pesel)
        {
            ValidateDate(2011, 4, 14);
            
            return true;
        }

        protected abstract bool ValidateDate(int year, int month, int day);
    }
}