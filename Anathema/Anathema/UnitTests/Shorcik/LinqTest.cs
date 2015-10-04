using Anathema.Shorcik.linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Shorcik
{
    public class LinqTest
    {
        [TestClass]
        public class TestLinq
        {
            [TestMethod]
            public void ShorcikLinqTest()
            {
                MoreLinqOperations my = new MoreLinqOperations();
                var Developers = my.GetDeveloperAmount("Developer");
               // var Developers2 = my.GetDeveloperDictionaryWithFiveLetterKeyAmount(); error podczas testu / why? 
               
            }
        }
    }
}