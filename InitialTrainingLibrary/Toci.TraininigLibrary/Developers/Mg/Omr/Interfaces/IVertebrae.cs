using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Mg.Omr.Helpers;

namespace Toci.TraininigLibrary.Developers.Mg.Omr.Interfaces
{
    interface IVertebrae
    {
        void Move();
        void Eat();
        void Sleep();
        void Breath();
        void Reproduce();
        string MakeNoise();

    }
}
