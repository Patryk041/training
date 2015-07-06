using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Rzeszow.Terry.TrainingTwo.Pesel;

namespace Toci.Hornets.UnitTests.Rzeszow.Terry.PeselValidatorTest
{
    [TestClass]
    public class TerryPeselValidatorTest
    {
        [TestMethod]

        public void PeselTest()
        {
            TerryPeselValidator pesel = new TerryPeselValidator();
            Assert.IsTrue(pesel.IsPeselValid("67040500538"));
        }
    }
}
