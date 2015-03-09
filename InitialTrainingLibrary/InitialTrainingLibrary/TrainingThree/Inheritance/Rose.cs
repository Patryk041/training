using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.TrainingThree.Inheritance
{
    class Rose : PlantBase, IFlower
    {
        public override bool IsDwuletnia()
        {
            throw new NotImplementedException();
            //this.Posiej();
        }
    }
}
