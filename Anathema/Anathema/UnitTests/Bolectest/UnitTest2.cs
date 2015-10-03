using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anathema.Bolec;
namespace UnitTests.Bolec
{
    [TestClass]
    public class UnitTest2
    {
        private MyGRList<string> _myGrList;

        [TestInitialize]
        public void Setup()
        {
            _myGrList = new MyGRList<string>();
        }

        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
