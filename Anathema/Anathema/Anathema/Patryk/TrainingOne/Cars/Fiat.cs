using Anathema.Patryk.TrainingOne.Cars.Abstract;

namespace Anathema.Patryk.TrainingOne.Cars
{
    public class Fiat : Car
    {
        public Fiat()
        {
            Description = "Fiat";
        }

        public override bool CanDrive()
        {
            return true;
        }

        public override void Drive(){
        
        }        
    }
}