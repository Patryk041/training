using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Chmura.DateTimeValidator;
using InitialTrainingLibrary.hipek._2.ChessGame.Figures;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.hipek._2.ChessGame
{
    public class ChessFigure : IFigure
    {
        protected FigureKind figureKind;
        protected bool isWhite;
        protected ChessCoordinates coordinates;


        public ChessFigure( int x, int y, bool isWHite)
        {
            this.isWhite = isWHite;
        }
    

        public bool IsFigureWhite()
        {
            return isWhite;
        }

        public ICoordinates GetCoordinates()
        {
            return coordinates;
        }

        public FigureKind GetFigureKind()
        {
            return figureKind;
        }

        public bool Move(ICoordinates newCoordinates)
        {
            throw new NotImplementedException();
        }
    }
}
