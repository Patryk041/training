using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    abstract class CoouseyFigure : IFigure
    {
        protected ICoordinates Coordinates;
        protected readonly FigureKind FigureKind;
        protected readonly bool IsWhite;
        protected static IBoardField[,] BoardFields;

        protected CoouseyFigure(ICoordinates coordinates, FigureKind figureKind, bool isWhite)
        {
            Coordinates = coordinates;
            FigureKind = figureKind;
            IsWhite = isWhite;
        }

        public bool IsFigureWhite()
        {
            return IsWhite;
        }

        public ICoordinates GetCoordinates()
        {
            return Coordinates;
        }

        public FigureKind GetFigureKind()
        {
            return FigureKind;
        }

        public static void SetBoardFields(IBoardField[,] boardFields)
        {
            BoardFields = boardFields;
        }

        public bool Move(ICoordinates newCoordinates)
        {
            return
                InsideBounds(newCoordinates) &&
                NotTheSamePosition(newCoordinates) &&
                NoFriendOnField(newCoordinates) &&
                ValidDestination(Coordinates) &&    
                WayIsEmpty(newCoordinates);
        }

        private bool InsideBounds(ICoordinates newCoordinates)
        {
            return newCoordinates.GetX() <= 7 && newCoordinates.GetX() >= 0 &&
                   newCoordinates.GetY() <= 7 && newCoordinates.GetY() >= 0;
        }

        private bool NotTheSamePosition(ICoordinates newCoordinates)
        {
            return Coordinates.GetX() != newCoordinates.GetX() ||
                   Coordinates.GetY() != newCoordinates.GetY();
        }

        private bool NoFriendOnField(ICoordinates newCoordinates)
        {
            return
                   BoardFields[newCoordinates.GetX(), newCoordinates.GetY()].HasFigure() &&
                   BoardFields[newCoordinates.GetX(), newCoordinates.GetY()].GetFigure().IsFigureWhite() != IsWhite;
        }

        protected abstract bool WayIsEmpty(ICoordinates newCoordinates);
        protected abstract bool ValidDestination(ICoordinates newCoordinates);
    }
}
