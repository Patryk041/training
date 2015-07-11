using System;

namespace Toci.Hornets.Sieradz.DeeJay
{
    public class DjExampleClass : DjExampleAbstract
    {
        public DjExampleClass()
        {
        }

        public override void ExampleMethod()
        {
            //throw new System.NotImplementedException();

            //Activator act = new Activator();;

            var obj = new DjExampleClass();

            obj.ExampleMethod();
        }
    }
}