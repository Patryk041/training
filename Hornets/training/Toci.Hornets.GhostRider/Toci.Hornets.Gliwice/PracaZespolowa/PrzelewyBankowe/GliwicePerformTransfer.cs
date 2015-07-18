using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Rudi;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Soltys;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe
{
   public class GliwicePerformTransfer : PerformTransfers
   {
       private List<BankTransfersParser> _bankTransfersList;
       private DidiBankTransferParser _DidTransfers; // ing
       private RudiBankTransferParser _RudiTransfers; // hsbc
       private SoltysBankTransferParser _SoltysTransfers; //sant

       //private DidiBankTransferParser _DidTransfers;
       //private RudiBankTransferParser _RudiTransfers;


       public GliwicePerformTransfer()
       {
           _bankTransfersList = new List<BankTransfersParser>();

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
