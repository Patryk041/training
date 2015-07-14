using System.Runtime.InteropServices.ComTypes;

namespace Toci.Hornets.Sieradz.UCantTouchThis.CastingExamples
{
    public class CastingExampleOne
    {
        void ExampleOne()
        {
            var one = new One();
            var two = new Two();

            one = one as Two;
            one = one as One;

//            two = two as One;     // Not gonna happen
        } 
    }
}