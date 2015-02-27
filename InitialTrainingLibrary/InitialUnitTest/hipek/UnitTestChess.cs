using System;
using InitialTrainingLibrary.hipek._2.ChessGame;
using InitialTrainingLibrary.Interfaces.chess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.hipek
{
    [TestClass]
    public class UnitTestChess
    {
        [TestMethod]
        public void TestMethodChessHipek()
        {
            ChessBoard chessBoard = new ChessBoard();



            IBoardField[,] field = chessBoard.GetFields();
            var isWhite = field[0, 0].IsFieldWhite();

            Assert.AreEqual(field[0, 0].IsFieldWhite(), field[2, 0].IsFieldWhite());
            Assert.AreNotEqual(field[0, 0].IsFieldWhite(), field[1, 0].IsFieldWhite());
        }
    }
}
