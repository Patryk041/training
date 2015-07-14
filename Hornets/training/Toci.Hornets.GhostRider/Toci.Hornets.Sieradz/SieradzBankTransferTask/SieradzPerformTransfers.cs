using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
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

        //jeśli można jakoś pozbyć się używania tych Converterów to proponujcie :) .
        protected BankTransfersParser ParserConverter(object convertObject)
        {
            return (BankTransfersParser) convertObject;
        }

        protected TransferHandle HandlesConverter(object convertObject)
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
            return CreateObjectList(typeof(TransferHandle)).ConvertAll(HandlesConverter); ;
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

        public override void TransferAll() 
        {
            var parsers = GetAllParsers();
            var handles = GetAllHandles();
            if (parsers.Count == 0 || handles.Count == 0) return;
            /*
             * Mamy tutaj trzy pętle i każdą można wywołać jako parallel - w testach musimy sprawdzić które najbardziej opłaca się parallelizować, bo wątpię że wszystkie. Stawiam
             * tylko na Parallel.ForEach(parsers, parser => ... ); bo to największy kawał, będzie tyklko tyle tasków utworzonych ile mamy parserów czyli ze 5-6. Tak czy siak zapisałem
             * na razie wszystkie, jak będziemy mieli wszyscy parsery gotowe to będzie można robić testy i mierzyć czasy
             */
            //foreach (var parser in parsers)
            Parallel.ForEach(parsers, parser =>
            {
                var transfers = parser.GetBankTransfers();

                //foreach (var transfer in transfers)
                Parallel.ForEach(transfers, transfer =>
                {
                    // foreach (var handle in handles)
                    // {
                    //     handle.SendTransfer(transfer);
                    // }
                    Parallel.ForEach(handles, handle =>
                    {
                        handle.SendTransfer(transfer);
                    });
                });

                //odp ktore sie powiodly
            });
        }
    }
}