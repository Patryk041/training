using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.mg;

namespace InitialTrainingLibrary.coousey
{
    class CoouseyBoard : IBoard
    {
        IBoardField[,] Bord = new IBoardField[8,8];

        public CoouseyBoard()
        {
            // setting board fields
            for (int i = 0; i < Bord.GetLength(0); i++)
            {
                for (int j = 0; j < Bord.GetLength(1); j++)
                {
                    bool isWhite = (i + j)%2 == 0;
                    Bord[i,j] = new CoouseyBoardField(isWhite, new CoouseyCoordinates(i,j));
                } 
            }

            // setting fugures
        }

        public IBoardField[,] GetFields()
        {
            return Bord;
        }

        public string GetName()
        {
            return "Coousey";
        }
    }
}
