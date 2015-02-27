using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Chmura.OtherChess.Figure;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Chmura.OtherChess.Board
{
    public class ChessBoard : Board
    {
        public ChessBoard()
        {

            fields = new ChessBoardField[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.fields[i, j] = new ChessBoardField(i, j);
                }
            }
        }

        public void SetUpFiguresOnBoard()
        {
            for (int i = 1; i < 8; i += 5)
            {
                for (int j = 0; j < 8; j++)
                {
                    fields[i, j].SetFigure(new SpecificFigure(FigureKind.Pawn, new Coordinates(i, j),
                        i < 4 ? true : false));
                }
            }
            fields[0, 0].SetFigure(new SpecificFigure(FigureKind.Rook, new Coordinates(0, 0), true));
            fields[0, 1].SetFigure(new SpecificFigure(FigureKind.Horse, new Coordinates(0, 1), true));
            fields[0, 2].SetFigure(new SpecificFigure(FigureKind.Bishop, new Coordinates(0, 2), true));
            fields[0, 3].SetFigure(new SpecificFigure(FigureKind.Queen, new Coordinates(0, 3), true));
            fields[0, 4].SetFigure(new SpecificFigure(FigureKind.King, new Coordinates(0, 4), true));
            fields[0, 5].SetFigure(new SpecificFigure(FigureKind.Bishop, new Coordinates(0, 5), true));
            fields[0, 6].SetFigure(new SpecificFigure(FigureKind.Horse, new Coordinates(0, 6), true));
            fields[0, 7].SetFigure(new SpecificFigure(FigureKind.Rook, new Coordinates(0, 7), true));

            fields[7, 0].SetFigure(new SpecificFigure(FigureKind.Rook, new Coordinates(7, 0), false));
            fields[7, 1].SetFigure(new SpecificFigure(FigureKind.Horse, new Coordinates(7, 1), false));
            fields[7, 2].SetFigure(new SpecificFigure(FigureKind.Bishop, new Coordinates(7, 2), false));
            fields[7, 3].SetFigure(new SpecificFigure(FigureKind.Queen, new Coordinates(7, 3), false));
            fields[7, 4].SetFigure(new SpecificFigure(FigureKind.King, new Coordinates(7, 4), false));
            fields[7, 5].SetFigure(new SpecificFigure(FigureKind.Bishop, new Coordinates(7, 5), false));
            fields[7, 6].SetFigure(new SpecificFigure(FigureKind.Horse, new Coordinates(7, 6), false));
            fields[7, 7].SetFigure(new SpecificFigure(FigureKind.Rook, new Coordinates(7, 7), false));

        }
    }
}
  
