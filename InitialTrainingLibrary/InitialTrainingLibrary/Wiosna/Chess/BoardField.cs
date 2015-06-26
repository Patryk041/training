using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Wiosna.Chess
{
    class BoardField : IBoardField
    {
        private int x;
        private int y;
        private bool hasFigure;
        private ICoordinates coords;
        private Figure figure;

        public BoardField(int x, int y)
        {
            coords = new Coordinates(x,y);
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public bool IsFieldWhite()
        {
            return (this.GetX() + this.GetY())%2 == 0;
        }

        public ICoordinates GetCoordinates()
        {
            return coords;
        }

        public bool HasFigure()
        {
            return hasFigure;
        }

        public void SetFigure(IFigure figure)
        {
            this.figure = (Figure)figure;
            hasFigure = true;
        }

        public IFigure GetFigure()
        {
            return figure;
        }
    }
}
