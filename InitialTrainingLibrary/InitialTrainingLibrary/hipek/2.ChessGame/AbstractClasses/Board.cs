using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.hipek._2.ChessGame.AbstractClasses
{
    public abstract class Board : IBoard
    {
        public IBoardField[,] GetFields()
        {
            throw new NotImplementedException();
        }
    }
}
