using System.Threading;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.proofsofconcept.async
{
    public class NewStyle
    {
        private string asynchron = "";

        private async Task<bool> WaitSomeTime()
        {
            var result = await LenghtyTask();

            return result;
        }

        private async Task<bool> LenghtyTask()
        {
            await Task.Run(() => DoWaiting());

            return true;
        }

        private void DoWaiting()
        {
            Thread.Sleep(10000);
            asynchron = "watek poszedl";
        }

        public void test()
        {
            var result = WaitSomeTime();

            int dsa = 6;

            result.Wait();
            var test = result.Result;
            var test2 = asynchron;
        }
    }
}
