using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Amman.Chess
{
    class Board : IBoard
    {
        private string name = "Szachy (Amman)"; // name of what? author or board?
        private Field[,] fields;

        public Board(Field[,] _fields)
        {
            fields = _fields;
        }

        public Board()
        {
            var freshFields = new Field[8,8];

            //Making empty board
            for (var i = 0; i < 8; i++)
            {
                for (var j = 0; j < 8; j++)
                {
                    var coords = new Coordinates(i, j);
                    freshFields[i, j] = new Field(coords, null);
                }
            }
            //filling it with figures
                /*  0,0 b rook
                0,1 b horse
                0,2 b bishop
                0,3 b queen
                0,4 b king
                0,5 b bishop
                0,6 b horse
                0,7 b rook
                1,x b pawn
                6,x w pawn
                7,same */

            freshFields[0, 0].SetFigure(new Figure(new Coordinates(0, 0), FigureKind.Rook, false));
            freshFields[0, 1].SetFigure(new Figure(new Coordinates(0, 1), FigureKind.Horse, false));
            freshFields[0, 2].SetFigure(new Figure(new Coordinates(0, 2), FigureKind.Bishop, false));
            freshFields[0, 3].SetFigure(new Figure(new Coordinates(0, 3), FigureKind.Queen, false));
            freshFields[0, 4].SetFigure(new Figure(new Coordinates(0, 4), FigureKind.King, false));
            freshFields[0, 5].SetFigure(new Figure(new Coordinates(0, 5), FigureKind.Bishop, false));
            freshFields[0, 6].SetFigure(new Figure(new Coordinates(0, 6), FigureKind.Horse, false));
            freshFields[0, 7].SetFigure(new Figure(new Coordinates(0, 7), FigureKind.Rook, false));
            for (int i = 0; i < 8; i++)
            {
                freshFields[1, i].SetFigure(new Figure(new Coordinates(1, i), FigureKind.Pawn, false));
                freshFields[6, i].SetFigure(new Figure(new Coordinates(6, i), FigureKind.Pawn, true));
            }
            freshFields[7, 0].SetFigure(new Figure(new Coordinates(7, 0), FigureKind.Rook, true));
            freshFields[7, 1].SetFigure(new Figure(new Coordinates(7, 1), FigureKind.Horse, true));
            freshFields[7, 2].SetFigure(new Figure(new Coordinates(7, 2), FigureKind.Bishop, true));
            freshFields[7, 3].SetFigure(new Figure(new Coordinates(7, 3), FigureKind.Queen, true));
            freshFields[7, 4].SetFigure(new Figure(new Coordinates(7, 4), FigureKind.King, true));
            freshFields[7, 5].SetFigure(new Figure(new Coordinates(7, 5), FigureKind.Bishop, true));
            freshFields[7, 6].SetFigure(new Figure(new Coordinates(7, 6), FigureKind.Horse, true));
            freshFields[7, 7].SetFigure(new Figure(new Coordinates(7, 7), FigureKind.Rook, true));

            
            fields = freshFields;

        }
        public IBoardField[,] GetFields()
        {
            var result = new IBoardField[8,8];
            foreach (var field in fields)
            {
                var x = field.GetCoordinates().GetX();
                var y = field.GetCoordinates().GetY();
                result[x, y] = field;
            }
            return result;

        }

        public string GetName()
        {
            return name;
        }
    }
}
