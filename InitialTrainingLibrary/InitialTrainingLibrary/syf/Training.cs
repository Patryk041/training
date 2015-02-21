using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
        //InitialUnitTest
namespace InitialTrainingLibrary.syf
{
    public class Training
    {
        private DateTime dataszkolenia;

        public int year;

        public int month;

        public int day;

        public DateTime Data
        {
            get
            {
                return new DateTime(year, month, day);
            }
        }

        public static int poleStatyczne = 4;

        public int test123 = 0;

        public int testproperty
        {
            set { test123 = value; }
        }

        public int iamaproperty { get; set; }

        public int getYear()
        {
            return year;
        }
    }
}
