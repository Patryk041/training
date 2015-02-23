using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Sito._2
{
    public class Board:IBoard
    {
        protected IBoardField[,] fields;
        protected int width = 8;
        protected int heigth = 8;
        public Board()
        {
            fields = new IBoardField[8, 8];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < heigth; j++)
                {
                    fields[i,j] = new BoardField(i,j);
                }
            }
        }
        public IBoardField[,] GetFields()
        {
            return fields;
        }
    }
}
