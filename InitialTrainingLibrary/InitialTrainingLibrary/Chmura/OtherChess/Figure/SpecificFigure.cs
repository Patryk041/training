using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Chmura.OtherChess.Board;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Chmura.OtherChess.Figure
{
    public class SpecificFigure : ChessFigure
    {
        protected FigureKind kind;
        protected Coordinates coor;
        protected bool isWhite;
        static int idCount = 0;
        protected int idFigure;

        public SpecificFigure(FigureKind kind, Coordinates coor, bool white)
        {
            this.kind = kind;
            this.coor = coor;
            this.isWhite = white;
            idFigure = idCount++;
        }

        public static void ResetCounter()
        {
            idCount = 0;
        }
        public override bool IsFigureWhite()
        {
            return isWhite;
        }

        public override ICoordinates GetCoordinates()
        {
            return coor;
        }

        public override FigureKind GetFigureKind()
        {
            return kind;
        }

        public override bool Move(ICoordinates newCoordinates)
        {
            coor = (Coordinates) newCoordinates;
            return true;
        }
    }
}
