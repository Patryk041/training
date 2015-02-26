using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Domi.Game.Interface;

namespace InitialTrainingLibrary.Domi.Game.Board
{
    public abstract class Board : IBoard
    {
     
        protected Field[,] Fields; // tablica pól z jakiejś gry 

        public virtual IField[,] GetFields()
        {
            return Fields; // zwaraca tablice pól 
        }

    }
}
