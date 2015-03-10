using InitialTrainingLibrary.Interfaces.chess;
using System;
using InitialTrainingLibrary.mg;

namespace InitialTrainingLibrary.Vernathic._02_Chess
{
    public abstract class VBoard : IBoard
    {
        public IBoardField[,] GetFields()
        {
            IBoardField[,] board[8,8] = new InitializeBoard
            return board[, ];
            //throw new NotImplementedException();
            //TODO:: Create board in memory [8,8]
        }

        public string GetName()
        {
            return "Vernathic";
        }
    }
}
