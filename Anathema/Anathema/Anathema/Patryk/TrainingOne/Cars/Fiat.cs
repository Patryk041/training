using Anathema.Patryk.TrainingOne.Cars.Abstract;

namespace Anathema.Patryk.TrainingOne.Cars
{
    public class Fiat : Car
    {
        public Fiat()
        {
            Description = "Fiat";
        }

        protected override bool CanDrive()
        {
            return true;
        }

        protected override void Drive(){
        
        }        
    }
}