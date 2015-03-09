using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InitialTrainingLibrary.robson.ChessGame;

namespace InitialUnitTest.robson
{
    [TestClass]
    public class ChessValidator
    {
        [TestMethod]
        public void TestGetFigure()
        {
            SetUpGame game = new SetUpGame();

            game.GetFigure(0, 0);
        }
    }
}
