using System.Collections.Generic;
using System.Management.Instrumentation;

namespace Toci.Hornets.Rzeszow.KSebal.TrainingFourHomework
{
    public abstract class Disease
    {
        private string nameOfDisease;
        public List<Research> researches;
        public List<Sympthom> Sympthoms;
       // public static List<Disease> ListofDiseases;
        private List<Disease> OtherDiseaseIncreaseProbability;
        private Dictionary<ProbabilityAge, double> DangerWithAge;









    }
}