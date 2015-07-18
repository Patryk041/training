using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Wroclaw.AdamPast.GipsonKIR
{
    public class GipsonPerformTransfers : PerformTransfers
    {
        private static string MyAssemblyString = "Toci.Hornets.Wroclaw";
        Assembly myAssembly = AppDomain.CurrentDomain.Load(MyAssemblyString);
        /*public Dictionary<string, Func<BankTransfer, bool>> BankDictionary = new Dictionary<string, Func<BankTransfer, bool>>()
        {
            {"ING Bank", delegate(BankTransfer transfer) 
            { //wywolanie zapisu dla ING
                return true;
            }},
            {"BZ WBK", delegate(BankTransfer transfer)
            {
                //wywolanie zapisu dla BZWBK
                return true;
            }}
        };*/
        

        protected override List<BankTransfersParser> GetAllParsers()
        {
            var BTPlist = new List<BankTransfersParser>();
            
            foreach (var type in myAssembly.GetTypes().Where(type => type.IsClass && type.IsSubclassOf(typeof(BankTransfersParser))))
            {
                BTPlist.Add((BankTransfersParser)Activator.CreateInstance(type));
            }
            return BTPlist;
        }

        protected override List<TransferHandle> GetAllHandles()
        {
            var THlist = new List<TransferHandle>();
            
            foreach (var type in myAssembly.GetTypes().Where(type => type.IsClass && type.IsSubclassOf(typeof(TransferHandle))))
            {
                THlist.Add((TransferHandle)Activator.CreateInstance(type));
            }
            return THlist;


            /*List<TransferHandle> HandlesList = new List<TransferHandle>();
            foreach (var bank in BankDictionary)
            {
                HandlesList.Add(new GipsonTransferHandle(bank.ToString()));
            }*/

        }
    }
}