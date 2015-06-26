using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Rubi
{
    public class RubiCooridnates : ICoordinates
    {
        private int x;
        private int y;

        public RubiCooridnates(int x, int y)
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
