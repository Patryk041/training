using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Amman.Chess
{
    class Figure : IFigure
    {
        private Coordinates actualCoordinates;
        private FigureKind kind;
        private bool isWhite;

        public Figure(Coordinates coords, FigureKind fkind, bool isItWhite)
        {
            actualCoordinates = coords;
            kind = fkind;
            isWhite = isItWhite;
        }
        public bool IsFigureWhite()
        {
            return isWhite;
        }

        public ICoordinates GetCoordinates()
        {
            return actualCoordinates;
        }

        public FigureKind GetFigureKind()
        {
            return kind;
        }

        public bool Move(ICoordinates newCoordinates)
        {
            var temp = (Coordinates) newCoordinates;
            return temp.AreCorrect();
        }
    }
}
