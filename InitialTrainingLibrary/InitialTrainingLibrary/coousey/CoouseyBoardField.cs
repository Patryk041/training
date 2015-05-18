using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey
{
    class CoouseyBoardField : IBoardField
    {
        private bool _isWhite;
        private ICoordinates _coordinates;
        private bool _hasFigure;
        private IFigure _figure;

        public CoouseyBoardField(bool isWhite, ICoordinates coordinates)
        {
            _isWhite = isWhite;
            _coordinates = coordinates;
            _hasFigure = false;
            _figure = null;
        }

        public bool IsFieldWhite()
        {
            return _isWhite;
        }

        public ICoordinates GetCoordinates()
        {
            return _coordinates;
        }

        public bool HasFigure()
        {
            return _hasFigure;
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
