using Toci.Hornets.GhostRider.Kir;
using Toci.Hornets.GhostRider.Kir.BankLoggingMechanism;

namespace Toci.Hornets.GhostRider.TrainingSeven.Di
{
    public class TransferMoney
    {
        protected TransferHandle Handle;
        protected ILogTransfers Logger;

        // di container: autofac, castle windsor, ninject IoC, Di, Inversion of control
        public TransferMoney(TransferHandle handle, ILogTransfers logger)
        {
            Handle = handle;
            Logger = logger;
        }

        public void DoTransfer(BankTransfer transfer)
        {
            bool result = Handle.SendTransfer(transfer);

            Logger.Log(transfer, result);
        }
    }
}