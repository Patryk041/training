using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Toci.Hornets.Bytom.Coffee13.TaskTrainingTree
{
	static class CoffeeXmlSerialization
	{
		public static CoffeeBankTransfer[] GetAllTransfersFromFileContent(string fileContent)
		{
			CoffeeBankTransfer[] transfers;

			XmlSerializer serializer = new XmlSerializer(typeof(CoffeeBankTransfer[]));

			using (TextReader reader = new StringReader(fileContent))
			{
				transfers = (CoffeeBankTransfer[])serializer.Deserialize(reader);
			}
			return transfers;
		}

		public static string SerializeObjectToStringEntry(CoffeeBankTransfer transfer)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(CoffeeBankTransfer));

			using (StringWriter entry = new StringWriter())
			{
				xmlSerializer.Serialize(entry, transfer);
				return entry.ToString();
			}
		}

		private static string SerializeOneEntry(CoffeeBankTransfer transfer)
		{

			XmlSerializer serializer = new XmlSerializer(typeof(CoffeeBankTransfer));

			string entry;
			
			 
				// xmlWriter = new XmlSerializationWriter();
				//entry = serializer.Serialize(transfer, xmlWriter);
			
			return entry;

		}

		public static string GetStringEntryFromTransfer(CoffeeBankTransfer transfer)
		{
			string entry = "";

			Serialize(transfer);

			return entry;
		}

		public static CoffeeBankTransfer GetTransferFromArrayItem()
		{
			
		}
	}
}
