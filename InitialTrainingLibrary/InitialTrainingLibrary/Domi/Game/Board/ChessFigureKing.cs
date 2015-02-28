using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Domi.Game.Board
{
    class ChessFigureKing : Figure
    {
        public ChessFigureKing(int x, int y, string name) : base(x, y, name)   // lokalizacja konkretnej figury (konkretny typ, skoczek królowa itp) 
        {
            this.FigureX = x;
            this.FigureY = y;
            this.FigureName = name; 
        }

       
    }
}
