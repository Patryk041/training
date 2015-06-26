using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Rubi.Figures
{
    public class Bishop:RubiFigure
    {
        public Bishop(RubiCooridnates[,] cooridnates, bool isWhite)
        {
            var kind = FigureKind.Bishop;
        }
    }
}
