using Toci.TraininigLibrary.Developers.Dysq.omr.Interface;

namespace Toci.TraininigLibrary.Developers.Dysq.omr.Moves
{
    public class Coordinates : ICoordinates
    {
        private int xCoordinate;
        private int yCoordinate;
        private int zCoordinate;


        public Coordinates(int x, int y, int z)
        {
            xCoordinate = x;
            yCoordinate = y;
            zCoordinate = z;
        }

        public int GetX()
        {
            return xCoordinate;
        }

        public int GetY()
        {
            return yCoordinate;
        }

        public int GetZ()
        {
            return zCoordinate;
        }
    }
}
