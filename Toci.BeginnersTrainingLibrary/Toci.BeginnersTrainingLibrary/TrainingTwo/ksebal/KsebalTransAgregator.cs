using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.ksebal
{
    public class KsebalTransAgregator : TranfersAggregator
    {


        private Dictionary<string, Func<TransferFileParser>> parsherMethods = new Dictionary
            <string, Func<TransferFileParser>>
        {
            {"ing.txt", () => new TransferFileParserIng()},
            {"multibank.txt", () => new TransferFileParserMultibank()}

        };




        public override List<TransferEntity> GetAllTransfers(List<string> filePathsList)
        {   
            
            List<TransferEntity> tranfers = new List<TransferEntity>();
            foreach (string item in filePathsList)
            {
                if (!parsherMethods.ContainsKey(key: Path.GetFileName(item)) || parsherMethods.Count==0)
                {
                    throw new Exception("Brak pliku w bazie");
                }
                StreamReader reader = new StreamReader(item);
    
                while (!reader.EndOfStream)
                {


                    tranfers.Add(parsherMethods[Path.GetFileName(item)]().GetRow(reader.ReadLine()));


                }
                

            }
            return tranfers;
        }




        public override List<string> SearchTransferFiles()
        {
            return Directory.GetFiles(@"..\..\..\Toci.BeginnersTrainingLibrary\TrainingTwo\data").ToList();
        }



      

    }
}