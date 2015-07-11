using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Bytom.Vernathic.Kir
{
	class VnthPerformTransfers : PerformTransfers
	{
		protected override List<BankTransfersParser> GetAllParsers()
		{
			return new List<BankTransfersParser>();
		}

		protected override List<TransferHandle> GetAllHandles()
		{
			return new List<TransferHandle>();
		}
	}
}
