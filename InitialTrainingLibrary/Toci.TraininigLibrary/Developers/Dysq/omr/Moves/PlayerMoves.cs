using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.omr.Moves
{
    public class PlayerMoves : BodyPartsMovesBase
    {
        public PlayerMoves(int xCoor, int yCoor, int zCoor) : base(xCoor, yCoor, zCoor)
        {
            xCoordinate = xCoor;
            yCoordinate = yCoor;
            zCoordinate = zCoor;
            
        }


    }
}
