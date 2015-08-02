using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.UCantTouchThis.ExtensionMethods;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis.ExtensionMethodsTests
{
    [TestClass]
    public class UCantTouchThisStringExtensionsTests
    {
        [TestMethod]
        public void UCantTouchThisStringExtensionsTest()
        {
            TryRemoveTest();
            TryToGetNumberTest();
        }

        private void TryRemoveTest()
        {
            ShouldReturnNewStringWithoutElement();
            ShouldReturnSameStringWhenTryingToRemoveNonExistingElement();
        }

        private void ShouldReturnNewStringWithoutElement()
        {
            Assert.AreEqual("hulajnoga".TryRemove("noga"), "hulaj");
        }

        private void ShouldReturnSameStringWhenTryingToRemoveNonExistingElement()
        {
            Assert.AreEqual("hulajnoga".TryRemove("motor"), "hulajnoga");
        }

        private void TryToGetNumberTest()
        {
            ShouldReturnProperNumber();
            ShouldReturnZeroIfStringIsNull();
            ShouldReturnZeroIfIndexesAreWrong();
        }

        private void ShouldReturnProperNumber()
        {
            Assert.AreEqual("as123dfsasknddf".TryToGetNumber(2, 4), 123);
        }

        private void ShouldReturnZeroIfStringIsNull()
        {
            string testString = null;
            Assert.AreEqual(testString.TryToGetNumber(0,0), 0);
        }

        private void ShouldReturnZeroIfIndexesAreWrong()
        {
            string testString = "Ala ma 3 koty";
            Assert.AreEqual(testString.TryToGetNumber(-1, 0), 0);
            Assert.AreEqual(testString.TryToGetNumber(-5, -2), 0);
            Assert.AreEqual(testString.TryToGetNumber(5, 2), 0);
            Assert.AreEqual(testString.TryToGetNumber(50, 51), 0);
        }

   

     
    }
}