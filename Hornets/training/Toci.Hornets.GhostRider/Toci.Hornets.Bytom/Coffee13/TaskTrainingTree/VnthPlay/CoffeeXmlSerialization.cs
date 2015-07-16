using System.IO;
using System.Xml.Serialization;

namespace Toci.Hornets.Bytom.Coffee13.TaskTrainingTree.VnthPlay
{
	static class Coffee2XmlSerialization
	{
		public static Coffee2BankTransfer[] GetAllTransfersFromFileContent(string fileContent)
		{
			Coffee2BankTransfer[] transfers;

			XmlSerializer serializer = new XmlSerializer(typeof(Coffee2BankTransfer[]));

			using (TextReader reader = new StringReader(fileContent))
			{
				transfers = (Coffee2BankTransfer[])serializer.Deserialize(reader);
			}
			return transfers;
		}

		public static string SerializeObjectToStringEntry(Coffee2BankTransfer transfer)
		{
			XmlSerializer xmlSerializer = new XmlSerializer(typeof(Coffee2BankTransfer));

			using (StringWriter entry = new StringWriter())
			{
				xmlSerializer.Serialize(entry, transfer);
				return entry.ToString();
			}
		}

		private static string SerializeOneEntry(Coffee2BankTransfer transfer)
		{

			XmlSerializer serializer = new XmlSerializer(typeof(Coffee2BankTransfer));

			string entry = "";
			
			 
				// xmlWriter = new XmlSerializationWriter();
				//entry = serializer.Serialize(transfer, xmlWriter);
			
			return entry;

		}

		public static string GetStringEntryFromTransfer(Coffee2BankTransfer transfer)
		{
			string entry = "";

			return entry;
		}

		public static Coffee2BankTransfer GetTransferFromArrayItem()
		{
			return new Coffee2BankTransfer();
		}
	}
}
