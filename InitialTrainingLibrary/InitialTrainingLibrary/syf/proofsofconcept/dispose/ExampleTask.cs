using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.proofsofconcept.dispose
{
    public class ExampleTask : Task
    {
        private static int listSize = 100000;
        private static int totalCallsCount = 4000;
        private static int callsCount = 0;

        public ExampleTask()
            : base(GenerateList)
        {
            
        }

        private static void GenerateList()
        {
            using (var list = new DisposableListExample<ExampleClass>(listSize))
            {
            //var list = new DisposableListExample<ExampleClass>(listSize);

                for (int i = 0; i < list.Count; i++)
                {
                    list[i] = new ExampleClass("cnbdjgdwhugfvdhvbjbwqvihbvehvbvhdbvhsvbdsavhdkbvhdas", "fbqeyfiqebceqhbveyifbceqybvvbvqehvceb");
                }

            };
            callsCount++;

            if (callsCount < totalCallsCount)
            {
                GenerateList();
            }
        }
    }
}
