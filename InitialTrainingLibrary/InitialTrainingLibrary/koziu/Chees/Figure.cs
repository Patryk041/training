using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.koziu.Chees
{
    public class Figure:IFigure
    {
        private string _color;
        private FigureKind _kind;
        private ICoordinates _coordinates = null;

        public Figure(string color, FigureKind kind)
        {
            _color = color;
            _kind = kind;
        }
        public bool IsFigureWhite()
        {
            return (_color == "white") ? true : false;
        }

        public ICoordinates GetCoordinates()
        {
            return _coordinates;
        }

        public FigureKind GetFigureKind()
        {
            return _kind;
        }

        public bool Move(ICoordinates newCoordinates)
        {
            throw new NotImplementedException();
        }
    }
}
