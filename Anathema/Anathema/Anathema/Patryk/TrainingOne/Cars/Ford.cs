using Anathema.Patryk.TrainingOne.Cars.Abstract;

namespace Anathema.Patryk.TrainingOne.Cars
{
    public class Ford : Car
    {
        public Ford()
        {
            Description = "Ford";
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