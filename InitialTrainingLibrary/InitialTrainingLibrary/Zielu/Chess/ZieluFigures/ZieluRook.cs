using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Zielu.Extensions;

namespace InitialTrainingLibrary.Zielu.Chess.ZieluFigures
{
    class ZieluRook : ZieluFigureDummy
    {
        public ZieluRook(bool isItWhite, ICoordinates startingPosition) : base(isItWhite, startingPosition)
        {
            Kind = FigureKind.Rook;
        }

        public override bool Move(ICoordinates newCoordinates)
        {
            return Position.RookValidation(newCoordinates);
        }
    }
}
