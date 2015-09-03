using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Toci.Hornets.Bytom.Coffee13.TaskTrainingTree
{
    public static class CoffeeDeserialization
    {
        public static List<string> SplitMainStringtoTransferStrings(string mainContent)
        {
            List<string> separatedTransfers = new List<string>();

            string[] transfersDelimiters = { "<Transfer>", "</Transfer>" };
            string[] separatedStrings = mainContent.Split(transfersDelimiters, StringSplitOptions.RemoveEmptyEntries);

            foreach (var element in separatedStrings)
            {
                if (String.IsNullOrWhiteSpace(element))
                {
                    continue;
                }
                separatedTransfers.Add(element);
            }

            separatedTransfers.RemoveAt(0);
            separatedTransfers.RemoveAt(separatedTransfers.Count - 1);

            return separatedTransfers;
        }

        public static CoffeeBankTransfer DeserializeString(string entry)
        {
            CoffeeBankTransfer transfer;

            XmlSerializer serializer = new XmlSerializer(typeof(CoffeeBankTransfer));

            using (TextReader reader = new StringReader(entry))
            {
                transfer = (CoffeeBankTransfer)serializer.Deserialize(reader);
            }
            return transfer;
        }
    }
}