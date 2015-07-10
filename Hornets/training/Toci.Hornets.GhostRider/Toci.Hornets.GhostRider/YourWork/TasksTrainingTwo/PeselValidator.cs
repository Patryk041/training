namespace Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo
{
    public abstract class PeselValidator
    {
        protected abstract string CutOffDate(string pesel);

        protected abstract bool Checksum(string pesel);

        protected abstract bool ValidateDate(int year, int month, int day);

        public abstract string GetNick();

        // cut, checksum, validate
        public abstract bool IsPeselValid(string pesel);
    }
}