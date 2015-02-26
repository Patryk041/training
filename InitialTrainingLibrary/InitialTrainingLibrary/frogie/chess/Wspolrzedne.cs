using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.frogie.chess
{
    class Wspolrzedne : ICoordinates
    {
        private int x;
        private int y;

        public Wspolrzedne(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return this.x;
            
        }

        public int GetY()
        {
            return this.y;
        }
    }
}
