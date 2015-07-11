using System.Diagnostics;
using System.Linq;

namespace Toci.Hornets.GhostRider.TrainingThree
{
    public class OverridingExample : OverloadingExamples
    {
        private int whatever = 8;
        public OverridingExample() : base()
        {
            whatever = 15;
            //CanBeOverriden();
        }

        public override int CanBeOverriden() //override
        { //2 !!!!!!

            whatever = 9; // ?????
            //base.CanBeOverriden();

           // ListaPeseli.AddRange();

            var cosjeszcze = 0;

            //ListaPeseli.Select()

            foreach (var pesel in ListaPeseli)
            {
                Debug.WriteLine("{0} nasz pesel", pesel);
                //zero++;
            }

            return 0;
        }
    }
}