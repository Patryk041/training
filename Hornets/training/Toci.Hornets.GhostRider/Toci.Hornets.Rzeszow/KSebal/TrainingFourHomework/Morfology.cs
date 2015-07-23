using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace Toci.Hornets.Rzeszow.KSebal.TrainingFourHomework
{
    public class Morfology:Research
    {
        
        public Morfology(string nameOfTypesdownload)
        {   
            this.nameOfResearch = "morfology";
            this.CorrectResults = new Dictionary<string,CorrectResults>()
            {
                {"Leukocyty",new CorrectResults(4.5,13.0)},
                {"Erytrocyty",new CorrectResults(4.1,6.2)},
                {"Hemoglobina",new CorrectResults(14.0,18.0)},
                {"Hemotokryt",new CorrectResults(40.0,54.0)}
                
            };


            resultsPatient = TypesOfDownloadPatientData[nameOfTypesdownload]();


        }

        public override void CheckResearch()
        {
            foreach (var item in CorrectResults)
            { string a = item.Key;
                
                if (resultsPatient.ContainsKey(item.Key)&& !Compare(resultsPatient[a],CorrectResults[a]))
                   WrongResults.Add(a,resultsPatient[a]);
                
            }
        }

        public override void AddTypesOfDataDownload(string name, Func<Dictionary<string, double>> add)
        {
            throw new NotImplementedException();
        }

        public override bool Compare(double PatientResults,CorrectResults result)
        {
            return (PatientResults > result.min && PatientResults < result.max);
        }
    }
}