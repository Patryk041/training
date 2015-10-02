using System.Collections.Generic;
using Toci.Hornets.BankFactory.Models;

namespace Toci.Hornets.BankFactory.Bank.Abstract
{
    public interface IBanktransferLogic
    {
        List<BankTransfer> GetAllBanktransfers(string path);
    }
}