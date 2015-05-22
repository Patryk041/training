using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.validators
{
    class NoFriendOnField :IValidator
    {
        public void Validate(IFigure figure, ICoordinates newCoordinates)
        {
            /*if (figure.GetBordField()[newCoordinates.GetX(), newCoordinates.GetY()].HasFigure())
            {
                return BoardFields[newCoordinates.GetX(), newCoordinates.GetY()].GetFigure().IsFigureWhite() != IsWhite;
            }
            return true;*/
        }
    }
}
