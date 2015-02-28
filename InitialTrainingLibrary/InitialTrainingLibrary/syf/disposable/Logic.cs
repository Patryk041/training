using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.disposable
{
    public class Logic
    {
        public void RunFileRead()
        {
            //using (var fdsafds = new List<int>())
            using (var fds = new FileReader())
            {
                fds.ReadText();
            }

            //fds.ReadText();
        }
    }
}
