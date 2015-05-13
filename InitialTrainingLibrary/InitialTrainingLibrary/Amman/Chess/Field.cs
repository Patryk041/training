using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Amman.Chess
{
    class Field : IBoardField
    {
        
        private Coordinates coords;
        private Figure actualFigure;

        public Field(Coordinates coordinates, Figure figure)
        {
            coords = coordinates;
            actualFigure = figure;
        }

        public bool IsFieldWhite()
        {
            return (coords.GetX() + coords.GetY())%2 == 0;
        }

        public ICoordinates GetCoordinates()
        {
            return coords;
        }

        public bool HasFigure()
        {
            return this.actualFigure != null;
        }

        public void SetFigure(IFigure figure)
        {
            this.actualFigure = (Figure) figure;
        }

        public IFigure GetFigure()
        {
           return actualFigure;
        }
    }
}
