using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.validators
{
    class InsideBounds : IValidator
    {
        public void Validate(IFigure figure, ICoordinates newCoordinates)
        {
            if(!(newCoordinates.GetX() <= 7 && newCoordinates.GetX() >= 0 &&
               newCoordinates.GetY() <= 7 && newCoordinates.GetY() >= 0))
                throw new Exception("out of bounds");
        }
    }
}
