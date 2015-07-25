using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.TrainingFive.Reflection;
using Toci.Hornets.GhostRider.TrainingFive.Tpl;

namespace Toci.Hornets.UnitTests.GhostRider.Reflection
{
    [TestClass]
    public class ReflectorTesting
    {
        [TestMethod]
        public void test()
        {
            CustomReflector refl = new CustomReflector();


            refl.RunReflection();
            //refl.Test();
        }

        [TestMethod]
        public void TplFactory()
        {
            ParallelFileParserManager parallelFileParserManager = new ParallelFileParserManager();

            parallelFileParserManager.ManageFile("fdfgds", 8);
        }
    }
}