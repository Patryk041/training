using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.hipek._2.ChessGame
{
    public class ChessBoardField : IBoardField
    {
        protected ICoordinates Coordinates;
        protected IFigure Figure;
        protected bool hasFigure;

        public ChessBoardField(int x, int y, bool hasFigure)
        {
            Coordinates = new ChessCoordinates(x, y);
            this.hasFigure = hasFigure;

            
        }


        public bool IsFieldWhite()
        {
            
            return (Coordinates.GetX() + Coordinates.GetY())%2 == 0;
        }

        public ICoordinates GetCoordinates()
        {

            return this.Coordinates;

        }

        public bool HasFigure()
        {
            return hasFigure;
        }

        public void SetFigure(IFigure figure)
        {
             
            this.Figure = figure;
           
            //ChessFigureFactory.CreateFigure(figure.GetFigureKind());
        }

        public IFigure GetFigure()
        {
            return this.Figure;
        }
    }
}
