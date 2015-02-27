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

        public ChessBoardField(int x, int y)
        {
            Coordinates = new ChessCoordinates(x, y);
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
            throw new NotImplementedException();
        }

        public void SetFigure(IFigure figure)
        {
            throw new NotImplementedException();
        }

        public IFigure GetFigure()
        {
            throw new NotImplementedException();
        }
    }
}
