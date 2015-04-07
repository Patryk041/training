using InitialTrainingLibrary.Interfaces.chess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.R4D3K.Chess
{
    public class Coordinates : ICoordinates
    {
        protected int x;
        protected int y;

        public Coordinates(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }
    }
}
