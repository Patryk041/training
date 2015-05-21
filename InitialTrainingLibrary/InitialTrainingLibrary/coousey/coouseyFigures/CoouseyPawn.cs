using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey.coouseyFigures
{
    class CoouseyPawn : CoouseyFigure
    {
        public CoouseyPawn(ICoordinates coordinates, FigureKind figureKind, bool isWhite) : base(coordinates, figureKind, isWhite)
        {
        }

        protected override bool ValidDestination(ICoordinates newCoo)
        {
            return
                Coordinates.GetX() == newCoo.GetX() &&           // only vertical
                
              ((IsWhite &&                                              // white
               (Coordinates.GetY() + 1 == newCoo.GetY()) ||     // one down               
               (Coordinates.GetY() == 1 &&                              // if first move
                Coordinates.GetY() + 2 == newCoo.GetY()))||     // two down

               (!IsWhite &&                                             // white
               (Coordinates.GetY() - 1 == newCoo.GetY()) ||     // one up               
               (Coordinates.GetY() == 1 &&                              // if first move
                Coordinates.GetY() - 2 == newCoo.GetY())));      // two up 
        }

        protected override bool WayIsEmpty(ICoordinates newCoordinates)
        {
            throw new System.NotImplementedException();
        }
    }
}
