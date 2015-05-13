using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Zielu.Extensions;

namespace InitialTrainingLibrary.Zielu.Chess.ZieluFigures
{
    class ZieluBishop : ZieluFigureDummy
    {
        public ZieluBishop(bool isItWhite, ICoordinates startingPosition) : base(isItWhite, startingPosition)
        {
            Kind = FigureKind.Bishop;
        }

        public override bool Move(ICoordinates newCoordinates)
        {
            return Position.BishopValidation(newCoordinates);
        }
    }
}
