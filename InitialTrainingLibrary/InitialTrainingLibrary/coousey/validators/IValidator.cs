
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.validators
{
    interface IValidator
    {
        void Validate(IFigure figure, ICoordinates newCoordinates);
    }
}
