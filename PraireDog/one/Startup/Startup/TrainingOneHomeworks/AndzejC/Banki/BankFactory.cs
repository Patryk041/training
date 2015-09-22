using System;
using System.Collections.Generic;
using Startup.TrainingOneHomeworks.AndzejC.Banki.Abstrakty;
using Startup.TrainingOneHomeworks.AndzejC.Banki.Banks;

namespace Startup.TrainingOneHomeworks.AndzejC.Banki
{
    public class BankFactory : GenFactory<string,Func<IBankTransfer>>
    {
        public BankFactory()
        {
            ItemList = new Dictionary<string, Func<IBankTransfer>>
            {
                {"1050",() => new Ing()},
                {"1010",() => new NarodowyBankPolski()},
                {"1020",() => new Pkobp()}
               
            };
        }
    }
}