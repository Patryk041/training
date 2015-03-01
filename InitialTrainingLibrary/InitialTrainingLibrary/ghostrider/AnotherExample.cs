using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.syf.privatelol;

namespace InitialTrainingLibrary.ghostrider
{
    class AnotherExample : IChmuraQuestions
    {
        private GenExample ex= null;

        private Example exrf = null;

      

        public GenExample GetGenExample()
        {
            return ex;
        }

        public void Sito()
        {
            this.exrf.Sito();
        }
    }
}
