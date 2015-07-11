using System.ComponentModel.Design;

namespace Toci.Hornets.Rzeszow.Malwina.Pesell
{
    public class DataCzyOk
    {
        public int rok, miesiac, dzien;

        public DataCzyOk(string pesel)
        {
            rok = int.Parse(pesel.Substring(0, 2));
            miesiac = int.Parse(pesel.Substring(2, 2));
            dzien = int.Parse(pesel.Substring(4, 2));
        }

        public void Data()
        {
            if (miesiac > 0 && miesiac < 13)
            {
                rok = rok + 1900;
            }
            if (miesiac > 20 && miesiac < 33)
            {
                rok = rok + 2000;
                miesiac = miesiac - 20;
            }
            if (miesiac > 40 && miesiac < 53)
            {
                rok = rok + 2100;
                miesiac = miesiac - 40;
            }
            if (miesiac > 60 && miesiac < 73)
            {
                rok = rok + 2200;
                miesiac = miesiac - 60;
            }
            if (miesiac > 80 && miesiac < 93)
            {
                rok = rok + 1800;
                miesiac = miesiac - 80;
            }
        }

        public static bool Check(int rok, int miesiac, int dzien)
        {
            int dz;
            if (miesiac < 1 || miesiac > 12)
            {
                return false;
            }
            if ((rok%4 == 0 && rok%100 != 0 || rok%400 == 0)&& miesiac==2)
            {
                dz = 29;
                return (dzien <= dz);
            }
            if (miesiac == 4 || miesiac == 6 || miesiac == 9 || miesiac == 11)
            {
                dz = 30;
                return (dzien <= dz);
            }
            else
            {
                dz = 31;
                return (dzien <= dz);
            }




        }
    }
}
      