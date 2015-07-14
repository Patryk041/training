using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask
{
    public class SieradzPerformTransfers : PerformTransfers
    {

        protected List<object> CreateObjectList(Type targetType)
        {
            //Chciałem jakoś wydzielić powtarzanie tej samej operacji do innej metody, z testów wynika, że mi się udało.  
            Assembly myAssembly = Assembly.Load("Toci.Hornets.Sieradz");
            List<object> objectList = new List<object>();
            foreach (Type assemblyObject in myAssembly.GetTypes().Where(type => type.IsClass && !type.IsAbstract && type.IsSubclassOf(targetType)))
            {
                objectList.Add(Activator.CreateInstance(assemblyObject));
            }
            return objectList;
        }

        protected BankTransfersParser ParserConverter(object convertObject)
        {
            return (BankTransfersParser) convertObject;
        }

        protected TransferHandle HandlerConverter(object convertObject)
        {
            return (TransferHandle)convertObject;
        }
        protected override List<BankTransfersParser> GetAllParsers()
        {

            return CreateObjectList(typeof(BankTransfersParser)).ConvertAll(ParserConverter);
            /*
            List<BankTransfersParser> parsersList = new List<BankTransfersParser>();
            Assembly myAssembly = Assembly.Load("Toci.Hornets.Sieradz");
            foreach (Type type in myAssembly.GetTypes().Where(type => type.IsClass && type.IsSubclassOf(typeof(BankTransfersParser))))
            {
                parsersList.Add((BankTransfersParser)Activator.CreateInstance(type));
            }
            return parsersList;
             */
        }

        protected override List<TransferHandle> GetAllHandles()
        {
            return CreateObjectList(typeof(TransferHandle)).ConvertAll(HandlerConverter); ;
            /* 
            List<BankTransfersParser> handlersList = new List<TransferHandle>();
            Assembly myAssembly = Assembly.Load("Toci.Hornets.Sieradz");
            foreach (Type type in myAssembly.GetTypes().Where(type => type.IsClass && type.IsSubclassOf(typeof(TransferHandle))))
            {
                handlersList.Add((TransferHandle)Activator.CreateInstance(type));
            }
            return handlersList;
             */
        }

        public override void TransferAll() //tutaj możemy wprowadzić to o czym rozmawialiśmy wczoraj. 
        {
            var parsers = GetAllParsers();
            var handles = GetAllHandles();

            foreach (var parser in parsers)
            {
                var transfers = parser.GetBankTransfers();

                foreach (var transfer in transfers)
                {
                    foreach (var handle in handles)
                    {
                        handle.SendTransfer(transfer);
                    }
                }

                //odp ktore sie powiodly
            }
        }
    }
}