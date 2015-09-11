using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Igor.AbstractFactory.Computers
{
    public class Samsung : IComputer
    {
        public string name { get; set; }
        public string parameters { get; set; }
        public bool working { get; set; }

        public Samsung()
        {
            Random rand = new Random();
            name = "Samsung";
            working = (rand.Next(1, 10) < 5 ? false : true);
            parameters = (working ? "Wiesiek pójdzie. :)" : "Wiesiek nie pójdzie. :(");
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
