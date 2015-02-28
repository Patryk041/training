using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.frogie.chess
{
    public class Szachownica : IBoard
    {
        private IBoardField[,] PolaSzachowe = new IBoardField[8,8];

        public Szachownica()
        {
            for (int i = 0; i < PolaSzachowe.GetLength(0); i++)
            {
                for (int j = 0; j < PolaSzachowe.GetLength(1); j++)
                {
                    PolaSzachowe[i,j] = new Pole(new Wspolrzedne(i,j));
                }
            }
        }

        public IBoardField[,] GetFields()
        {
           return PolaSzachowe; 
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }
    }
}
