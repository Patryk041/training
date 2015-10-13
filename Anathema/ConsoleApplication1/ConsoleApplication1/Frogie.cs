using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Frogie
    {
        //pole czyli zmienna
        private int JakBardzoLubieProgramowac;

        protected bool ToJestAutoProperta { get; set; }

        public void KochamCie(int bardzo)
        {
            
        }

        protected int BardzoBardzo(string test)
        {
            //typ inny niz void to return
            return 1;
        }
                                      //generics poniewaz <T> lub <T,T2> ..
        private bool CzyBartekMnieKocha(Dictionary<int, string> powody)
        {
            this.JakBardzoLubieProgramowac = 8;
            //foreach bo tab asocjacyjna, tu nazywana generyczny slownik
            foreach (var element in powody)
            {
                
            }

            return true;
        }
    }

    static class WorekExtensionMetod
    {
        ////extension method
        /// w klasie niestatycznej sie nie kompiluje bo musialaby byc statyczna
        public static bool ToJestExtMetoda(this int pojawiesiewpublicznymapitypuint)
        {
            int i = 8;
            if (false)
            {
                i.ToJestExtMetoda();

                3.ToJestExtMetoda();
            }

            return true;
        }
    }
}
