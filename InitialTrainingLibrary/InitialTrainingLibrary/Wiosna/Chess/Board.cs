using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Chmura.OtherChess.Board;
using InitialTrainingLibrary.Domi.Game.Board.Figures;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Wiosna.Chess.Figures;
using Bishop = InitialTrainingLibrary.Wiosna.Chess.Figures.Bishop;
using Horse = InitialTrainingLibrary.Wiosna.Chess.Figures.Horse;
using King = InitialTrainingLibrary.Wiosna.Chess.Figures.King;
using Pawn = InitialTrainingLibrary.Wiosna.Chess.Figures.Pawn;
using Queen = InitialTrainingLibrary.Wiosna.Chess.Figures.Queen;
using Rook = InitialTrainingLibrary.Wiosna.Chess.Figures.Rook;

namespace InitialTrainingLibrary.Wiosna.Chess
{
    class Board : IBoard
    {
        private IBoardField[,] fields;

        public Board()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.fields[i,j] = new BoardField(i,j);
                }
            }

            fields[0,1].SetFigure(new Rook(0,1,true)); //figure placement on the board (white side)
            fields[0, 2].SetFigure(new Horse(0, 2, true));
            fields[0, 3].SetFigure(new Bishop(0, 3, true));
            fields[0, 4].SetFigure(new King(0, 4, true));
            fields[0, 5].SetFigure(new Queen(0, 5, true));
            fields[0, 6].SetFigure(new Bishop(0, 6, true));
            fields[0, 7].SetFigure(new Horse(0, 7, true));
            fields[0, 8].SetFigure(new Rook(0, 8, true));

            for (int i = 0; i < 8; i++)
            {
                fields[1, i].SetFigure(new Pawn(i,1 , true)); // pawns placement on the both sides
                fields[7, i].SetFigure(new Pawn(7, i, true));
            }

            fields[8,1].SetFigure(new Rook(8,1,false)); // black side
            fields[8, 2].SetFigure(new Horse(8, 2, true));
            fields[8, 3].SetFigure(new Bishop(8, 3, true));
            fields[8, 4].SetFigure(new King(8, 4, true));
            fields[8, 5].SetFigure(new Queen(8, 5, true));
            fields[8, 6].SetFigure(new Bishop(8, 6, true));
            fields[8, 7].SetFigure(new Horse(8, 7, true));
            fields[8, 8].SetFigure(new Rook(8, 8, true));

        }

        public IBoardField[,] GetFields()
        {
            return fields;
        }

        public string GetName()
        {
            return "Wiosna";
        }
    }
}
