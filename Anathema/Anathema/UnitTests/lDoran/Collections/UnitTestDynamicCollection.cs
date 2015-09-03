using Anathema.lDoran.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTests.lDoran.Collections
{
    [TestClass]
    public class UnitTestDynamicCollection
    {
        [TestMethod]
        public void Add()
        {
            DynamicCollection<char> collection = new DynamicCollection<char>();
            Assert.AreEqual(collection.Length(), 10);

            for (int i = 0; i < 20; i++)
            {
                collection.Add((char)i);
            }

            Assert.AreEqual(collection.Length(), 20);
        }
    }
}
