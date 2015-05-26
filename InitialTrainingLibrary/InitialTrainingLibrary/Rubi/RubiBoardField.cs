using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Rubi
{
    public class RubiBoardField:IBoardField
    {
        private int x;
        private int y;
        private ICoordinates coordinates;
        private bool hasFigure;
        private RubiFigure figure;
       

        public RubiBoardField(int x, int y)
        {

            coordinates = new RubiCooridnates(x,y);
        }


        public bool IsFieldWhite()
        {
            return (GetX()+GetY())%2==0;
        }

        private int GetY()
        {
            return y;
        }

        private int GetX()
        {
            return x;
        }

        public ICoordinates GetCoordinates()
        {
            return coordinates;
        }

        public bool HasFigure()
        {
            return hasFigure;
        }

        public void SetFigure(IFigure figure)
        {
            this.figure = (RubiFigure) figure;
        }

        public IFigure GetFigure()
        {
            return figure;
        }
    }
}
