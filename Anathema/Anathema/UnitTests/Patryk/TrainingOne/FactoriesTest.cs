using Anathema.Patryk.TrainingOne.Cars;
using Anathema.Patryk.TrainingOne.Cars.Abstract;
using Anathema.Patryk.TrainingOne.Chess.Abstract;
using Anathema.Patryk.TrainingOne.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Patryk.TrainingOne
{
    [TestClass]
    public class FactoriesTest
    {
        [TestMethod]
        public void CarFactoryTest()
        {
            CarFactory carFactory = new CarFactory();

            ICar honda = carFactory.GetElement("Honda");

            honda.Color = Color.Blue;

            ICar anotherHonda = carFactory.GetElement("Honda");
        }


        [TestMethod]
        public void ChessFactoryTest()
        {
            ChessFactory carFactory = new ChessFactory();

            IFigure Bishop = carFactory.GetElement("Bishop");

            IFigure King = carFactory.GetElement("King");
        }
    }
}
