using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Rzeszow.KSebal.TrainingFourHomework
{
    public class CorrectResults
    {
        public double max { get; set; }
        public double min { get; set; }

    public  CorrectResults(double minimum, double maximum)
        {
            max = maximum;
            min = minimum;
        }
    }
}
