using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.minesweepershowdown.interfaces
{
    public interface IBoardField
    {
        int GetX();

        int GetY();

        bool IsFieldWhite();
    }
}
