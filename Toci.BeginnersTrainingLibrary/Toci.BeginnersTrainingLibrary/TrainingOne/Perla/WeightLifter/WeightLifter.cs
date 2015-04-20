using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Perla.WeightLifter
{
    public class WeightLifter : Sportsman, IBodyPart, IMotion, IExercise
        //dodać interfejs IMotion a wnim metody push pull zależne od wagi, wzrostu | stworzyć interffejs exercise a w nim zaimplementowac motion 
    {
        public WeightLifter(string name, int weight, int growth)
        {
            _name = name;
            _weight = weight;
            _growth = growth;
        }

        private int _circuit;

        public int GetCircuit()
        {
            return _circuit;
        }

        public bool DoesHeCan(IExercise exercise, int weight, string name)
        {
            if (GetWeight()/GetGrowth() > GetWeight()/weight) // w tym warunku jeszcze dodac stosunek wagi do int poszczgolnego cwiczenia
            {
                return true;
            }
            return false;
        }




        public string BodyPartType()
        {
            throw new NotImplementedException();
        }

        public bool Press()
        {
            throw new NotImplementedException();
        }

        public bool Pull()
        {
            throw new NotImplementedException();
        }


        public int DeathLift()
        {
            int DeathLift = 20;
            return DeathLift;
        }

        public int Squat()
        {
            int SquatVal = 35;
            return SquatVal;
        }

        public int OverHeadPress()
        {
            int OverHeadPressVal = 100;
            return OverHeadPressVal;
        }

        public int ChestPress()
        {
            int chestVal = 50;
            return chestVal;
        }
    }
}
