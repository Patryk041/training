using System;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Amman.Chess
{
    class Game : IGame
    {
        private Board board;

        public Game(Board _board)
        {
            board = _board;
        }

        public IBoard GetBoard()
        {
            return board;
        }
    }
}