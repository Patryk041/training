using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.hipek._2.ChessGame.Figures;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.hipek._2.ChessGame
{
    public class ChessFigure : IFigure
    {
        protected FigureKind FigureKind;

        public ChessFigure()
        {
        }

        public ChessFigure(FigureKind figure)
        {
            this.FigureKind = figure;
        }

       

        public bool IsFigureWhite()
        {
            throw new NotImplementedException();
        }

        public ICoordinates GetCoordinates()
        {
            throw new NotImplementedException();
        }

        public FigureKind GetFigureKind()
        {
            return ChessFigureFactory.CreateFigure(FigureKind).GetFigureKind();
        }

        public bool Move(ICoordinates newCoordinates)
        {
            throw new NotImplementedException();
        }
    }
}
