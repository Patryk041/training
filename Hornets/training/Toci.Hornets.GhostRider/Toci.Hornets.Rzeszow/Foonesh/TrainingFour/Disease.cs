using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Rzeszow.Foonesh.TrainingFour
{
    public class Disease
    {
        public string Name { get; set; }
        public Symptom[] Symptoms { get; set; }
        public Specialist Doctor { get; set; }
    }
}
