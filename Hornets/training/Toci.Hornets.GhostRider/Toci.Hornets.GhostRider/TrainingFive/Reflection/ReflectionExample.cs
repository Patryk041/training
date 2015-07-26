using Toci.Hornets.GhostRider.GhostRider;
using Toci.Hornets.GhostRider.YourWork.TelephoneTask;

namespace Toci.Hornets.GhostRider.TrainingFive.Reflection
{
    public class ReflectionExample
    {
        private int InvisibleAndNonDerivable;
        protected int InvisibleDerivable;

        private void InvisbleMethod(TelephoneInterpreter homework)
        {
            homework.GetUserChoice(8);

            InvisibleAndNonDerivable = 8; // ? 2
            InvisibleDerivable = 4;
        }

        protected void InvisibleDerivableMethod()
        {
            InvisibleAndNonDerivable = 5;  // ?
            InvisibleDerivable = 6;
        }

        private static void StaticPRivateMethod()
        {
            
        }
    }
}