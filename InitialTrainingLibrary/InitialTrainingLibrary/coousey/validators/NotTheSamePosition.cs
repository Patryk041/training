using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.validators
{
    class NotTheSamePosition : IValidator
    {
        public void Validate(IFigure figure, ICoordinates newCoordinates)
        {
            if(!(figure.GetCoordinates().GetX() != newCoordinates.GetX() ||
               figure.GetCoordinates().GetY() != newCoordinates.GetY()))
                throw new Exception("the same position");
        }
    }
}
