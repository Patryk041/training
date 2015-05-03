using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingTwo.common;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTrainingLibrary.TrainingTwo.S2yfr4nt
{
    class S2yfr4ntMultiBankTransferFileParser : TransferFileParser, IS2yfr4ntTransferHelper
    {
        const int entities = 5;

        private string multiBankSeparator = "\t";

        public string IngSeparator
        {
            get
            {
                return multiBankSeparator;
            }

            set
            {
                multiBankSeparator = value;
            }
        }

        protected override TransferEntity GetRow(string row)
        {
            var elements = StringHelper.GetSeparatedItems(multiBankSeparator, row);

                return EntityFill(elements);
        }



        public TransferEntity EntityFill(List<string> elements)
        {
            var entity = new TransferEntity();

            for (int i = 0; i < entities - elements.Count - 1; i++)
            {
                elements.Add("");
            }

            entity.Account = elements[0];
            entity.Date = elements[1];
            entity.Amount = elements[2];
            entity.Name = elements[3];
            entity.Surname = elements[4];

            return entity;
        }
    }
}