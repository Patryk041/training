using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Bytom.InkNinja.TrainingFour;

namespace Toci.Hornets.UnitTests.Bytom.InkNinja
{
    [TestClass]
    public class GenericTest
    {
        [TestMethod]
        public void Test()
        {
            bool ok = false;
            var list = new InkGenericTask<int>();
            ok = list.Remove(34);
            ok = list.Add(32);
            ok = list.Remove(35);
            ok = list.Remove(32);
            ok = list.Add(3);
            ok = list.Add(4);
            var lista = list.GetAllItems();
        }
    }
}
