using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.TrainingFour.Reflection.Training
{
    public class Kobieta
    {
        public string WyrazTwarzy { get; set; }

        public string RodzajUsmiechu;

        protected string Mysli { get; set; }

        protected string Emocje;

        private string ToCoNaPrawdeMysli { get; set; }

        private string ToCoNaPrawdeCzuje;

        public Kobieta()
        {
            
        }

        public Kobieta(string sekret)
        {
            ToCoNaPrawdeCzuje = sekret;
        }

        public void NiechPoczujeSieLepiej(string wibrator)
        {
            
        }

        private int IleMaWibratorow()
        {
            return 1;
        }
    }
}
