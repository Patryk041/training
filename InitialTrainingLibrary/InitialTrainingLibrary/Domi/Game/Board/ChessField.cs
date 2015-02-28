using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Chmura.OtherChess.Board;
using InitialTrainingLibrary.Domi.Game.Board.Figures;

using InitialTrainingLibrary.Interfaces.chess;


namespace InitialTrainingLibrary.Domi.Game.Board
{
   public class ChessField : IBoardField    //pola gry szachy 
    {  
       protected int X;
       protected int Y;

       protected bool hasFigure;
       protected bool color; 

       protected ICoordinates getPossition;
       protected IFigure Figure; 

       public ChessField(int x, int y, bool hasFigure)
       {
           getPossition = new Cooridnate(x,y); //powołujemy współrzędne 
           this.hasFigure = hasFigure;
       }

       public ICoordinates GetCoordinates()
       {
           return getPossition; //pozycja 
       }
      
       public bool IsFieldWhite()
       {
           return ((getPossition.GetX() + getPossition.GetY())%2 == 0); //sprawdzamy czy pole jest białe 
       }

       public bool HasFigure()
       {
           return hasFigure; //zwraca czy jest figura
       }

       public void SetFigure(IFigure figure)
       { 
           this.Figure = figure;
       }

       public IFigure GetFigure()
       {
           return Figure;
           
       }
    }
}