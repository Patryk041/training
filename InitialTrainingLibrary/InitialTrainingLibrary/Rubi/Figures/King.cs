using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Rubi.Figures
{
    public class King : RubiFigure
    {
        public King(RubiCooridnates[,] cooridnates, bool isWhite)
        {
            var kind = FigureKind.King;
        }
    }
}
