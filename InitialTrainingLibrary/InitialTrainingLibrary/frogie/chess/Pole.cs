using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.frogie.chess
{
    class Pole : IBoardField
    {
        private Wspolrzedne wspolrzedne;

        public Pole(Wspolrzedne wspolrzedne)
        {
            this.wspolrzedne = wspolrzedne;
        }

        public bool IsFieldWhite()
        {
            return (wspolrzedne.GetX() + wspolrzedne.GetY())%2 == 0;
        }

        public ICoordinates GetCoordinates()
        {
            return wspolrzedne;
        }

        public bool HasFigure()
        {
            return false;
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
