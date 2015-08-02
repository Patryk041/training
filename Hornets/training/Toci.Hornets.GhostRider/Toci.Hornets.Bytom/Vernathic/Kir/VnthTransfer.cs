using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Bytom.Vernathic.Kir
{
	[DataContract]
	internal class VnthTransfer : BankTransfer
	{
		[DataMember]
		public VnthAccountInfo SourceInfo { get; set; }

		[DataMember]	
		public VnthAccountInfo DestinationInfo { get; set; }

		[DataMember]
		public TransferType TransferType { get; set; }

		[DataMember]
		public decimal Amount { get; set; }

		[DataMember]
		public string TitleOfTransfer { get; set; }

		[DataMember]
		public DateTime DateOfTransfer { get; set; }

		[DataMember]
		public DateTime DateOfRecord { get; set; }
	}

	internal enum TransferType
	{
		//todo: fix transfer types (uznanie, obciążenie)
		Uznanie, Obciazenie
	}
}
