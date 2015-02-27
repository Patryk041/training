using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Chmura.OtherChess.Figure;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Chmura.OtherChess.Board
{
    public abstract class BoardField : IBoardField
    {
        protected int X;
        protected int Y;
        protected bool hasFigure;
        protected ChessFigure plantedFigure;

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }

        public bool IsFieldWhite()
        {
            return (this.GetX() + this.GetY()) % 2 == 0;
        }

        public ICoordinates GetCoordinates()
        {
            Coordinates coor = new Coordinates(GetX(), GetY());
            return coor;
        }

        public bool HasFigure()
        {
            return hasFigure;
        }

        public void SetFigure(IFigure figure)
        {
            plantedFigure = (ChessFigure) figure;
            hasFigure = true;

        }

        public IFigure GetFigure()
        {
            return plantedFigure;
        }

        public void RemoveFigure()
        {
            plantedFigure = null;
            hasFigure = false;
        }
    }
}
