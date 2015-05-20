
using InitialTrainingLibrary.coousey;
using InitialTrainingLibrary.Interfaces.chess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.coousey
{
    [TestClass]
    public class CoouseyChessTest
    {
        readonly CoouseyChessGame _chessGame = new CoouseyChessGame();

        [TestMethod]
        public void CoouseyFieldColorTest()
        {
            // white
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 0].IsFieldWhite());
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 2].IsFieldWhite());
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 4].IsFieldWhite());
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[2, 0].IsFieldWhite());
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[4, 0].IsFieldWhite());
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[1, 1].IsFieldWhite());
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[7, 7].IsFieldWhite());
            // black
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[0, 1].IsFieldWhite());
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[0, 3].IsFieldWhite());
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[0, 5].IsFieldWhite());
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[1, 0].IsFieldWhite());
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[3, 0].IsFieldWhite());
        }

        [TestMethod]
        public void CoouseyHasFieldFigureTest() // wszytie są false....
        {
            // top
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 0].HasFigure());
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[7, 0].HasFigure());
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[4, 1].HasFigure());
            // buttom
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 7].HasFigure());
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[7, 7].HasFigure());
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[4, 6].HasFigure());
            // middle
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[4, 3].HasFigure());
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[1, 4].HasFigure());
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[7, 5].HasFigure());
        }

        [TestMethod]
        public void CoouseyFigureColorTest()
        {
            // top
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 0].GetFigure().IsFigureWhite());
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[7, 0].GetFigure().IsFigureWhite());
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[4, 1].GetFigure().IsFigureWhite());
            // buttom
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[0, 7].GetFigure().IsFigureWhite());
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[7, 7].GetFigure().IsFigureWhite());
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[4, 6].GetFigure().IsFigureWhite());
        }

        [TestMethod]
        public void CoouseyFigureKindTest()
        {
            // white main row
            Assert.AreEqual(_chessGame.GetBoard().GetFields()[0, 0].GetFigure().GetFigureKind(), FigureKind.Rook);
            Assert.AreEqual(_chessGame.GetBoard().GetFields()[1, 0].GetFigure().GetFigureKind(), FigureKind.Horse);
            Assert.AreEqual(_chessGame.GetBoard().GetFields()[2, 0].GetFigure().GetFigureKind(), FigureKind.Bishop);
            Assert.AreEqual(_chessGame.GetBoard().GetFields()[3, 0].GetFigure().GetFigureKind(), FigureKind.Queen);
            Assert.AreEqual(_chessGame.GetBoard().GetFields()[4, 0].GetFigure().GetFigureKind(), FigureKind.King);
            // black main row
            Assert.AreEqual(_chessGame.GetBoard().GetFields()[0, 7].GetFigure().GetFigureKind(), FigureKind.Rook);
            Assert.AreEqual(_chessGame.GetBoard().GetFields()[1, 7].GetFigure().GetFigureKind(), FigureKind.Horse);
            Assert.AreEqual(_chessGame.GetBoard().GetFields()[2, 7].GetFigure().GetFigureKind(), FigureKind.Bishop);
            Assert.AreEqual(_chessGame.GetBoard().GetFields()[3, 7].GetFigure().GetFigureKind(), FigureKind.Queen);
            Assert.AreEqual(_chessGame.GetBoard().GetFields()[4, 7].GetFigure().GetFigureKind(), FigureKind.King);
            // pawn row
            Assert.AreEqual(_chessGame.GetBoard().GetFields()[5, 1].GetFigure().GetFigureKind(), FigureKind.Pawn);
            Assert.AreEqual(_chessGame.GetBoard().GetFields()[5, 6].GetFigure().GetFigureKind(), FigureKind.Pawn);
        }
    }
}
