using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Zielu.Extensions;

namespace InitialTrainingLibrary.Zielu.Chess.ZieluFigures
{
    class ZieluHorse : ZieluFigureDummy
    {
        public ZieluHorse(bool isItWhite, ICoordinates startingPosition) : base(isItWhite, startingPosition)
        {
            Kind = FigureKind.Horse;
        }

        public override bool Move(ICoordinates newCoordinates)
        {
            return Position.HorseValidation(newCoordinates);
        }
    }
}
