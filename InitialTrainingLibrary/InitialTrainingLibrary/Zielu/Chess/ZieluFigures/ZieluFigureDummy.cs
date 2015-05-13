using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Zielu.Chess.ZieluFigures
{
    public abstract class ZieluFigureDummy : IFigure
    {
        protected bool White;
        protected ICoordinates Position;
        protected FigureKind Kind;

        protected ZieluFigureDummy(bool isItWhite, ICoordinates startingPosition)
        {
            White = isItWhite;
            Position = startingPosition;
        }
        public bool IsFigureWhite()
        {
            return White;
        }

        public ICoordinates GetCoordinates()
        {
            return Position;
        }

        public FigureKind GetFigureKind()
        {
            return Kind;
        }

        public abstract bool Move(ICoordinates newCoordinates);
    }
}
