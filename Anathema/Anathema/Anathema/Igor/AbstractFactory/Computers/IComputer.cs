using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Igor.AbstractFactory.Computers
{
    public interface IComputer
    {
        string name { get; set; }
        string parameters { get; set; }
        bool working { get; set; }

        string getName();
        string getParameters();

        bool isWorking();
    }
}
