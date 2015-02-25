using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Sito._2
{
    class BoardField:IBoardField
    {
        private readonly ICoordinates coordinates;
        private IFigure figure;
        public BoardField(int x,int y,IFigure figure)
        {
            coordinates = new Coordinates(x,y);
            this.figure = figure;

        }
        public bool IsFieldWhite()
        {
            return (coordinates.GetX() + coordinates.GetY()) % 2 == 0;
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
