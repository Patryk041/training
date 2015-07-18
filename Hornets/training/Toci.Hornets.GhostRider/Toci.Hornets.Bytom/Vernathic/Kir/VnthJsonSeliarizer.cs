using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;


namespace Toci.Hornets.Bytom.Vernathic.Kir
{
	public class VnthJsonSeliarizer
	{
		public void SerializeJson()
		{
			VnthTransfer transfer = new VnthTransfer()
			{
				SourceInfo = new VnthAccountInfo(),
				DestinationInfo = new VnthAccountInfo(),
				TransferType = TransferType.Outcome,
				Amount  = 12,
				TitleOfTransfer = "",
				DateOfTransfer = new DateTime(),
				DateOfRecord = new DateTime()
			};

			DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(VnthTransfer));

			MemoryStream stream = new MemoryStream();

			serializer.WriteObject(stream, transfer);
		}

	    public VnthTransfer DeserializeJson(string json)
	    {
            var transfer = new VnthTransfer();

            //stream to object



	        return transfer;
	    }

	}
}
