using System.Collections.Generic;

namespace Toci.BeginnersTrainingLibrary.TrainingFour.Disposables
{
    public class DisposableTester
    {
        private const int ListMaxItems = 1000000;
        private const int MaxListsCount = 62;

        public void FinishRam()
        {
            List<DisposableList<GcRefTypeTest>> ramFinisher = new List<DisposableList<GcRefTypeTest>>();


            for (int i = 0; i < MaxListsCount; i++)
            {

                var dispList = new DisposableList<GcRefTypeTest>();

                    for (int j = 0; j < ListMaxItems; j++)
                    {
                        var test = new GcRefTypeTest() {Name = "fdsafgadfaafdadfda", Whatever = 8};

                        dispList.Add(test);
                    }

                    ramFinisher.Add(dispList);          
            }
        }
    }
}
