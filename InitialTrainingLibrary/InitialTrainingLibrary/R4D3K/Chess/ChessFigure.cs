using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.R4D3K.Chess
{
    public class ChessFigure : Figure
    {
        protected Coordinates coor;
        protected FigureKind kind;
        protected bool isWhite;

        public ChessFigure(int x, int y, bool isWhite)
        {
            this.coor = new Coordinates(x,y);
            this.isWhite = isWhite;
        }
        public override ICoordinates GetCoordinates()
        {
            return coor;
        }

        public override FigureKind GetFigureKind()
        {
            return kind;
        }

        public override bool IsFigureWhite()
        {
            return isWhite;
        }

        public override bool Move(ICoordinates newCoordinates)
        {
            coor = (Coordinates)newCoordinates;
            return true;
        }
    }
}
