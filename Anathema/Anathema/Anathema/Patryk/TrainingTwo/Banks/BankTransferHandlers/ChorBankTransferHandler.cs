using System.Collections.Generic;
using Anathema.Generics.Chor;
using Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.Models;

namespace Anathema.Patryk.TrainingTwo.Banks.BankTransferHandlers
{
    //BankTransferHandler - klasa implementujaca interfejs IHandler<TRefCHorEntity>(w tym przypadku TRefCHorEntity == BankTransfer),
    //więc może być wykorzystana jako typ generyczny klasy AbstractChainOfResponsibility
    //BankTransfer - klasa, ktora bedzie przetwarzana

    public class ChorBankTransferHandler : AbstractChainOfResponsibility<BankTransferHandler,BankTransfer>
    {
        
        public ChorBankTransferHandler()
        {

            //lista handlerow, ktore moga przetworzyc obiekt klasy BankTransfer
            //jeżeli ktoś chce to może dostarczyć handler dla innego banku

            Handlers = new List<BankTransferHandler>()
            {
                new BzwbkTransferHandler(),
                new NordeaTransferHandler()
            };


            /* CHOR
             * mamy listę handlerów, które mogą przetworzyć obiekt pewnej klasy
             * w naszym przypadku jest to obiekt klasy BankTransfer
             * wywołując metodę Handle w klasie AbstractChainOfResponsibility
             * dla kazdego z handlerow (w naszym przypadku  BzwbkTransferHandler i NordeaTransferHandler)
             * zostaje wywolywana metoda Handle. Te Handlery sprawdzają, czy mogą przetworzyć dostarczony im 
             * obiekt ( w naszym przypadku jest to metoda IsMyDestination w klasie BankTransferHandler)
             * W tem sposób pozbywamy się ifologii, a dostarczenie nowego handlera sprowadza sie do 
             * dodania go do listy
             * 
           */

        }
    }
}