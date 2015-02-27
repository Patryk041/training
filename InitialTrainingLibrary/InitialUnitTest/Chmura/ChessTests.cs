using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialUnitTest.szymon93;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InitialTrainingLibrary.Chmura.OtherChess;
using InitialTrainingLibrary.Chmura.OtherChess.Board;

namespace InitialUnitTest.Chmura
{
    [TestClass]
    public class ChessTests
    {
        
        public ChessGame game = new ChessGame();

        [TestMethod]
        public void MakeSomeTestChmura()
        {
            game.DrawBoard();
            game.moveFigure(new Coordinates(1,1), new Coordinates(2,1));
        }
    }
}
