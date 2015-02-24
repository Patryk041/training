using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Sito._2
{
    class Figure:IFigure
    {

        private bool isWhite;
        private ICoordinates coordinates;
        private FigureKind figureKind;
        public bool IsFigureWhite()
        {
            return isWhite;
        }

        public ICoordinates GetCoordinates()
        {
            return coordinates;
        }

        public FigureKind GetFigureKind()
        {
            return figureKind;
        }

        public bool Move(ICoordinates newCoordinates)
        {
           //TODO przeciążyć operator porówniania dla ICoordinates

            if (newCoordinates == coordinates) return false;
            coordinates = new Coordinates(newCoordinates);
            return true;
        }
    }
}
