using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Sito._2
{
    public class Figure:IFigure
    {

        private bool isWhite;
        private ICoordinates coordinates;
        private FigureKind figureKind;
        private int figureId;
        public Figure(bool isWhite,FigureKind figureKind,int figureId=0)
        {
            this.figureId = figureId;
            this.figureKind = figureKind;
            this.isWhite = isWhite;
            coordinates = StartFiguresCoordinates.GetStartFigureCoordinates(figureKind,isWhite,figureId);
        }
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
