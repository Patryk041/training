using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo
{
    abstract class Engine
    {
        private const int MaximumFuelQuotient = 5;

        //protected FuelInjector injector;
        //protected Oil oil;
        protected int FuelConsumptionSpeedQuotient = 0;

        public int GetFuelConsumptionSpeed()
        {
            return FuelConsumptionSpeedQuotient;
        }

        /// <summary>
        /// ///
        /// </summary>
        /// <returns></returns>


        protected abstract int GetFuelQuotient();

        public int CombustionChamberSpeed()
        {
            if (GetFuelQuotient() > MaximumFuelQuotient)
            {
                return 1;
            }

            return 2;
        }
    }
}
