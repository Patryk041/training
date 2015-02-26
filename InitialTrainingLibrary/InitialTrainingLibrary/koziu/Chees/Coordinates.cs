using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.koziu.Chees
{
    class Coordinates:ICoordinates
    {
        private readonly int _x;
        private readonly int _y;

        public Coordinates(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }
    }
}
