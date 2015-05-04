
using InitialTrainingLibrary.Chmura.OtherChess.Board;
using InitialTrainingLibrary.Chmura.OtherChess.Figure;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Chmura.OtherChess
{
    public class ChessGame : IGame
    {
        protected ChessBoard myBoard;
        public void DrawBoard()
        {
            myBoard = new ChessBoard();
            myBoard.SetUpFiguresOnBoard();
            SpecificFigure.ResetCounter();
        }

        public void moveFigure(Coordinates oldCoor, Coordinates newCoor)
        {
           myBoard.fields[newCoor.GetX(), newCoor.GetY()].SetFigure(myBoard.fields[oldCoor.GetX(),oldCoor.GetY()].GetFigure());
           myBoard.fields[oldCoor.GetX(),oldCoor.GetY()].RemoveFigure();
        }


        public IBoard GetBoard()
        {
            DrawBoard();
            return myBoard;
        }
    }
}
