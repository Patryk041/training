using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Wiosna.Chess
{
    class Figure : IFigure
    {
        private bool isFigureWhite;
        protected Coordinates coordinates;
        protected FigureKind kind;
        private Figure figure;

        public Figure(int x, int y, bool isWhite)
        {
            this.kind = kind;
            this.isFigureWhite = isWhite;
        }

        public bool IsFigureWhite()
        {
            return isFigureWhite;
        }

        public ICoordinates GetCoordinates()
        {
            return coordinates;
        }

        public FigureKind GetFigureKind()
        {
            return kind;
        }

        public bool Move(ICoordinates newCoordinates)
        {
            throw new NotImplementedException();
        }
    }
}
