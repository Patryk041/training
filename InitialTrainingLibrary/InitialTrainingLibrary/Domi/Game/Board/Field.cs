using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Domi.Game.Board
{
   public abstract class Field : IBoardField //jakieś pola gry 
   {
       protected int x;
       protected int y;

       public Field(int x, int y)
       {
           this.x = x;
           this.y = y; 
       }

       public int GetX()
       {
           return x; 
       }

       public int GetY()
       {
           return y;
       }

       public bool IsFieldWhite()
       {
           throw new System.NotImplementedException();
       }

       public ICoordinates GetCoordinates()
       {
           throw new System.NotImplementedException();
       }

       public bool HasFigure()
       {
           throw new System.NotImplementedException();
       }

       public void SetFigure(IFigure figure)
       {
           throw new System.NotImplementedException();
       }

       public IFigure GetFigure()
       {
           throw new System.NotImplementedException();
       }
   }
}
