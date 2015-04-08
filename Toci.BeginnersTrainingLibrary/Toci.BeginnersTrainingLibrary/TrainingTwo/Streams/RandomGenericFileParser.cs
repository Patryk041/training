using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingTwo.common;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.Streams
{
    public class RandomGenericFileParser
    {
        public string dsa { get; set; }

        private string dupa;

        public string Dupa
        {
            get
            {
                return dupa;
            }

            set
            {
                //jakas logika walidacyjna
                dupa = value;
            }
        }

        public List<TransferEntity> OpenFile(string filePath)
        {
            //FileStream str = new FileStream();
            StreamReader reader = new StreamReader(filePath);
            var tranfers = new List<TransferEntity>();
            while (!reader.EndOfStream)
            {
                tranfers.Add(GetRow(reader.ReadLine()));
            }

            return tranfers;
        }

        private TransferEntity GetRow(string row)
        {
            var elements = StringHelper.GetSeparatedItems("\t",row);

            var entity = new TransferEntity();

            entity.Name = elements[0]; //konto

            return entity;
        }
    }
}
