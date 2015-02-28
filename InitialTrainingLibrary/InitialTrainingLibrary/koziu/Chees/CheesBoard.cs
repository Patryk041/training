using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.koziu.Chees
{
    public class CheesBoard:IBoard
    {
        private readonly IBoardField[,] _boardFields = new IBoardField[8,8];
        public CheesBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    _boardFields[i,j] = new BoardCheesField(i,j);
                } 
            }
            
        }
        public IBoardField[,] GetFields()
        {
            return _boardFields;
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }
    }
}
