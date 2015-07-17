using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Bytom.Vernathic.Kir
{
	class VnthTransferHandle : TransferHandle
	{
		protected override bool Send(BankTransfer transfer)
		{
			return false;
		}
	}
}
