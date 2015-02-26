using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.dysq.Chess
{
   public abstract class Figure :IFigure, ICoordinates
   {
       protected FigureKind kindOfFigure;
       protected bool colour;
       protected ICoordinates FigureStartPosition;

       protected Figure(int x, int y, bool colour)
       {
           FigureStartPosition = new Coordinates(x,y);
           this.colour = colour;

       }

 
       public bool IsFigureWhite()
       {
           return colour;
       }

        public ICoordinates GetCoordinates()
        {
            return FigureStartPosition;
        }

        public FigureKind GetFigureKind()
        {
            return kindOfFigure;
        }

        public bool Move(ICoordinates newCoordinates)
        {
            throw new NotImplementedException();
        }

       public int GetX()
       {
           return FigureStartPosition.GetX();
       }

       public int GetY()
       {
           return FigureStartPosition.GetY();
       }
    }
}
