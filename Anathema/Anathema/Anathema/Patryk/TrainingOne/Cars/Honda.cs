using Anathema.Patryk.TrainingOne.Cars.Abstract;

namespace Anathema.Patryk.TrainingOne.Cars
{
    public class Honda : Car
    {
        public Honda()
        {
            Description = "Honda";
        }

        protected override bool CanDrive()
        {
            return true;
        }

        protected override void Drive()
        {
            
        }

    }
}