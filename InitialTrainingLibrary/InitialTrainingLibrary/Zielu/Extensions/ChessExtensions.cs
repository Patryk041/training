using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Zielu.Extensions
{
    public static class ChessExtensions
    {
        //Lepiej tego nie umiałem wymyślić :P
        public static bool RookValidation(this ICoordinates currentPosition, ICoordinates newPosition)
        {
            return (currentPosition.GetX().Distance(newPosition.GetX()) != 0 &&
                    currentPosition.GetY().Distance(newPosition.GetY()) == 0) ||
                   (currentPosition.GetX().Distance(newPosition.GetX()) == 0 &&
                    currentPosition.GetY().Distance(newPosition.GetY()) != 0);
        }

        public static bool KingValidation(this ICoordinates currentPosition, ICoordinates newPosition)
        {
            return currentPosition.GetX().Distance(newPosition.GetX()) < 2 &&
                   currentPosition.GetY().Distance(newPosition.GetY()) < 2;
        }

        public static bool BishopValidation(this ICoordinates currentPosition, ICoordinates newPosition)
        {
            return currentPosition.GetX().Distance(newPosition.GetX()) ==
                   currentPosition.GetY().Distance(newPosition.GetY());
        }

        public static bool QueenValidation(this ICoordinates currentPosition, ICoordinates newPosition)
        {
            return RookValidation(currentPosition, newPosition) || 
                   BishopValidation(currentPosition, newPosition);
        }

        public static bool PawnValidation(this ICoordinates currentPosition, ICoordinates newPosition)
        {
            return currentPosition.GetX().Distance(newPosition.GetX()) == 1 &&
                   currentPosition.GetY().Distance(newPosition.GetY()) == 0;
        }

        public static bool HorseValidation(this ICoordinates currentPosition, ICoordinates newPosition)
        {
            var a = currentPosition.GetX().Distance(newPosition.GetX());
            var b = currentPosition.GetY().Distance(newPosition.GetY());
            return (a == 2 && b == 1) || (a == 1 && b == 2);
        }
    }
}
