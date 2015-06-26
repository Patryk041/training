using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Zielu.Extensions;

namespace InitialTrainingLibrary.Zielu.Chess.ZieluFigures
{
    class ZieluQueen : ZieluFigureDummy
    {
        public ZieluQueen(bool isItWhite, ICoordinates startingPosition) : base(isItWhite, startingPosition)
        {
            Kind = FigureKind.Queen;
        }

        public override bool Move(ICoordinates newCoordinates)
        {
            return Position.QueenValidation(newCoordinates);
        }
    }
}
