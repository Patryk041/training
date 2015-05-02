using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingTwo.common;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.S2yfr4nt
{
    class S2yfr4ntIngTransferFileParser : TransferFileParser, IS2yfr4ntTransferHelper
    {
        const int entities = 6;

        private string ingSeparator = "; ";

        public string IngSeparator
        {
            get
            {
                return ingSeparator;
            }

            set
            {
                ingSeparator = value;
            }
        }

        protected override TransferEntity GetRow(string row)
        {
            var elements = StringHelper.GetSeparatedItems(ingSeparator, row);

                return EntityFill(elements);


        }


        public TransferEntity EntityFill(List<string> elements)
        {
            var entity = new TransferEntity();

            for (int i = 0; i < entities - elements.Count - 1; i++)
            {
                elements.Add("");
            }

            entity.Surname = elements[0];
            entity.Name = elements[1];
            entity.Account = elements[2];
            entity.Amount = elements[3];
            entity.Date = elements[4];
            entity.Sender = elements[5];

            return entity;
        }
    }
}
