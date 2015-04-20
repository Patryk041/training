using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Perla.WeightLifter
{
    public abstract class BodyPart
    {
        private string _typeName;
        private int _circuit;

        public string GetTypeName()
        {
            return _typeName;
        }

        public int GetCircuit()
        {
            return _circuit;
        }

        public BodyPart(string type, int circuit)
        {
            this._typeName = type;
            this._circuit = circuit;
        }
    }
}
