using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyWhitePawn : CoouseyPawn
    {
        public CoouseyWhitePawn(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        public override bool WayIsEmpty(ICoordinates newCoordinates)
        {
            if (TwoStepsForward(newCoordinates))
            {
                if (!BoardFields[Coordinates.GetX(), Coordinates.GetY() + 1].HasFigure()) 
                {
                    return true;
                }
                return false;
            }
            return true;
        }

        protected override bool OneStepForward(ICoordinates newCoordinates)   
        {                                                               
            return 
                Coordinates.GetX() == newCoordinates.GetX() &&
                Coordinates.GetY() + 1 == newCoordinates.GetY();
        }

        protected override bool TwoStepsForward(ICoordinates newCoordinates)
        {
            return
                Coordinates.GetX() == newCoordinates.GetX() &&
                Coordinates.GetY() + 2 == newCoordinates.GetY();
        }

        protected override bool LeftStep(ICoordinates newCoordinates)
        {
            return                                                      
                Coordinates.GetY() + 1 == newCoordinates.GetY() &&
                Coordinates.GetX() - 1 == newCoordinates.GetX();            
        }

        protected override bool RightStep(ICoordinates newCoordinates)
        {
            return
                Coordinates.GetY() + 1 == newCoordinates.GetY() &&
                Coordinates.GetX() + 1 == newCoordinates.GetX();  
        }
    }
}
