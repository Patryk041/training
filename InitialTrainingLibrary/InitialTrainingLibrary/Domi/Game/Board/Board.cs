using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Domi.Game.Board
{
    public abstract class Board : IBoard
    {
     
        protected Field[,] Fields; // tablica pól z jakiejś gry 

        public virtual IBoardField[,] GetFields()
        {
            return Fields; // zwaraca tablice pól 
        }

    }
}
