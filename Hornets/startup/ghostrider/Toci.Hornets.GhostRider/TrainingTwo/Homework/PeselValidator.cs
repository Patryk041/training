namespace Toci.Hornets.GhostRider.TrainingTwo.Homework
{
    public abstract class PeselValidator
    {
        public virtual bool IsPeselValid(string pesel) // override i swoja implemewntacja
        {
            //wyciac 6 znakow, rozdzielic, sprwadzic czy sa poprawna data

            ValidateDate(2011, 4, 14);

            return true;
        }

        protected abstract bool ValidateDate(int year, int month, int day);
    }
}