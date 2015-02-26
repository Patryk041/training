using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.koziu.Chees
{
    class BoardCheesField:IBoardField
    {
        private readonly ICoordinates _coordinates;

        public BoardCheesField(int x, int y)
        {
            _coordinates = new Coordinates(x, y);
        }
        public bool IsFieldWhite()
        {
            return (_coordinates.GetX() + _coordinates.GetY())%2 == 1;
        }

        public ICoordinates GetCoordinates()
        {
            return _coordinates;
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
