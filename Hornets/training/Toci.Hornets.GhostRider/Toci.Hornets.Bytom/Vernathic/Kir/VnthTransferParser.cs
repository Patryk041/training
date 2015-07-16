using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Bytom.Vernathic.Kir
{
	class VnthTransferParser : BankTransfersParser
	{
		public override List<BankTransfer> GetBankTransfers()
		{
			var transfers = new List<VnthTransfer>();

			return transfers.Cast<BankTransfer>().ToList();
		}

		protected override BankTransfer GetTransferEntry(string entry)
		{
			return new BankTransfer();
		}
	}
}
