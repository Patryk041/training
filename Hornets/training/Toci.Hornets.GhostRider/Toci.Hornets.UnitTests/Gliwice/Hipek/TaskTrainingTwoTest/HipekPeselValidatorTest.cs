using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Gliwice.Hipek.TaskTrainingTwo.PeselValidator;

namespace Toci.Hornets.UnitTests.Gliwice.Hipek.TaskTrainingTwoTest
{
    [TestClass]
    public class HipekPeselValidatorTest
    {
        [TestMethod]
        public void HipekPeselValidatorTestMethod()
        {
            HipekPeselValidator peselValidator = new HipekPeselValidator();

            Assert.IsTrue(peselValidator.IsPeselValid("93040800000"));
            Assert.IsTrue(peselValidator.IsPeselValid("93043000000"));
            
            Assert.IsTrue(peselValidator.IsPeselValid("93103100000"));
            
            Assert.IsFalse(peselValidator.IsPeselValid("12023000000"));
            Assert.IsFalse(peselValidator.IsPeselValid("8706310000"));
            Assert.IsFalse(peselValidator.IsPeselValid("8708350000"));
            Assert.IsFalse(peselValidator.IsPeselValid(null));

           
            Assert.IsTrue(peselValidator.IsPeselValid("93240800000"));
            Assert.IsTrue(peselValidator.IsPeselValid("93440800000"));
            Assert.IsTrue(peselValidator.IsPeselValid("93640800000"));
            Assert.IsTrue(peselValidator.IsPeselValid("93840800000"));
            Assert.IsTrue(peselValidator.IsPeselValid("93022800000"));
            Assert.IsTrue(peselValidator.IsPeselValid("12222900000"));
        }
    }
}
