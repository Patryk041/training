using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Amman.Chess
{
    class Coordinates : ICoordinates
    {
        private int x;
        private int y;

        public Coordinates(int x_coord, int y_coord)
        {
            x = x_coord;
            y = y_coord;
        }
        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public bool AreCorrect()
        {
            return x < 8 && x >= 0 && y < 8 && y >= 0;
        }
    }
}
