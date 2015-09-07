using Anathema.Patryk.TrainingOne.Cars.Abstract;

namespace Anathema.Patryk.TrainingOne.Cars
{
    public class Honda : Car
    {
        public Honda()
        {
            Description = "Honda";
        }

        public override bool CanDrive()
        {
            return true;
        }

        public override void Drive()
        {
            
        }

    }
}