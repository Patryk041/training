using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Warrior.Db.Models;

namespace InitialTrainingLibrary.TrainingThree.Polimorphism
{
    public class TransfersSaveLogic
    {
        public void ParseTransfers()
        {
            Dictionary<string, TransfersParserBase> list = new Dictionary<string, TransfersParserBase>()
            {
                { "xml", new XmlTransfersParser()},
                { "txt", new TextFileTransfersParser()},
            };

            List<string> files = new List<string>()
            {
                @"I:\self\trainings\Dropbox\szkolenie\v 2.0\code\InitialTrainingLibrary\Toci.TraininigLibrary\data\transfer_2015-03-01_321434535_sito.txt",
                @"I:\self\trainings\Dropbox\szkolenie\v 2.0\code\InitialTrainingLibrary\Toci.TraininigLibrary\xmldata\transfer_2015-03-07_43657284832_warrior.xml",
            };

            foreach (var file in files)
            {
                var ext = file.Substring(file.Length - 3, 3);
                TransfersParserBase transfersParser = list[ext];
                var result= transfersParser.GetTransfers(file);
                TransferModel model = new TransferModel();
                foreach (var item in result)
                {
                    model.Insert(item);
                }
            }
        }
    }
}
