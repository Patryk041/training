using System;

namespace Toci.Hornets.Rzeszow.Polak.TrainingByPolak
{
    public class TrainingClassPolakOne : ITrainingInterfacebyPolak
    {
        public void Whatever(bool logiczny, string tresc, int liczbowy, double zmiennoprzecinkowy)
        {
        
            logiczny = true;
            tresc = "jakoś działa";
            liczbowy = 5;
            zmiennoprzecinkowy = 5.2;
        }

        public void Method()
        {
            //nic nie zwraca
        }

    }
}