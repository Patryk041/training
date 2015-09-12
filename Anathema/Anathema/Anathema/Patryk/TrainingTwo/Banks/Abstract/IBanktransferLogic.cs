using System.Collections.Generic;
using Anathema.Patryk.TrainingTwo.Models;

namespace Anathema.Patryk.TrainingTwo.Banks.Abstract
{
    public interface IBanktransferLogic
    {
        List<BankTransfer> GetAllBanktransfers(string path);
    }
}