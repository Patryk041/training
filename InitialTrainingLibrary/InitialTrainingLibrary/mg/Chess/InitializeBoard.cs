using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.dysq.Chess.Figures;
using InitialTrainingLibrary.Interfaces.chess;
using InitialTrainingLibrary.mg.Chess;
using InitialTrainingLibrary.mg.Chess.Figures;


namespace InitialTrainingLibrary.mg
{
    public class InitializeBoard
    {
        public ChessBoard ChessBoard { get; private set; }

        public InitializeBoard()
        {
            ChessBoard = new ChessBoard();
            var gameBoard = ChessBoard.GetFields(); //zwraca planszę gry 8x8

           
            //białe 1 rząd
             gameBoard[0,0].SetFigure(ReturnFigure.getFigureFactory(0,0,true,FigureKind.Rook));
             gameBoard[0,1].SetFigure(ReturnFigure.getFigureFactory(0,0,true,FigureKind.Horse));
             gameBoard[0,2].SetFigure(ReturnFigure.getFigureFactory(0,0,true,FigureKind.Bishop));
             gameBoard[0,3].SetFigure(ReturnFigure.getFigureFactory(0,0,true,FigureKind.King));
             gameBoard[0,4].SetFigure(ReturnFigure.getFigureFactory(0,0,true,FigureKind.Queen));
             gameBoard[0,5].SetFigure(ReturnFigure.getFigureFactory(0,0,true,FigureKind.Bishop));
             gameBoard[0,6].SetFigure(ReturnFigure.getFigureFactory(0,0,true,FigureKind.Horse));
             gameBoard[0,7].SetFigure(ReturnFigure.getFigureFactory(0,0,true,FigureKind.Rook));
           
            //białe 2 rząd

            for (int i = 0; i < 8; i++)
            {
                gameBoard[1, i].SetFigure(ReturnFigure.getFigureFactory(0, 0, true, FigureKind.Pawn));
            }

            //czarne 1 rząd
            gameBoard[7, 0].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Rook));
            gameBoard[7, 1].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Horse));
            gameBoard[7, 2].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Bishop));
            gameBoard[7, 3].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.King));
            gameBoard[7, 4].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Queen));
            gameBoard[7, 5].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Bishop));
            gameBoard[7, 6].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Horse));
            gameBoard[7, 7].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Rook));

            //czarne 2 rząd

            for (int i = 0; i < 8; i++)
            {
                gameBoard[7, i].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Pawn));
            }

           
        }
      
   
    
    }


}
