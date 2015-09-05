using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Generics;
using Anathema.Iwona.BankFactory.BankList;

namespace Anathema.Iwona.BankFactory
{
    public class BankFactory<T> : AbstractFactory<T>
    {
        public Dictionary<string, T> BankDictionary = new Dictionary<string, T>(); 
        public BankFactory()
        {
            this.BankDictionary.Add("1010", (T)(object)new AlliorBank() );
            this.BankDictionary.Add("1020", (T)(object)new IngBank());
            this.BankDictionary.Add("1030", (T)(object)new PkoBank());
            this.BankDictionary.Add("1040", (T)(object)new WbkBank());
        }
    }
}
