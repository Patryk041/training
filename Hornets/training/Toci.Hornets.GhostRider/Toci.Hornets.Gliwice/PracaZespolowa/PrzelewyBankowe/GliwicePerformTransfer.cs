using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Rudi;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe
{
   public class GliwicePerformTransfer : PerformTransfers
   {
       private List<BankTransfersParser> _bankTransfersList;

       //private DidiBankTransferParser _DidTransfers;
       //private RudiBankTransferParser _RudiTransfers;


       public GliwicePerformTransfer()
       {
           _bankTransfersList = new List<BankTransfersParser>();
           //_DidTransfers = new DidiBankTransferParser();
           //_RudiTransfers = new RudiBankTransferParser();
       }

        protected override List<BankTransfersParser> GetAllParsers()
        {
            ParsersGenerator generator = new ParsersGenerator();

            _bankTransfersList = generator.GetList("Gliwice");

            return _bankTransfersList;
        }

        protected override List<TransferHandle> GetAllHandles()
        {
            var generator = new HandlersGenerator();
            
            return generator.GetList("Gliwice");
        }
    }
}
