using InitialTrainingLibrary.Interfaces.chess;
using System;

namespace InitialTrainingLibrary.Vernathic._02_Chess
{
    public abstract class Board : IBoard
    {
        public IBoardField[,] GetFields()
        {
            throw new NotImplementedException();
        }
    }
}
