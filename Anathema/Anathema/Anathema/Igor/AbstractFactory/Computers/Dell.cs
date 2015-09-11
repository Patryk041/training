using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Igor.AbstractFactory.Computers
{
    public class Dell : IComputer
    {
        public string name { get; set; }
        public string parameters { get; set; }
        public bool working { get; set; }

        public Dell()
        {
            Random rand = new Random();
            name = "Dell";
            working = (rand.Next(1, 10) < 5 ? false : true);
            parameters = "Wiesiek nie pójdzie. :(";
        }

        public string getName()
        {
            return name;
        }

        public string getParameters()
        {
            return parameters;
        }

        public bool isWorking()
        {
            return working;
        }
    }
}
