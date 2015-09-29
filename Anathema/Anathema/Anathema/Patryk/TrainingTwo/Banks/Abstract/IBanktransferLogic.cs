using System.Collections.Generic;
using Anathema.Patryk.TrainingOne.Cars.Abstract;
using Anathema.Patryk.TrainingTwo.Banks.Models;

namespace Anathema.Patryk.TrainingTwo.Banks.Abstract
{
    public interface IBanktransferLogic
    {
        List<BankTransfer> GetAllBanktransfers(string path);
    }
}