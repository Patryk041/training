using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.mg.Chess
{
    class ChessBoardField :IBoardField
    {
        private ICoordinates coordinates;
        private IFigure figure;

        public ChessBoardField(int x, int y)
        {
         coordinates = new Coordinates(x,y);
        }

        public bool IsFieldWhite()
        {
            return (coordinates.GetX() + coordinates.GetY())%2 == 1;
        }

        public ICoordinates GetCoordinates()
        {
            return coordinates;
        }

        public bool HasFigure()
        {
            return figure != null;
        }

        public void SetFigure(IFigure figure)
        {
            this.figure = figure;
        }

        public IFigure GetFigure()
        {
            return figure;
        }
    }
}
