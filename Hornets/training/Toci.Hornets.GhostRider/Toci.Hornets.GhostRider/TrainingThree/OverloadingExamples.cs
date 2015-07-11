using System;
using System.Collections.Generic;
using System.IO;

namespace Toci.Hornets.GhostRider.TrainingThree
{
    public class OverloadingExamples
    {
        public OverloadingExamples()
        { // 1
            
            
            /// ? 1
            CanBeOverriden(); // override !!!!!!!!

        }

        public OverloadingExamples(int s) : this()
        { // ? 2

        }

        public int MetodaDoPrzeciazenia()
        {
           OverloadingExamples fd = new OverloadingExamples();

           fd.MetodaDoPrzeciazenia(test2: "cokolwiek stąd");
            return 0;
        }

        

        public int MetodaDoPrzeciazenia(int test)
        {
       
            return MetodaDoPrzeciazenia();
        }

  

        public int MetodaDoPrzeciazenia(double test = 8.88, int zmienie= 3214132, string test2 = "cos innego", int ewq = 43, int piaty =9)
        {
            //MetodaDoPrzeciazenia();
            var sprawdzamy = test2;
            return 0;
        }

        public int MetodaDoPrzeciazenia( string test2)
        {
            MetodaDoPrzeciazenia(54.56);
            var egmnietu = test2; // tu wg mnie
            return 0;
        }


        ///----------------------------------------
        /// 
        /// 

        protected List<string> ListaPeseli = new List<string>();

        public virtual int CanBeOverriden() //virtual
        { // tu nie !!
            ListaPeseli = new List<string>();

            return ListaPeseli.Count;
        }
    }
}