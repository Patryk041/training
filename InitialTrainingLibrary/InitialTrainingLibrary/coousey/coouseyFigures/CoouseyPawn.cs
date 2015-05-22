using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    public class CoouseyPawn : CoouseyFigure
    {
        public CoouseyPawn(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        public override bool ValidDestination(ICoordinates newCoordinates)
        {
            return
                (IsWhite &&
                (WhiteOneStepForward(newCoordinates) ||
                 WhiteTwoStepsForward(newCoordinates))) ||

                (!IsWhite &&
                (BlackOneStepForward(newCoordinates) ||
                BlackTwoStepsForward(newCoordinates)));
        }

        public override bool WayIsEmpty(ICoordinates newCoordinates)
        {
            if (Math.Abs(newCoordinates.GetY() - Coordinates.GetY()) == 2)
            {
                if ((IsWhite &&
                     !BoardFields[Coordinates.GetX(), Coordinates.GetY() + 1].HasFigure()) ||
                    (!IsWhite &&
                     !BoardFields[Coordinates.GetX(), Coordinates.GetY() - 1].HasFigure()))
                {
                    return true;
                }
                return false;
            }
            return true;
        }
                                                                           
        private bool WhiteOneStepForward(ICoordinates newCoordinates)   //   .
        {                                                               //  /|\
            return Coordinates.GetY() + 1 == newCoordinates.GetY() &&   
                  (Coordinates.GetX() == newCoordinates.GetX() || Coordinates.GetX() + 1 == newCoordinates.GetX() || Coordinates.GetX() - 1 == newCoordinates.GetX());
        }

        private bool BlackOneStepForward(ICoordinates newCoordinates)   //  \|/
        {                                                               //   '
            return Coordinates.GetY() - 1 == newCoordinates.GetY() &&
                  (Coordinates.GetX() == newCoordinates.GetX() || Coordinates.GetX() + 1 == newCoordinates.GetX() || Coordinates.GetX() - 1 == newCoordinates.GetX());
        }

        private bool WhiteTwoStepsForward(ICoordinates newCoordinates)
        {
            return                                                      //   .
                Coordinates.GetY() + 2 == newCoordinates.GetY() &&      //   |
                Coordinates.GetX() == newCoordinates.GetX();            //   |
        }   

        private bool BlackTwoStepsForward(ICoordinates newCoordinates)   //  |
        {                                                                //  |
            return                                                       //  '
                Coordinates.GetY() - 2 == newCoordinates.GetY() &&
                Coordinates.GetX() == newCoordinates.GetX();
        }
    }
}
