using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;
using System.Drawing;

namespace InitialTrainingLibrary.robson.ChessGame
{
    public enum FigureColor
    {
        Black,
        White
    }
    public class ChessBoardFigure : IFigure
    {
        protected FigureKind figureType;
        protected ICoordinates figurePosition;
        protected FigureColor figureColor;

        public ChessBoardFigure() { }

        public ChessBoardFigure(FigureKind type, ICoordinates position, FigureColor color)
        {
            figureType = type;
            figurePosition = position;
            figureColor = color;           
        }
        public bool IsFigureWhite()
        {
            return (figureColor == FigureColor.White);
        }

        public ICoordinates GetCoordinates()
        {
            return figurePosition;
        }

        public FigureKind GetFigureKind()
        {
            return figureType;
        }

        public bool Move(ICoordinates newCoordinates)
        {
            throw new NotImplementedException();
        }
    }
}
