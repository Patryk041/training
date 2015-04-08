using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.omr.Interface
{
    interface IMove
    {
        void MoveHead(int x, int y, int z);
        void MoveRightHand(int x, int y, int z);
        void MoveLeftHand(int x, int y, int z);
        void MoveRightLeg(int x, int y, int z);
        void MoveLeftLeg(int x, int y, int z);
    }
}
