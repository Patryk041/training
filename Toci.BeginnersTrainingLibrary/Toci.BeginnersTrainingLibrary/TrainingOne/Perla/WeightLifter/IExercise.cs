using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Perla.WeightLifter
{
    public interface IExercise
    {
        int DeathLift();
        int Squat();
        int OverHeadPress();
        int ChestPress();
    }
}
