using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Domi.Game.Board.Figures
{
    public class King : ChessFigures
    {
        protected FigureKind Figure;

        public King(int x, int y, bool isWhite)
        {
            this.FigureKind= FigureKind.King;
            this.Cooridnate = new Cooridnate(x, y);
            this.IsWhite = isWhite; 
        }
    }
}
