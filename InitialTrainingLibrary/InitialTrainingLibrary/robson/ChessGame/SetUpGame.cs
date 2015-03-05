using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.robson.ChessGame
{
    public class SetUpGame
    {
        ChessBoard board = new ChessBoard();
        public SetUpGame()
        {
            var fields = board.GetFields();

            fields[0, 0].SetFigure(ChessBoardFigureFactory.MakeFigure(0, 0, FigureColor.White, Interfaces.chess.FigureKind.Rook));
            fields[0, 1].SetFigure(ChessBoardFigureFactory.MakeFigure(0, 1, FigureColor.White, Interfaces.chess.FigureKind.Horse));
            fields[0, 2].SetFigure(ChessBoardFigureFactory.MakeFigure(0, 2, FigureColor.White, Interfaces.chess.FigureKind.Bishop));
            fields[0, 3].SetFigure(ChessBoardFigureFactory.MakeFigure(0, 3, FigureColor.White, Interfaces.chess.FigureKind.Queen));
            fields[0, 4].SetFigure(ChessBoardFigureFactory.MakeFigure(0, 4, FigureColor.White, Interfaces.chess.FigureKind.King));
            fields[0, 5].SetFigure(ChessBoardFigureFactory.MakeFigure(0, 5, FigureColor.White, Interfaces.chess.FigureKind.Bishop));
            fields[0, 6].SetFigure(ChessBoardFigureFactory.MakeFigure(0, 6, FigureColor.White, Interfaces.chess.FigureKind.Horse));
            fields[0, 7].SetFigure(ChessBoardFigureFactory.MakeFigure(0, 7, FigureColor.White, Interfaces.chess.FigureKind.Rook));

            for(int i = 0; i < 8; i++)
            {
                fields[1, i].SetFigure(ChessBoardFigureFactory.MakeFigure(1, i, FigureColor.White, Interfaces.chess.FigureKind.Pawn));
                fields[6, i].SetFigure(ChessBoardFigureFactory.MakeFigure(6, i, FigureColor.Black, Interfaces.chess.FigureKind.Pawn));
            }

            fields[7, 0].SetFigure(ChessBoardFigureFactory.MakeFigure(7, 0, FigureColor.Black, Interfaces.chess.FigureKind.Rook));
            fields[7, 1].SetFigure(ChessBoardFigureFactory.MakeFigure(7, 1, FigureColor.Black, Interfaces.chess.FigureKind.Horse));
            fields[7, 2].SetFigure(ChessBoardFigureFactory.MakeFigure(7, 2, FigureColor.Black, Interfaces.chess.FigureKind.Bishop));
            fields[7, 3].SetFigure(ChessBoardFigureFactory.MakeFigure(7, 3, FigureColor.Black, Interfaces.chess.FigureKind.Queen));
            fields[7, 4].SetFigure(ChessBoardFigureFactory.MakeFigure(7, 4, FigureColor.Black, Interfaces.chess.FigureKind.King));
            fields[7, 5].SetFigure(ChessBoardFigureFactory.MakeFigure(7, 5, FigureColor.Black, Interfaces.chess.FigureKind.Bishop));
            fields[7, 6].SetFigure(ChessBoardFigureFactory.MakeFigure(7, 6, FigureColor.Black, Interfaces.chess.FigureKind.Horse));
            fields[7, 7].SetFigure(ChessBoardFigureFactory.MakeFigure(7, 7, FigureColor.Black, Interfaces.chess.FigureKind.Rook));
        }

        public string GetFigure(int x, int y)
        {
            string figureName;

            ChessBoardField[,] completeBoard = (ChessBoardField[,])board.GetFields();

            figureName = completeBoard[x, y].GetFigure().GetFigureKind().ToString();

            return figureName;
        }
    }
}
