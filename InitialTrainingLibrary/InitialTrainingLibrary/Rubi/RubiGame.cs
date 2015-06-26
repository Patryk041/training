using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Rubi
{
    public class RubiGame:IGame
    {
        public IBoard GetBoard()
        {
            return new RubiBoard();
        }
        public string GetName()
        {
            return ("Rubi");
        }
    }
}
