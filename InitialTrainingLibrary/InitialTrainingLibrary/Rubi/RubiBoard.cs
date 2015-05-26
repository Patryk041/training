using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.Rubi.Figures;

namespace InitialTrainingLibrary.Rubi
{
    public class RubiBoard : IBoard
    {
        public IBoardField[,] field;

        public RubiBoard()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    this.field[i, j] = new RubiBoardField(i, j);
                }
            }
            for (int i = 0; i < 8; i++)
            {
                field[1,i].SetFigure(new Pawn(new RubiCooridnates[1,i],true ));
                field[6, i].SetFigure(new Pawn(new RubiCooridnates[6, i], false));

            }
            field[0, 0].SetFigure(new Rook(new RubiCooridnates[0,0],true ));
            field[0, 1].SetFigure(new Horse(new RubiCooridnates[0, 1], true));
            field[0, 2].SetFigure(new Bishop(new RubiCooridnates[0, 2], true));
            field[0, 3].SetFigure(new Queen(new RubiCooridnates[0, 3], true));
            field[0, 4].SetFigure(new King(new RubiCooridnates[0, 4], true));
            field[0, 5].SetFigure(new Bishop(new RubiCooridnates[0, 5], true));
            field[0, 6].SetFigure(new Horse(new RubiCooridnates[0, 6], true));
            field[0, 7].SetFigure(new Rook(new RubiCooridnates[0, 7], true));
            
            field[6, 0].SetFigure(new Rook(new RubiCooridnates[6, 0], false));
            field[6, 1].SetFigure(new Horse(new RubiCooridnates[6, 1], false));
            field[6, 2].SetFigure(new Bishop(new RubiCooridnates[6, 2], false));
            field[6, 3].SetFigure(new Queen(new RubiCooridnates[6, 3], false));
            field[6, 4].SetFigure(new King(new RubiCooridnates[6, 4], false));
            field[6, 5].SetFigure(new Bishop(new RubiCooridnates[6, 5], false));
            field[6, 6].SetFigure(new Horse(new RubiCooridnates[6, 6], false));
            field[6, 7].SetFigure(new Rook(new RubiCooridnates[6, 7], false));

        }

        public IBoardField[,] GetFields()
        {
            return field;
        }

        public string GetName()
        {
            return ("Rubi");
        }
    }
}
