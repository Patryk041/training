using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Opole.S2yfr4nt.Homework.S2yfr4ntGenericList;

namespace Toci.Hornets.UnitTests.S2yfr4nt.GenericList
{
    [TestClass]
    public class GenericList
    {
        [TestMethod]
        public void TestMethod1()
        {
            S2yfr4ntGenericList<int> lista = new S2yfr4ntGenericList<int>();
            //lista.Add(3);
            //lista.Add(3);
            //lista.Add(3);
            //lista.Add(3);
            lista.Add(5);
            lista.Add(3);
            lista.Add(3);
            lista.Add(3);
            lista.GetAllItems();
            lista.Remove(5);
            lista.GetAllItems();
        }
    }
}
