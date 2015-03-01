using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces;
using InitialTrainingLibrary.RS.Simple;
using InitialTrainingLibrary.syf.privatelol;

namespace InitialTrainingLibrary.ghostrider
{
    public class Example : GenExample, IChmuraQuestions
    {
        public void test()
        {
            Dictionary<string, GenExample> test2 = new Dictionary<string, GenExample>()
            {
                {"postgres", new GenExample()},
                {"mysql", new Example()}
            };

            // int e = 4; // Redundant, never used
        }

        protected override bool IAmOverridable()
        {
            base.IAmOverridable();
            return true; //base.IAmOverridable();
        }

        protected new bool IAmNotOverridable()
        {
            return true;
        }

        public void test2()
        {
            this.IAmNotOverridable();



        }

        public void Sito()
        {
            //computations
        }
    }
}
