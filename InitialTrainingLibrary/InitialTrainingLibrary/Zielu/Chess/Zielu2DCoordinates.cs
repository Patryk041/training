using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Zielu.Chess
{
    class Zielu2DCoordinates : ICoordinates
    {
        protected int X;
        protected int Y;

        public Zielu2DCoordinates(int x, int y)
        {
            X = x;
            Y = y;
        }
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
