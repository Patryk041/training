using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Chmura.OtherChess.Board;
using InitialTrainingLibrary.Domi.Game.Board.Figures;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Wiosna.Chess.Figures;
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

            fields[8,1].SetFigure(new Rook(8,1,false)); // black side


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
