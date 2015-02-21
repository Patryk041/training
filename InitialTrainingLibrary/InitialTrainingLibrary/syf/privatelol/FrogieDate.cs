namespace InitialTrainingLibrary.syf.privatelol
{
    public class FrogieDate
    {
        private int year;
        private int month;
        private int day;

        public void UstawRok(int rok)
        {
            year = rok;
        }

        public int PodajRok()
        {
            return year;
        }

        public void UstawMiesiac(int miesiac)
        {
            month = miesiac;
        }

        public int PodajMiesiac()
        {
            return month;
        }

        public void UstawDzien(int dzien)
        {
            day = dzien;
        }

        public int PodajDzien()
        {
            return day;
        }
    }
}
