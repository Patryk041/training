using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace Toci.Hornets.Legnica.Startup.LegnicaCode.Patryk_Stulczewski
{
    [TestClass]
    public class PolishFormatPeselValidatorTest
    {
        [TestMethod]
        public void IsPeselValid_WhenBadFormat()
        {
            PolishFormatPeselValidator v = new PolishFormatPeselValidator();
            Assert.IsFalse( v.IsPeselValid(null) );
            Assert.IsFalse( v.IsPeselValid("1aadf399%12") );
            Assert.IsFalse( v.IsPeselValid("123") );
            Assert.IsFalse( v.IsPeselValid("121011%&7%6") );
            Assert.IsFalse( v.IsPeselValid("12345678901234") );
            Assert.IsFalse(v.IsPeselValid("93133200345"));
        }

        [TestMethod]
        public void IsPeselValid_WhenDateInFuture()
        {
            PolishFormatPeselValidator v = new PolishFormatPeselValidator();
            Assert.IsFalse( v.IsPeselValid("15272199777") );
            Assert.IsTrue(v.IsPeselValid("15262199777"));
        }

        [TestMethod]
        public void IsPeselValid_WhenLeapYear()
        {
            PolishFormatPeselValidator v = new PolishFormatPeselValidator();
            Assert.IsTrue(v.IsPeselValid("04022955333"));
            Assert.IsFalse(v.IsPeselValid("03022955333"));
        }

        [TestMethod]
        public void IsPeselValid_WhenLastDayInMonth()
        {
            PolishFormatPeselValidator v = new PolishFormatPeselValidator();
            Assert.IsTrue(v.IsPeselValid("93063000377"));
            Assert.IsFalse(v.IsPeselValid("93063100377"));
        }
    }
}
