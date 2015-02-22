using System;
using InitialTrainingLibrary.dysq.DateValidator;
using InitialTrainingLibrary.frogie;
using InitialTrainingLibrary.syf;
using InitialTrainingLibrary.syf.minesweepershowdown.board;
using InitialTrainingLibrary.syf.minesweepershowdown.interfaces;
using InitialTrainingLibrary.syf.postcodevalidator;
using InitialTrainingLibrary.syf.privatelol;
using InitialTrainingLibrary.syf.refvaltypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Training test = new Training();
            Training test2 = new Training();

            test.test123 = 5;
            test2.test123 = 6;

            Training.poleStatyczne = 5;

            test.year = 2012;
            test.month = 3;
            test.day = 12;

            Assert.AreEqual(test.Data, new DateTime(2012, 3, 12));

            BoardField testboard = new SweeperBoardField();
        }

        [TestMethod]
        public void TestChessBoardsFields()
        {
            ChessBoard chessboard = new ChessBoard();

            IBoardField[,] fields = chessboard.GetFields();

            var test = ((ChessBoardField) fields[0, 0]).IsFieldWhite();

            Assert.AreEqual(((ChessBoardField)fields[0, 0]).IsFieldWhite(), ((ChessBoardField)fields[0, 2]).IsFieldWhite());
            Assert.IsTrue(((ChessBoardField)fields[0, 0]).IsFieldWhite() ^ ((ChessBoardField)fields[0, 1]).IsFieldWhite());
            Assert.AreEqual(((ChessBoardField)fields[0, 0]).IsFieldWhite(), ((ChessBoardField)fields[2, 0]).IsFieldWhite());
        }

        [TestMethod]
        public void TestRigthPostCodeValidator()
        {
            RigthPostCodeValidator test = new RigthPostCodeValidator();

            Assert.IsTrue(test.IsCodeValid(Province.Dolnoslaskie, "50-013"));
        }

        [TestMethod]
        public void TestCorTest()
        {
            CorTest test = new CorTest();

            test.test();

            TestRunner test2 = new TestRunner();

            test2.test();
        }

      
    }
}
