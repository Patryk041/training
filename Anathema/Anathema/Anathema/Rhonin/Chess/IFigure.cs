using System;
using System.CodeDom;
using System.Security.Cryptography.X509Certificates;

namespace Anathema.Rhonin.Chess
{
    public abstract class IFigure
    {
        public abstract void Moves();

        public bool IsFigureWhite()
        {
            return true;
        }

        //public FigureKind GetFigureKind()
        //{
            
        //};

        public abstract Coordinates GetCoordinates();

        public abstract bool Move(Coordinates newCoordinates);
    }
}