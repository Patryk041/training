using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.ghostrider;

namespace InitialTrainingLibrary.syf.privatelol
{
    public class GenExample
    {
        

        protected virtual bool IAmOverridable()
        {

            //Singleton<int> dsa = new Singleton<int>(); 

            //Example ex = Singleton<Example>.GetInstance();
            return true;
        }

        protected bool IAmNotOverridable()
        {
            return false;
        }

        public bool Chmura()
        {
            return true;
        }
    }
}
