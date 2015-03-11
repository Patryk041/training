using InitialTrainingLibrary.Interfaces.chess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Vernathic._02_Chess.board
{
    class VBoardField : IBoardField
    {
        public bool IsFieldWhite()
        {
            //return !((x + y) % 2);
            throw new NotImplementedException();
        }

        public ICoordinates GetCoordinates()
        {
            throw new NotImplementedException();
        }

        public bool HasFigure()
        {
            throw new NotImplementedException();
        }

        public void SetFigure(IFigure figure)
        {
            throw new NotImplementedException();
        }

        public IFigure GetFigure()
        {
            throw new NotImplementedException();
        }
    }
}
