using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Kielich.Omr
{
    public class Computer : Machine
    {
        public bool IsMoving(bool move)
        {
            return move;
        }

        public bool IsIdle(bool idle)
        {
            return idle;
        }

        public bool IsJumping(bool jump)
        {
            return jump;
        }

        public bool IsTaking(bool take)
        {
            return take;
        }

        public bool IsDamaging(bool damage)
        {
            return damage;
        }

        public bool IsRunning(bool run)
        {
            return run;
        }

        public override bool IsWorking()
        {
            return Work;
        }

        public override bool SetWork(bool work)
        {
            return Work = work;
        }
    }
}
