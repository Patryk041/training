using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.dysq.Chess
{
    public class ChessBoardField : IBoardField
    {
        private ICoordinates ChessBoardCoordinates;
        private IFigure _figure;

        public ChessBoardField(int x, int y)
        {
            ChessBoardCoordinates = new Coordinates(x,y);
        }

        public bool IsFieldWhite()
        {
            return (GetCoordinates().GetY() + GetCoordinates().GetX())%2 == 0;
        }

        public ICoordinates GetCoordinates()
        {
            return ChessBoardCoordinates;
        }

        public bool HasFigure()
        {
            return _figure != null;
        }

        public void SetFigure(IFigure figure)
        {
            _figure = figure;
        }

        public IFigure GetFigure()
        {
            return _figure;
        }
    }
}
