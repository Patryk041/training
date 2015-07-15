using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;


namespace Toci.Hornets.Bytom.Vernathic.Kir
{
	public class VnthJsonSeliarizer
	{
		public DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(VnthTransfer));

		//string jsonStream 
		//serializer.

	}
}
