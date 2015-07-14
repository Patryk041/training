using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.Duch.Homework_2.PeselValidator;
using Toci.Hornets.Sieradz.Duch.Homework_2.StringManipulator;

namespace Toci.Hornets.UnitTests.Sieradz.Duch.HW2
{
    [TestClass]
    public class DuchHw2Test
    {
        [TestMethod]
        public void DuchPeselTest()
        {
            var valcek = new DuchPeselValidator();
            Assert.IsTrue(valcek.IsPeselValid("gdfgdsgf"));
            
        }
        [TestMethod]
        public void DuchStringiTest()
        {
           // var manek = new DuchStringManipulatro();
           // var res = manek.RunStringOperations("abcdd", "dccccba");

        }
    }
}
