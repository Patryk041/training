using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Gliwice.Didi.PeselTask;

namespace Toci.Hornets.UnitTests.Gliwice.Didi.Pesel
{
    [TestClass]
    public class PeselValidationTest
    {
        [TestMethod]
        public void TestMethod()
        {
          string pesel = "93031302007";
          int year = 2015;
          int month = 10;
          int day = 13;

          ValidationPeselClass peselTest = new ValidationPeselClass();

          var resultP = peselTest.IsPeselValid(pesel);
          var resutltD = peselTest.IsDataValid(year, month, day);
          Assert.IsTrue(resultP);
          Assert.IsTrue(resutltD);

          pesel = "930313020079";
          year = 2015;
          month = 02;
          day = 28;

          resultP = peselTest.IsPeselValid(pesel);
          resutltD = peselTest.IsDataValid(year, month, day);
          Assert.IsFalse(resultP);
          Assert.IsTrue(resutltD);

          pesel = "98039302007";
          year = 2015;
          month = 02;
          day = 30;

          resultP = peselTest.IsPeselValid(pesel);
          resutltD = peselTest.IsDataValid(year, month, day);
          Assert.IsFalse(resultP);
          Assert.IsFalse(resutltD);
        }
    }
}
