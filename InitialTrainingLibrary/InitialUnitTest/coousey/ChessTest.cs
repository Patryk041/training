
using System.Diagnostics;
using InitialTrainingLibrary.coousey;
using InitialTrainingLibrary.coousey.coouseyFigures;
using InitialTrainingLibrary.Interfaces.chess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialUnitTest.coousey
{
    [TestClass]
    public class CoouseyChessTest
    {
        CoouseyChessGame _chessGame = new CoouseyChessGame();

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
        public void CoouseyFieldCoordinatesTest()
        {
            // ture
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 0].GetCoordinates().GetX() == 0);
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 0].GetCoordinates().GetY() == 0);

            Assert.IsTrue(_chessGame.GetBoard().GetFields()[1, 6].GetCoordinates().GetX() == 1);
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[1, 6].GetCoordinates().GetY() == 6);
            // false
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[0, 0].GetCoordinates().GetX() == 1);
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[0, 0].GetCoordinates().GetY() == 3);
        }

        [TestMethod]
        public void CoouseyFigureCoordinatesTest()
        {
            // ture
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 0].GetFigure().GetCoordinates().GetX() == 0);
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 0].GetFigure().GetCoordinates().GetY() == 0);

            Assert.IsTrue(_chessGame.GetBoard().GetFields()[1, 6].GetFigure().GetCoordinates().GetX() == 1);
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[1, 6].GetFigure().GetCoordinates().GetY() == 6);
            // false
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[0, 0].GetFigure().GetCoordinates().GetX() == 1);
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[0, 0].GetFigure().GetCoordinates().GetY() == 3);
        }

        [TestMethod]
        public void CoouseyHasFieldFigureTest()
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
    
        [TestMethod]
        public void CoouseyInsideboundsTest()
        { 
            // inside
            Assert.IsTrue(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).InsideBounds(new CoouseyCoordinates(4, 4)));
            Assert.IsTrue(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).InsideBounds(new CoouseyCoordinates(7, 7)));
            Assert.IsTrue(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).InsideBounds(new CoouseyCoordinates(0, 0)));
            // outside
            Assert.IsFalse(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).InsideBounds(new CoouseyCoordinates(-1, -2)));
            Assert.IsFalse(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).InsideBounds(new CoouseyCoordinates(8, 3)));
        }

        [TestMethod]
        public void CoouseyNotTheSamePositionTest()
        {
            // true
            Assert.IsTrue(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).NotTheSamePosition(new CoouseyCoordinates(0, 6)));
            Assert.IsTrue(((CoouseyRook)_chessGame.GetBoard().GetFields()[7, 7].GetFigure()).NotTheSamePosition(new CoouseyCoordinates(1, 1)));
            //false
            Assert.IsFalse(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).NotTheSamePosition(new CoouseyCoordinates(0, 0)));
            Assert.IsFalse(((CoouseyRook)_chessGame.GetBoard().GetFields()[7, 7].GetFigure()).NotTheSamePosition(new CoouseyCoordinates(7, 7)));
        }

        [TestMethod]
        public void CoouseyNoFriendOnFieldTest()
        {
            // empty
            Assert.IsTrue(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).NoFriendOnField(new CoouseyCoordinates(3, 3)));
            Assert.IsTrue(((CoouseyRook)_chessGame.GetBoard().GetFields()[7, 7].GetFigure()).NoFriendOnField(new CoouseyCoordinates(4, 4)));
            // enemy for white
            Assert.IsTrue(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).NoFriendOnField(new CoouseyCoordinates(1, 6)));
            // enemy for black
            Assert.IsTrue(((CoouseyRook)_chessGame.GetBoard().GetFields()[7, 7].GetFigure()).NoFriendOnField(new CoouseyCoordinates(1, 1)));
            // friend for white
            Assert.IsFalse(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).NoFriendOnField(new CoouseyCoordinates(0, 0)));
            // firend for black
            Assert.IsFalse(((CoouseyRook)_chessGame.GetBoard().GetFields()[7, 7].GetFigure()).NoFriendOnField(new CoouseyCoordinates(7, 7)));
        }

        [TestMethod]
        public void CoouseyRookValidDestinationTest()
        {
            // true
            Assert.IsTrue(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).ValidDestination(new CoouseyCoordinates(0, 6)));
            Assert.IsTrue(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).ValidDestination(new CoouseyCoordinates(3, 0)));
            Assert.IsTrue(((CoouseyRook)_chessGame.GetBoard().GetFields()[7, 7].GetFigure()).ValidDestination(new CoouseyCoordinates(7, 3)));
            Assert.IsTrue(((CoouseyRook)_chessGame.GetBoard().GetFields()[7, 7].GetFigure()).ValidDestination(new CoouseyCoordinates(5, 7)));
            //false
            Assert.IsFalse(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).ValidDestination(new CoouseyCoordinates(3, 3)));
            Assert.IsFalse(((CoouseyRook)_chessGame.GetBoard().GetFields()[7, 7].GetFigure()).ValidDestination(new CoouseyCoordinates(5, 6)));
        }

        [TestMethod]
        public void CoouseyHorseValidDestinationTest()
        {
            // true
            Assert.IsTrue(((CoouseyHorse)_chessGame.GetBoard().GetFields()[1, 0].GetFigure()).ValidDestination(new CoouseyCoordinates(0, 2)));
            Assert.IsTrue(((CoouseyHorse)_chessGame.GetBoard().GetFields()[1, 0].GetFigure()).ValidDestination(new CoouseyCoordinates(2, 2)));
            Assert.IsTrue(((CoouseyHorse)_chessGame.GetBoard().GetFields()[6, 7].GetFigure()).ValidDestination(new CoouseyCoordinates(4, 6)));
            Assert.IsTrue(((CoouseyHorse)_chessGame.GetBoard().GetFields()[6, 7].GetFigure()).ValidDestination(new CoouseyCoordinates(7, 5)));
            //false
            Assert.IsFalse(((CoouseyHorse)_chessGame.GetBoard().GetFields()[1, 0].GetFigure()).ValidDestination(new CoouseyCoordinates(4, 0)));
            Assert.IsFalse(((CoouseyHorse)_chessGame.GetBoard().GetFields()[6, 7].GetFigure()).ValidDestination(new CoouseyCoordinates(7, 7)));
        }

        [TestMethod]
        public void CoouseyBishopValidDestinationTest()
        {
            // true
            Assert.IsTrue(((CoouseyBishop)_chessGame.GetBoard().GetFields()[2, 0].GetFigure()).ValidDestination(new CoouseyCoordinates(3, 1)));
            Assert.IsTrue(((CoouseyBishop)_chessGame.GetBoard().GetFields()[2, 0].GetFigure()).ValidDestination(new CoouseyCoordinates(5, 3)));
            Assert.IsTrue(((CoouseyBishop)_chessGame.GetBoard().GetFields()[5, 7].GetFigure()).ValidDestination(new CoouseyCoordinates(7, 5)));
            //false
            Assert.IsFalse(((CoouseyBishop)_chessGame.GetBoard().GetFields()[2, 0].GetFigure()).ValidDestination(new CoouseyCoordinates(2, 5)));
            Assert.IsFalse(((CoouseyBishop)_chessGame.GetBoard().GetFields()[5, 7].GetFigure()).ValidDestination(new CoouseyCoordinates(7, 7)));
        }

        [TestMethod]
        public void CoouseyQueenValidDestinationTest()
        {
            // true
            Assert.IsTrue(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 0].GetFigure()).ValidDestination(new CoouseyCoordinates(3, 5)));
            Assert.IsTrue(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 0].GetFigure()).ValidDestination(new CoouseyCoordinates(6, 3)));
            Assert.IsTrue(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 7].GetFigure()).ValidDestination(new CoouseyCoordinates(0, 7)));
            //false
            Assert.IsFalse(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 0].GetFigure()).ValidDestination(new CoouseyCoordinates(0, 2)));
            Assert.IsFalse(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 7].GetFigure()).ValidDestination(new CoouseyCoordinates(4, 4)));
            Assert.IsFalse(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 7].GetFigure()).ValidDestination(new CoouseyCoordinates(7, 6)));
        }

        [TestMethod]
        public void CoouseykingValidDestinationTest()
        {
            // true
            Assert.IsTrue(((CoouseyKing)_chessGame.GetBoard().GetFields()[4, 0].GetFigure()).ValidDestination(new CoouseyCoordinates(5, 1)));
            Assert.IsTrue(((CoouseyKing)_chessGame.GetBoard().GetFields()[4, 0].GetFigure()).ValidDestination(new CoouseyCoordinates(4, 1)));
            Assert.IsTrue(((CoouseyKing)_chessGame.GetBoard().GetFields()[4, 7].GetFigure()).ValidDestination(new CoouseyCoordinates(5, 7)));
            // false
            Assert.IsFalse(((CoouseyKing)_chessGame.GetBoard().GetFields()[4, 0].GetFigure()).ValidDestination(new CoouseyCoordinates(2, 0)));
            Assert.IsFalse(((CoouseyKing)_chessGame.GetBoard().GetFields()[4, 7].GetFigure()).ValidDestination(new CoouseyCoordinates(5, 5)));
            Assert.IsFalse(((CoouseyKing)_chessGame.GetBoard().GetFields()[4, 7].GetFigure()).ValidDestination(new CoouseyCoordinates(4, 5)));
        }

        [TestMethod]
        public void CoouseyPawnValidDestinationTest()
        {
            // true
            Assert.IsTrue(((CoouseyPawn)_chessGame.GetBoard().GetFields()[1, 1].GetFigure()).ValidDestination(new CoouseyCoordinates(1, 2)));
            Assert.IsTrue(((CoouseyPawn)_chessGame.GetBoard().GetFields()[2, 1].GetFigure()).ValidDestination(new CoouseyCoordinates(2, 3)));
            Assert.IsTrue(((CoouseyPawn)_chessGame.GetBoard().GetFields()[3, 6].GetFigure()).ValidDestination(new CoouseyCoordinates(4, 5)));
            // false
            Assert.IsFalse(((CoouseyPawn)_chessGame.GetBoard().GetFields()[5, 1].GetFigure()).ValidDestination(new CoouseyCoordinates(5, 4)));
            Assert.IsFalse(((CoouseyPawn)_chessGame.GetBoard().GetFields()[6, 6].GetFigure()).ValidDestination(new CoouseyCoordinates(5, 6)));
            Assert.IsFalse(((CoouseyPawn)_chessGame.GetBoard().GetFields()[7, 6].GetFigure()).ValidDestination(new CoouseyCoordinates(0, 0)));
        }

        [TestMethod]
        public void CoouseyEmptyWayTest()
        {
            
            Assert.IsTrue(((CoouseyPawn)_chessGame.GetBoard().GetFields()[1, 1].GetFigure()).WayIsEmpty(new CoouseyCoordinates(1, 2)));
            Assert.IsTrue(((CoouseyPawn)_chessGame.GetBoard().GetFields()[1, 1].GetFigure()).WayIsEmpty(new CoouseyCoordinates(1, 3)));
            // pawns in the way
            Assert.IsFalse(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(0, 4)));
            Assert.IsFalse(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(5, 0)));
            Assert.IsFalse(((CoouseyBishop)_chessGame.GetBoard().GetFields()[2, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(0, 2)));
            Assert.IsFalse(((CoouseyBishop)_chessGame.GetBoard().GetFields()[2, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(5, 3)));
            Assert.IsFalse(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(3, 5)));
            Assert.IsFalse(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(6, 3)));
            Assert.IsFalse(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(0, 3)));

            for (int i = 0; i < 8; i++)
            {
                _chessGame.GetBoard().GetFields()[i,1].SetFigure(null);
            }

            // no pawns
            Assert.IsTrue(((CoouseyRook)_chessGame.GetBoard().GetFields()[0, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(0, 4)));           
            Assert.IsTrue(((CoouseyBishop)_chessGame.GetBoard().GetFields()[2, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(0, 2)));
            Assert.IsTrue(((CoouseyBishop)_chessGame.GetBoard().GetFields()[2, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(2, 5)));
            Assert.IsTrue(((CoouseyBishop)_chessGame.GetBoard().GetFields()[2, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(5, 3)));
            Assert.IsTrue(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(3, 5)));
            Assert.IsTrue(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(6, 3)));
            Assert.IsTrue(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(0, 3)));
            

            
            _chessGame.GetBoard().GetFields()[1, 1].SetFigure(CoouseyFigureFactory.GetNewFigureByKind(FigureKind.Pawn, new CoouseyCoordinates(1,1), true));
            _chessGame.GetBoard().GetFields()[1, 2].SetFigure(CoouseyFigureFactory.GetNewFigureByKind(FigureKind.Pawn, new CoouseyCoordinates(1, 2), true));
            
            // pawn in front of pawn
            Assert.IsFalse(((CoouseyPawn)_chessGame.GetBoard().GetFields()[1, 1].GetFigure()).WayIsEmpty(new CoouseyCoordinates(1, 3)));
            Assert.IsTrue(((CoouseyPawn)_chessGame.GetBoard().GetFields()[1, 1].GetFigure()).WayIsEmpty(new CoouseyCoordinates(1, 2)));

            // pawn few steps in front of queen
            _chessGame.GetBoard().GetFields()[3, 4].SetFigure(CoouseyFigureFactory.GetNewFigureByKind(FigureKind.Pawn, new CoouseyCoordinates(3, 4), true));
            Assert.IsTrue(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(3, 3)));
            Assert.IsFalse(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(3, 5)));
            Assert.IsFalse(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(3, 7)));
            Assert.IsTrue(((CoouseyQueen)_chessGame.GetBoard().GetFields()[3, 0].GetFigure()).WayIsEmpty(new CoouseyCoordinates(7, 4)));
        }

        [TestMethod]
        public void CoouseyFinalChessTest()
        {
            _chessGame = new CoouseyChessGame();

            Assert.IsFalse(_chessGame.GetBoard().GetFields()[0, 1].GetFigure().Move(new CoouseyCoordinates(1, 1)));
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 1].GetFigure().Move(new CoouseyCoordinates(0, 3)));
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[0, 3].GetFigure().Move(new CoouseyCoordinates(0, 2)));
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[0, 3].GetFigure().Move(new CoouseyCoordinates(1, 3)));
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[0, 3].GetFigure().Move(new CoouseyCoordinates(1, 4)));
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 3].GetFigure().Move(new CoouseyCoordinates(0, 4)));
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 4].GetFigure().Move(new CoouseyCoordinates(0, 5)));
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[0, 6].GetFigure().Move(new CoouseyCoordinates(0, 4)));
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[0, 5].GetFigure().Move(new CoouseyCoordinates(0, 6)));
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 5].GetFigure().Move(new CoouseyCoordinates(1, 6)));
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 6].GetFigure().Move(new CoouseyCoordinates(0, 4)));
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[0, 0].GetFigure().Move(new CoouseyCoordinates(0, 6)));
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[0, 0].GetFigure().Move(new CoouseyCoordinates(0, 4)));
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[1, 0].GetFigure().Move(new CoouseyCoordinates(2, 2)));
            Assert.IsFalse(_chessGame.GetBoard().GetFields()[2, 0].GetFigure().Move(new CoouseyCoordinates(0, 2)));
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[1, 1].GetFigure().Move(new CoouseyCoordinates(1, 2)));
            Assert.IsTrue(_chessGame.GetBoard().GetFields()[2, 0].GetFigure().Move(new CoouseyCoordinates(0, 2)));
            DrawBoard(_chessGame);
        }

        public void DrawBoard(CoouseyChessGame chessGame)
        {
            string s;
            string c;

            for (int i = 0; i < _chessGame.GetBoard().GetFields().GetLength(0); i++)
            {
                s = "";

                for (int j = 0; j < _chessGame.GetBoard().GetFields().GetLength(1); j++)
                {
                    if (_chessGame.GetBoard().GetFields()[j, i].HasFigure())
                    {
                        c = _chessGame.GetBoard().GetFields()[j, i].GetFigure().IsFigureWhite() ? "w" : "b";
                        s += ("[" + c + _chessGame.GetBoard().GetFields()[j, i].GetFigure().GetFigureKind().ToString()[0] + "]");
                    }
                    else s += "[  ]";
                }

                Debug.Print(s);
            }
            Debug.Print("\n");
        }	

    }
}
