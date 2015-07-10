namespace Toci.Hornets.GhostRider.TrainingTwo.Generics.Factory.ChessFigures
{
    public static class ChessFactory
    {
        public static Figure GetFigureInstance(FigureType type)
        {
            switch (type)
            {
                 case FigureType.Bishop:
                    return new Bishop();

            }

            return null;
        }
    }
}