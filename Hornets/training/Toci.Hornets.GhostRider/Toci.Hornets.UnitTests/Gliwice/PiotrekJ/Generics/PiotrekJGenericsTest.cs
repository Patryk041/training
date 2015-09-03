using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Gliwice.PiotrekJ.Homework.Generics;

namespace Toci.Hornets.UnitTests.Gliwice.PiotrekJ.Generics
{
    public class PiotrekJGenericsTest
    {
        [TestClass]
        public class TestowankoGenericosw
        {
            [TestMethod]
            public void AddTest()
            {
                var testAdd = new PiotrekJGenerics<string>(100);
                testAdd.Add("siemanko");
                testAdd.Add("fajny");
                testAdd.Add("dzisiaj");
                testAdd.Add("dzionek");
                testAdd.Add("siemanko");
                testAdd.Add("fajny");
                testAdd.Add("dzisiaj");
                testAdd.Add("dzionek");
                testAdd.Add("siemanko");
                testAdd.Add("fajny");
                testAdd.Add("dzisiaj");
                testAdd.Add("dzionek");
                testAdd.Add("siemanko");
                testAdd.Add("fajny");
                testAdd.Add("dzisiaj");
                testAdd.Add("dzionek");
                testAdd.Remove("fajny");
                testAdd.Remove("siemanko");
                testAdd.Remove("dzionek");
            }
        }
    }
}