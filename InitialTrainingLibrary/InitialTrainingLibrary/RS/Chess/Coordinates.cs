using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.RS.Chess
{
    public class Coordinates : ICoordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }
    }
}
