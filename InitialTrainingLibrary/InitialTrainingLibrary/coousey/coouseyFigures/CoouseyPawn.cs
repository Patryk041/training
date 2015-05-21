using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyPawn : CoouseyFigure
    {
        public CoouseyPawn(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        protected override bool ValidateMove(ICoordinates newCoordinates)
        {
            return
                base.ValidateMove(newCoordinates) &&                     // not the same position or out of bound
                Coordinates.GetX() == newCoordinates.GetX() &&           // only vertical
                
               ((IsWhite &&                                              // white
                (Coordinates.GetY() + 1 == newCoordinates.GetY()) ||     // one down               
                (Coordinates.GetY() == 1 &&                              // if first move
                 Coordinates.GetY() + 2 == newCoordinates.GetY()))||     // two down

                (!IsWhite &&                                             // white
                (Coordinates.GetY() - 1 == newCoordinates.GetY()) ||     // one up               
                (Coordinates.GetY() == 1 &&                              // if first move
                 Coordinates.GetY() - 2 == newCoordinates.GetY())));      // two up 
        }
    }
}
