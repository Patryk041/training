using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Rubi
{
    public class RubiFigure:IFigure
    {
        private RubiCooridnates cooridnates;
        private FigureKind figureKind;
        private bool isFigureWhite;
        private bool move;


        public bool IsFigureWhite()
        {
            return isFigureWhite;
        }

        public ICoordinates GetCoordinates()
        {
            return cooridnates;
        }

        public FigureKind GetFigureKind()
        {
            return figureKind;
        }

        public bool Move(ICoordinates newCoordinates)
        {
            return move;
        }
    }
}
