using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    public abstract class CoouseyPawn : CoouseyFigure
    {
        protected CoouseyPawn(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        public override bool ValidDestination(ICoordinates newCoordinates)
        {
            return
                OneStepForward(newCoordinates) ||
                TwoStepsForward(newCoordinates) ||
                LeftStep(newCoordinates) ||
                RightStep(newCoordinates);
        }

        public abstract override bool WayIsEmpty(ICoordinates newCoordinates);

        public override bool TryMove(ICoordinates newCoordinates)
        {
            if ((OneStepForward(newCoordinates) &&
                 !BoardFields[newCoordinates.GetX(), newCoordinates.GetY()].HasFigure()) ||
                (TwoStepsForward(newCoordinates) &&
                !BoardFields[newCoordinates.GetX(), newCoordinates.GetY()].HasFigure()) ||
                (LeftStep(newCoordinates) &&
                 BoardFields[newCoordinates.GetX(), newCoordinates.GetY()].HasFigure()) ||
                (RightStep(newCoordinates) &&
                BoardFields[newCoordinates.GetX(), newCoordinates.GetY()].HasFigure()))
            {
                base.TryMove(newCoordinates);
                return true;
            }
            return false;
        }

        protected abstract bool OneStepForward(ICoordinates newCoordinates);

        protected abstract bool TwoStepsForward(ICoordinates newCoordinates);

        protected abstract bool LeftStep(ICoordinates newCoordinates);

        protected abstract bool RightStep(ICoordinates newCoordinates);
    }
}
