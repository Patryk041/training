namespace Toci.Hornets.GhostRider.TrainingThree
{
    public class BenchingOverriding
    {
        public void TestItAll()
        {
            OverloadingExamples ex1 = new OverridingExample();
//            OverloadingExamples ex1 = new OverloadingExamples();
//           // OverridingExample ex4 = new OverloadingExamples();
//
//            ex1.CanBeOverriden(); //overload
//
//            OverloadingExamples ex2 = new OverridingExample();
//
//            ex2.CanBeOverriden(); // override
//
//            ((OverloadingExamples)ex2).CanBeOverriden(); // ? overload ? ovvverride ?
//
//
//            OverridingExample ex3 = new OverridingExample();
//
//            ((OverloadingExamples) ex3).CanBeOverriden(); // ? overload ? ovvverride ?

            //


        }


        public void OverloadingExamplesTesting()
        {
            OverloadingExamples oex = new OverloadingExamples(7);

            oex.MetodaDoPrzeciazenia();
            //
            
            oex.MetodaDoPrzeciazenia(324142.534);

            // oex.MetodaDoPrzeciazenia();

        }
    }
}