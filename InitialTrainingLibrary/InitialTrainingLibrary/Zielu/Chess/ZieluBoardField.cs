using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Zielu.Extensions;

namespace InitialTrainingLibrary.Zielu.Chess
{
    class ZieluBoardField : IBoardField
    {
        private readonly bool _white;
        private readonly ICoordinates _boardCoordinates;
        private IFigure _boardFigure;

        public ZieluBoardField(int x, int y)
        {
            _boardCoordinates = new Zielu2DCoordinates(x,y);
            _white = (x + y).IsEven();
        }

        public bool IsFieldWhite()
        {
            return _white;
        }

        public ICoordinates GetCoordinates()
        {
            return _boardCoordinates;
        }

        public bool HasFigure()
        {
            return _boardFigure != null;
        }

        public void SetFigure(IFigure figure)
        {
            _boardFigure = figure;
        }

        public IFigure GetFigure()
        {
            return _boardFigure;
        }
    }
}
