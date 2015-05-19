using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.coousey
{
    class CoouseyCoordinates : ICoordinates
    {
        private int _x;
        private int _y;

        public CoouseyCoordinates(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }

        public void SetX(int x)
        {
            _x = x;
        }

        public void SetY(int y)
        {
            _y = y;
        }
    }
}
