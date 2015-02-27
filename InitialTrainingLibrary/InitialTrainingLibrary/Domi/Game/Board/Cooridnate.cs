using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.Domi.Game.Board
{
  public class Cooridnate : ICoordinates
  {
      protected int X;
      protected int Y;
      public Cooridnate(int x, int y)
      {
          this.X = x;   //współrzędne pola 
          this.Y = y;
      }
      public int GetX()
      {
          return X;
      }

      public int GetY()
      {
          return Y;
      }
    }
}
