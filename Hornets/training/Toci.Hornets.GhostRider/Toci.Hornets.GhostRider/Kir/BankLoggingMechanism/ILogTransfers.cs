namespace Toci.Hornets.GhostRider.Kir.BankLoggingMechanism
{
    public interface ILogTransfers
    {
        void Log(BankTransfer transfer, bool success);
    }
}