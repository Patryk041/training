using Anathema.Patryk.TrainingOne.Cars.Abstract;

namespace Anathema.Patryk.TrainingOne.Cars
{
    public class Ford : Car
    {
        public Ford()
        {
            Description = "Ford";
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