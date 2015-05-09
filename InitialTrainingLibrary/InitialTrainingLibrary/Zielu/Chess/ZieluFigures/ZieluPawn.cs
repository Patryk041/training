using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Zielu.Extensions;

namespace InitialTrainingLibrary.Zielu.Chess.ZieluFigures
{
    class ZieluPawn : ZieluFigureDummy
    {
        public ZieluPawn(bool isItWhite, ICoordinates startingPosition) : base(isItWhite, startingPosition)
        {
            Kind = FigureKind.Pawn;
        }

        public override bool Move(ICoordinates newCoordinates)
        {
            return Position.PawnValidation(newCoordinates);
        }
    }
}
