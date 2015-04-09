using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Vernathic.OMR2;

namespace Toci.TrainingLibrary.Test.Developers.Vernathic
{
    [TestClass]
    public class VCoffeeMachineTest
    {
        [TestMethod]
        public void CoffeeMachineTest()
        {
            var machine = new CoffeeMachine();

            machine.makeCoffeeBeverage(CoffeeBeverage.TypeOfCoffee.Americana);
        }
    }
}