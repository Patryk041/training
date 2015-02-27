using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Domi.Game.Board;
using InitialTrainingLibrary.hipek._2.ChessGame;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.RS.Chess;

namespace InitialTrainingLibrary.Domi.Game.Board
{
    public class ChessGame
    {
        public IBoardField[,] DrawBoard()
        {
            ChessBoard board = new ChessBoard();
            IBoardField[,] fields = board.GetFields();
        //    IFigure figure; 

           fields[0,0].SetFigure(ChessFactory.CreateFigure(0, 0,true, FigureKind.Rook));
           fields[1,0].SetFigure(ChessFactory.CreateFigure(1,0, true, FigureKind.Horse));
           fields[2,0].SetFigure(ChessFactory.CreateFigure(2,0, true, FigureKind.Bishop));
           fields[3,0].SetFigure(ChessFactory.CreateFigure(3,0, true, FigureKind.Queen));
           fields[4,0].SetFigure(ChessFactory.CreateFigure(4,0, true, FigureKind.King));
           fields[5,0].SetFigure(ChessFactory.CreateFigure(5,0, true, FigureKind.Bishop));
           fields[6,0].SetFigure(ChessFactory.CreateFigure(6,0, true, FigureKind.Horse));
           fields[7,0].SetFigure(ChessFactory.CreateFigure(7,0, true, FigureKind.Rook));

           fields[0, 1].SetFigure(ChessFactory.CreateFigure(0,1, true, FigureKind.Pawn));
           fields[1, 1].SetFigure(ChessFactory.CreateFigure(1,1,true, FigureKind.Pawn));
           fields[2, 1].SetFigure(ChessFactory.CreateFigure(2,1, true,FigureKind.Pawn));
           fields[3, 1].SetFigure(ChessFactory.CreateFigure(3,1, true, FigureKind.Pawn));
           fields[4, 1].SetFigure(ChessFactory.CreateFigure(4,1, true, FigureKind.Pawn));
           fields[5, 1].SetFigure(ChessFactory.CreateFigure(5,1, true, FigureKind.Pawn));
           fields[6, 1].SetFigure(ChessFactory.CreateFigure(6,1, true, FigureKind.Pawn));
           fields[7, 1].SetFigure(ChessFactory.CreateFigure(7,1, true, FigureKind.Pawn));


           fields[0, 6].SetFigure(ChessFactory.CreateFigure(0, 6, false, FigureKind.Pawn));
           fields[1, 6].SetFigure(ChessFactory.CreateFigure(1, 6, false, FigureKind.Pawn));
           fields[2, 6].SetFigure(ChessFactory.CreateFigure(2, 6, false, FigureKind.Pawn));
           fields[3, 6].SetFigure(ChessFactory.CreateFigure(3, 6, false, FigureKind.Pawn));
           fields[4, 6].SetFigure(ChessFactory.CreateFigure(4, 6, false, FigureKind.Pawn));
           fields[5, 6].SetFigure(ChessFactory.CreateFigure(5, 6, false, FigureKind.Pawn));
           fields[6, 6].SetFigure(ChessFactory.CreateFigure(6, 6, false, FigureKind.Pawn));
           fields[7, 6].SetFigure(ChessFactory.CreateFigure(7, 6, false, FigureKind.Pawn));

           fields[0, 7].SetFigure(ChessFactory.CreateFigure(0, 0, false, FigureKind.Rook));
           fields[1, 7].SetFigure(ChessFactory.CreateFigure(1, 0, false, FigureKind.Horse));
           fields[2, 7].SetFigure(ChessFactory.CreateFigure(2, 0, false, FigureKind.Bishop));
           fields[3, 7].SetFigure(ChessFactory.CreateFigure(3, 0, false, FigureKind.Queen));
           fields[4, 7].SetFigure(ChessFactory.CreateFigure(4, 0, false, FigureKind.King));
           fields[5, 7].SetFigure(ChessFactory.CreateFigure(5, 0, false, FigureKind.Bishop));
           fields[6, 7].SetFigure(ChessFactory.CreateFigure(6, 0, false, FigureKind.Horse));
           fields[7, 7].SetFigure(ChessFactory.CreateFigure(7, 0, false, FigureKind.Rook));


            
            return fields; 
        }
       
      
        
    }
}
