using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Zielu.Extensions;

namespace InitialTrainingLibrary.Zielu.Chess.ZieluFigures
{
    class ZieluKing :ZieluFigureDummy
    {
        public ZieluKing(bool isItWhite, ICoordinates startingPosition) : base(isItWhite, startingPosition)
        {
            Kind = FigureKind.King;
        }

        public override bool Move(ICoordinates newCoordinates)
        {
            return Position.KingValidation(newCoordinates);
        }
    }
}
