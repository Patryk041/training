using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Rzeszow.KSebal.TrainingFourHomework
{
    public abstract class Research
    {
        protected string nameOfResearch;
        protected Dictionary<string, double> resultsPatient;
       // public delegate 

        protected Dictionary<string, CorrectResults> CorrectResults;
        protected Dictionary<string, double> WrongResults;

        protected Dictionary<string, Func<Dictionary<string,double>>> TypesOfDownloadPatientData;


        public abstract void CheckResearch();

        public abstract void AddTypesOfDataDownload(string name, Func<Dictionary<string, double>> add);
        public abstract bool Compare(double PatientResults,CorrectResults result);





    }
}
