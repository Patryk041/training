using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Opole.Lausion.TasksTraningTwo.PeselValidator;

namespace Toci.Hornets.UnitTests.Lausion
{
    [TestClass]
    public class PeselValidator
    {
        [TestMethod]
        public void TestMethod()
        {
            LausionPeselValidator test = new LausionPeselValidator();

            //zła data
            Assert.IsFalse(test.IsPeselValid("40023000005"));
            //zła suma
            Assert.IsFalse(test.IsPeselValid("44051401358"));
            //dobre wszystko
            Assert.IsTrue(test.IsPeselValid("44051401359"));

        }
    }
}