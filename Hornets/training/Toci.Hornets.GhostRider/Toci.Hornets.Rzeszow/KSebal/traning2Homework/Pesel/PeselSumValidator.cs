using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Rzeszow.KSebal.traning2Homework.Pesel
{


    public  class PeselSumValidator
    {
        private int[] waga ={1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
        private int[] numOfPesel;

        public PeselSumValidator(string pesel)
        {
            numOfPesel = pesel.Select(item => int.Parse(item.ToString())).ToArray();
        }


        public bool checkPesel()
        {
            if (numOfPesel.Length != 11) return false;

            int result= waga.Select((t, i) => numOfPesel[i]*t).Sum();

            return (10-result%10)%10 == numOfPesel[10];
        }


    }
}
