using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anathema.Igor;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GRListEx<int> test = new GRListEx<int>();

            test.AddElement(1);
            test.AddElement(2);
            test.AddElement(3);
            test.AddElement(4);
            test.AddElement(5);
            test.AddElement(6);
            test.AddElement(7);
            test.AddElement(8);
            test.AddElement(9);
            test.AddElement(10);
            test.AddElement(11);
            test.AddElement(12);
            test.AddElement(13);
            test.AddElement(14);
            test.AddElement(15);
            test.AddElement(16);
            test.AddElement(17);
            test.AddElement(18);
            test.AddElement(19);
            test.AddElement(20);
            test.AddElement(21);
            test.AddElement(22);

            string t = test.getArray().ToString();

            Assert.Equals(t, "witam");
        }
    }
}
