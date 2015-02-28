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
        public PlayerFigures WhitePlayerFigures;
        public PlayerFigures BlackPlayerFigures;
        public Board()
        {
            WhitePlayerFigures = new PlayerFigures();
            BlackPlayerFigures = new PlayerFigures(false);

            fields = new IBoardField[8, 8];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < heigth; j++)
                {
                    if (j >= 0 && j <= 1)
                    {
                        fields[i, j] = new BoardField(i, j,
                            WhitePlayerFigures.GertFigureByCoordinates(new Coordinates(i, j)));
                    }
                    else
                    {

                            fields[i, j] = new BoardField(i, j,
                                BlackPlayerFigures.GertFigureByCoordinates(new Coordinates(i, j)));
                        
                    }
                }
            }
        }
        public IBoardField[,] GetFields()
        {
            return fields;
        }

        public string GetName()
        {
            return "Sito";
        }
    }
}
