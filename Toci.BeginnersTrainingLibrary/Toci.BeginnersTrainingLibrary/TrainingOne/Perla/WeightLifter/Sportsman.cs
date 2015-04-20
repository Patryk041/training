using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Perla.WeightLifter
{
    public abstract class Sportsman
    {
        protected string _name;
        protected int _weight;
        protected int _growth;

        public string GetName()
        {
            return _name;
        }

        public int GetWeight()
        {
            return _weight;
        }

        public int GetGrowth()
        {
            return _growth;
        }

        
    }
    }



