using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Rzeszow.Chojnecki.trainingFour;

namespace Toci.Hornets.UnitTests.Rzeszow.Chojnecki.tFour
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var gen = new AndrzejGen<string>();
            var gen2 = new AndrzejGen<int>();
            gen.Add("1");
            gen.Add("2");
            gen.Add("3");

            gen2.Add(2);
            gen2.Add(6);
            gen2.Add(7);

            gen2.Remove(2);
            gen2.Add(4);
        }
    }
}