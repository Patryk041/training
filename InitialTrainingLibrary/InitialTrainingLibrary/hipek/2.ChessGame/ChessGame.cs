using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.hipek._2.ChessGame
{
    public class ChessGame
    {

        public IBoardField[,] DrawBoard()
        {
            ChessBoard chessBoard = new ChessBoard();
            IBoardField[,] field = chessBoard.GetFields();

            //biale gora
            field[0, 0].SetFigure(ChessFigureFactory.CreateFigure(0, 0, true, FigureKind.Rook));
            field[1, 0].SetFigure(ChessFigureFactory.CreateFigure(1, 0, true, FigureKind.Horse));
            field[2, 0].SetFigure(ChessFigureFactory.CreateFigure(2, 0, true, FigureKind.Bishop));
            field[3, 0].SetFigure(ChessFigureFactory.CreateFigure(3, 0, true, FigureKind.Queen));
            field[4, 0].SetFigure(ChessFigureFactory.CreateFigure(4, 0, true, FigureKind.King));
            field[5, 0].SetFigure(ChessFigureFactory.CreateFigure(5, 0, true, FigureKind.Bishop));
            field[6, 0].SetFigure(ChessFigureFactory.CreateFigure(6, 0, true, FigureKind.Horse));
            field[7, 0].SetFigure(ChessFigureFactory.CreateFigure(7, 0, true, FigureKind.Rook));

            field[0, 1].SetFigure(ChessFigureFactory.CreateFigure(0, 1, true, FigureKind.Pawn));
            field[1, 1].SetFigure(ChessFigureFactory.CreateFigure(1, 1, true, FigureKind.Pawn));
            field[2, 1].SetFigure(ChessFigureFactory.CreateFigure(2, 1, true, FigureKind.Pawn));
            field[3, 1].SetFigure(ChessFigureFactory.CreateFigure(3, 1, true, FigureKind.Pawn));
            field[4, 1].SetFigure(ChessFigureFactory.CreateFigure(4, 1, true, FigureKind.Pawn));
            field[5, 1].SetFigure(ChessFigureFactory.CreateFigure(5, 1, true, FigureKind.Pawn));
            field[6, 1].SetFigure(ChessFigureFactory.CreateFigure(6, 1, true, FigureKind.Pawn));
            field[7, 1].SetFigure(ChessFigureFactory.CreateFigure(7, 1, true, FigureKind.Pawn));

            
            //czarne dol
            field[0, 6].SetFigure(ChessFigureFactory.CreateFigure(0, 6, false, FigureKind.Pawn));
            field[1, 6].SetFigure(ChessFigureFactory.CreateFigure(1, 6, false, FigureKind.Pawn));
            field[2, 6].SetFigure(ChessFigureFactory.CreateFigure(2, 6, false, FigureKind.Pawn));
            field[3, 6].SetFigure(ChessFigureFactory.CreateFigure(3, 6, false, FigureKind.Pawn));
            field[4, 6].SetFigure(ChessFigureFactory.CreateFigure(4, 6, false, FigureKind.Pawn));
            field[5, 6].SetFigure(ChessFigureFactory.CreateFigure(5, 6, false, FigureKind.Pawn));
            field[6, 6].SetFigure(ChessFigureFactory.CreateFigure(6, 6, false, FigureKind.Pawn));
            field[7, 6].SetFigure(ChessFigureFactory.CreateFigure(7, 6, false, FigureKind.Pawn));

            field[0, 7].SetFigure(ChessFigureFactory.CreateFigure(0, 7, false, FigureKind.Rook));
            field[1, 7].SetFigure(ChessFigureFactory.CreateFigure(1, 7, false, FigureKind.Horse));
            field[2, 7].SetFigure(ChessFigureFactory.CreateFigure(2, 7, false, FigureKind.Bishop));
            field[3, 7].SetFigure(ChessFigureFactory.CreateFigure(3, 7, false, FigureKind.Queen));
            field[4, 7].SetFigure(ChessFigureFactory.CreateFigure(4, 7, false, FigureKind.King));
            field[5, 7].SetFigure(ChessFigureFactory.CreateFigure(5, 7, false, FigureKind.Bishop));
            field[6, 7].SetFigure(ChessFigureFactory.CreateFigure(6, 7, false, FigureKind.Horse));
            field[7, 7].SetFigure(ChessFigureFactory.CreateFigure(7, 7, false, FigureKind.Rook));

            return field;
        }
        
    }
}
