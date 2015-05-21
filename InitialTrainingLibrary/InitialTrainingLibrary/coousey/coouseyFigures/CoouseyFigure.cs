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

        public bool Move(ICoordinates newCoordinates)
        {
            return (ValidateMove(newCoordinates));
        }

        protected virtual bool ValidateMove(ICoordinates newCoordinates)
        {
            return
            //    (BoardFields[newCoordinates.GetX(), newCoordinates.GetY()].GetFigure() == null ||           // empty field
            //    (IsWhite &&
             //   !BoardFields[newCoordinates.GetX(),newCoordinates.GetY()].GetFigure().IsFigureWhite()) ||   // white on black 
            //   (!IsWhite &&
            //    BoardFields[newCoordinates.GetX(), newCoordinates.GetY()].GetFigure().IsFigureWhite())) &&      // black on white 

                newCoordinates.GetX() <= 7 && newCoordinates.GetX() >= 0 &&     // not out of boud
                newCoordinates.GetY() <= 7 && newCoordinates.GetY() >= 0 &&
               (newCoordinates.GetX() != Coordinates.GetX() ||                 // not the same position 
                newCoordinates.GetY() != Coordinates.GetY());
        }

        public static void SetBoardFields(IBoardField[,] boardFields)
        {
            BoardFields = boardFields;
        }
    }
}
