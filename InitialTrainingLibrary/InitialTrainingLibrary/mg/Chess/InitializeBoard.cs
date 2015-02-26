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
             gameBoard[1,0].SetFigure(ReturnFigure.getFigureFactory(0,0,true,FigureKind.Horse));
             gameBoard[2,0].SetFigure(ReturnFigure.getFigureFactory(0,0,true,FigureKind.Bishop));
             gameBoard[3,0].SetFigure(ReturnFigure.getFigureFactory(0,0,true,FigureKind.King));
             gameBoard[4,0].SetFigure(ReturnFigure.getFigureFactory(0,0,true,FigureKind.Queen));
             gameBoard[5,0].SetFigure(ReturnFigure.getFigureFactory(0,0,true,FigureKind.Bishop));
             gameBoard[6,0].SetFigure(ReturnFigure.getFigureFactory(0,0,true,FigureKind.Horse));
             gameBoard[7,0].SetFigure(ReturnFigure.getFigureFactory(0,0,true,FigureKind.Rook));
           
            //białe 2 rząd

            for (int i = 0; i < 8; i++)
            {
                gameBoard[i, 1].SetFigure(ReturnFigure.getFigureFactory(0, 0, true, FigureKind.Pawn));
            }

            //czarne 1 rząd
            gameBoard[0, 7].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Rook));
            gameBoard[1, 7].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Horse));
            gameBoard[2, 7].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Bishop));
            gameBoard[3, 7].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.King));
            gameBoard[4, 7].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Queen));
            gameBoard[5, 7].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Bishop));
            gameBoard[6, 7].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Horse));
            gameBoard[7, 7].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Rook));

            //czarne 2 rząd

            for (int i = 0; i < 8; i++)
            {
                gameBoard[i, 6].SetFigure(ReturnFigure.getFigureSwitch(0, 0, false, FigureKind.Pawn));
            }

           
        }
      
   
    
    }


}
