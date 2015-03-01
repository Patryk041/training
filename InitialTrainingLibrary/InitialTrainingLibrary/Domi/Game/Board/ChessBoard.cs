using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Sito._2;

namespace InitialTrainingLibrary.Domi.Game.Board
{
    public class ChessBoard : IBoard // plansza szachów
    {
        protected IBoardField[,] Fields;
        public string[,] ColorFields = new string[8,8];
        

        public ChessBoard()
        {
            this.Fields = new ChessField[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                  
                    if (j == 0 || j == 1 || j == 6 || j == 7) { Fields[i, j] = new ChessField(i, j, true); }
                    else { Fields[i, j] = new ChessField(i, j, false); } //powołujemy pola 


                    //Fields[i, j].IsFieldWhite();        //koloruje

                    //if (Fields[i, j].IsFieldWhite() == true)
                    //{ ColorFields[i, j] = "white"; }
                    //else
                    //{ ColorFields[i, j] = "black"; }
                    ////sprawdzenie czy pola na pewno malują się na czarno i biało. 
                }
            }

        }

        public IBoardField[,] GetFields()
        {
            return Fields;
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }

        public string[,] ColorField()
        {
            return ColorFields;
        }
    }
}
