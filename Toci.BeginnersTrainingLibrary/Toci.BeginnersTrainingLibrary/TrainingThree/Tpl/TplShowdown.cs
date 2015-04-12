using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingThree.Xml;
using Toci.BeginnersTrainingLibrary.TrainingThree.Xml.Entities;

namespace Toci.BeginnersTrainingLibrary.TrainingThree.Tpl
{
    public class TplShowdown
    {
        //D:\self\trainings\Dropbox\szkolenie\v 2.0\code\Toci.BeginnersTrainingLibrary\Toci.BeginnersTrainingLibrary\TrainingThree\Xml\data\
        protected List<Garage> AllGarages = new List<Garage>();

        public List<Garage> GetAllParsedDealersCars(string path)
        {
            AllGarages.Clear();

            var files = Directory.GetFiles(path);

            files.AsParallel().WithDegreeOfParallelism(500).ForAll(GetGarage);

            return AllGarages;
        }

        private void GetGarage(string path)
        {
            var parser = new XmlParser();

            var result = parser.Deserialize<Garage>(path);

            // lock // sum // stopwatch
            //Stopwatch
            AllGarages.Add(result);
        }
    }
}
