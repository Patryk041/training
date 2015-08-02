using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.UCantTouchThis.TrainingFour;

namespace Toci.Hornets.UnitTests.Sieradz.UCantTouchThis.TrainingFour
{
    [TestClass]
    public class UCantTouchThisGenericListTest
    {
        readonly UCantTouchThisTraingFour<string> _testObjet = new UCantTouchThisTraingFour<string>();

        [TestMethod]
        public void RunTests()
        {
            LengthShouldBeZeroAfterCreatingNewList();
            LengthShouldBeThreeAfterAddingThreeElements();
            ShouldReturnArray(new[] { "a", "b", "c" });
            LengthSouldBeOneAfterRemovingTwoElements();
            ShouldReturnArray(new []{"c"});
            ShouldReturnFalseWhenRemovingNonExistingElement();
            ShouldReturnTrueWhenRemovingExistingElement();
            ShouldReturnFalseWhenRemovingFromEmptyList();
            ShouldReturnTrueWhenAddingElement();
        }

        private void LengthShouldBeZeroAfterCreatingNewList()
        {
            Assert.AreEqual(_testObjet.GetLength(), 0);
        }

        private void LengthShouldBeThreeAfterAddingThreeElements()
        {
            _testObjet.Add("a");
            _testObjet.Add("b");
            _testObjet.Add("c");
            Assert.AreEqual(_testObjet.GetLength(), 3);
        }

        private void LengthSouldBeOneAfterRemovingTwoElements()
        {
            _testObjet.Remove("a");
            _testObjet.Remove("b");
            Assert.AreEqual(_testObjet.GetLength(), 1);
        }

        private void ShouldReturnArray(string[] array)
        {
            Assert.IsTrue(_testObjet.GetAllItems().SequenceEqual(array));
        }

        private void ShouldReturnFalseWhenRemovingNonExistingElement()
        {
            Assert.IsFalse(_testObjet.Remove("q"));
        }

        private void ShouldReturnTrueWhenRemovingExistingElement()
        {
            Assert.IsTrue(_testObjet.Remove("c"));
        }

        private void ShouldReturnFalseWhenRemovingFromEmptyList()
        {
            Assert.IsFalse(_testObjet.Remove("q"));
        }

        private void ShouldReturnTrueWhenAddingElement()
        {
            Assert.IsTrue(_testObjet.Add("z"));
        }
    }
}