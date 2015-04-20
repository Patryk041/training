using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Perla.WeightLifter
{
    public class WeightLifter : Sportsman
    {
        public WeightLifter(string name, int weight, int tall)
        {
            this._name = name;
            this._weight = weight;
            this._growth = tall;
        }
    }
}
