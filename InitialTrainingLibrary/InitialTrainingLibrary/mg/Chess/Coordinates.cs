using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.mg.Chess
{
    class Coordinates : ICoordinates
    {

        private int x { get; set; }
        private int y { get; set; }

       public Coordinates(int x, int y)
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
