using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.syf.privatelol;

namespace InitialTrainingLibrary.ghostrider
{
    public class HipcioSingleton : Singleton<Example>
    {
        public void test()
        {
            Dictionary<string, GenExample> test2 = new Dictionary<string, GenExample>()
            {
                {"postgres", new GenExample()},
                {"mysql", new Example()}
            };

            //int e = 4; // Redundant, never used
        }
    }
}
