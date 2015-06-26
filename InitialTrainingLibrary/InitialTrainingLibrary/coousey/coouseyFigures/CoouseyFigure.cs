using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    public abstract class CoouseyFigure : IFigure
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

        public bool Move(ICoordinates newCoordinates)
        {
            return 
                InsideBounds(newCoordinates) &&
                NotTheSamePosition(newCoordinates) &&
                NoFriendOnField(newCoordinates) &&
                ValidDestination(newCoordinates) &&
                WayIsEmpty(newCoordinates) &&
                TryMove(newCoordinates);           
        }

        public bool InsideBounds(ICoordinates newCoordinates)
        {
            return newCoordinates.GetX() <= 7 && newCoordinates.GetX() >= 0 &&
                   newCoordinates.GetY() <= 7 && newCoordinates.GetY() >= 0;
        }

        public bool NotTheSamePosition(ICoordinates newCoordinates)
        {
            return Coordinates.GetX() != newCoordinates.GetX() ||
                   Coordinates.GetY() != newCoordinates.GetY();
        }

        public bool NoFriendOnField(ICoordinates newCoordinates)
        {
            if (BoardFields[newCoordinates.GetX(), newCoordinates.GetY()].HasFigure())
            {
                return BoardFields[newCoordinates.GetX(), newCoordinates.GetY()].GetFigure().IsFigureWhite() != IsWhite;
            }
            return true;
        }

        public static void SetBoardFields(IBoardField[,] boardFields)
        {
            BoardFields = boardFields;
        }

        protected void SetCoordinates(ICoordinates coordinates)
        {
            Coordinates = coordinates;
        }

        public abstract bool ValidDestination(ICoordinates newCoordinates);
        public abstract bool WayIsEmpty(ICoordinates newCoordinates);

        public virtual bool TryMove(ICoordinates newCoordinates)
        {
            BoardFields[newCoordinates.GetX(), newCoordinates.GetY()].SetFigure(this);
            BoardFields[Coordinates.GetX(), Coordinates.GetY()].SetFigure(null);
            SetCoordinates(newCoordinates);

            return true;
        }
    }
}
