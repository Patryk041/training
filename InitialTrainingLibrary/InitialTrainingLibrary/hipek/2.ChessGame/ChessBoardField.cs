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
        ICoordinates coordinates = new ChessCoordinates();

        public ChessBoardField(int x, int y)
        {
           // coordinates.
        }


        public bool IsFieldWhite()
        {
            
            return (coordinates.GetX() + coordinates.GetY())%2 == 0;
        }

        public ICoordinates GetCoordinates()
        {
            return null;

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
