using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.robson.ChessGame
{
    class ChessBoardField : IBoardField
    {
        private ICoordinates fieldCoordinates;
        private IFigure figure;

        public ChessBoardField(int x, int y)
        {
            fieldCoordinates = new ChessBoardFieldCoordinates(x, y);
        }
        public bool IsFieldWhite()
        {
            return (fieldCoordinates.GetX() + fieldCoordinates.GetY()) % 2 == 0;
        }

        public ICoordinates GetCoordinates()
        {
            return fieldCoordinates;
        }

        public bool HasFigure()
        {
            return figure != null;
        }

        public void SetFigure(IFigure figure)
        {
            this.figure = figure;
        }

        public IFigure GetFigure()
        {
            return figure;
        }
    }
}
