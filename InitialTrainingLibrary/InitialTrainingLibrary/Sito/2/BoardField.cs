using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Sito._2
{
    class BoardField:IBoardField
    {
        private readonly ICoordinates coordinates;

        public BoardField(int x,int y)
        {
            coordinates = new Coordinates(x,y);
        }
        public bool IsFieldWhite()
        {
            return (coordinates.GetX() + coordinates.GetY()) % 2 == 0;
        }

        public ICoordinates GetCoordinates()
        {
            return coordinates;
        }
    }
}
