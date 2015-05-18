using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.coousey.coouseyFigures;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.mg;

namespace InitialTrainingLibrary.coousey
{
    class CoouseyBoard : IBoard
    {
        IBoardField[,] Board = new IBoardField[8,8];

        public CoouseyBoard()
        {

            int whitePawnRow = 1;
            int blackPawnRow = 6;
            int upperBlackRow = 4;
            int whiteMainRow = 0;
            int blacMainRow = 7;

            int leftRookColumn = 0;
            int rightRookColumn = 7;
            int leftHorseColumn = 1;
            int rightHorseColumn = 6;
            int leftBishopColumn = 2;
            int fightBishopColumn = 5;
            int queenColumn = 3;
            int kingColumn = 4;


            for (int i = 0; i < Board.GetLength(0); i++)
            {
                bool figureIsWhite = i < upperBlackRow;

                for (int j = 0; j < Board.GetLength(1); j++)
                {
                    // setting board fields
                    bool fieldIsWhite = (i + j)%2 == 0;
                    CoouseyCoordinates coordinates = new CoouseyCoordinates(i,j);

                    Board[i,j] = new CoouseyBoardField(fieldIsWhite, coordinates);

                    // setting fugures
                    if (i == whitePawnRow || i == blackPawnRow)
                    {
                        Board[i, j].SetFigure(CoouseyFigureFactory.GetNewFigure(figureIsWhite, coordinates, FigureKind.Pawn));
                    }
                    else if (i == whiteMainRow || i == blacMainRow)
                    {
                        if(i == leftRookColumn || i == rightRookColumn)
                            Board[i, j].SetFigure(CoouseyFigureFactory.GetNewFigure(figureIsWhite, coordinates, FigureKind.Rook));
                        if(i == leftHorseColumn || i == rightHorseColumn)
                            Board[i, j].SetFigure(CoouseyFigureFactory.GetNewFigure(figureIsWhite, coordinates, FigureKind.Rook));
                    }
                } 
            }

        }

        public IBoardField[,] GetFields()
        {
            return Board;
        }

        public string GetName()
        {
            return "Coousey";
        }
    }
}
