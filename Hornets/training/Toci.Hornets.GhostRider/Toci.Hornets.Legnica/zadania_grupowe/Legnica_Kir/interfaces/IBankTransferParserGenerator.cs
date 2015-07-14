using System.Collections.Generic;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Legnica.zadania_grupowe.Legnica_Kir.interfaces
{
    public interface IBankTransferParserGenerator
    {
        IEnumerable<BankTransfersParser> GetAllParsers();
    }
}