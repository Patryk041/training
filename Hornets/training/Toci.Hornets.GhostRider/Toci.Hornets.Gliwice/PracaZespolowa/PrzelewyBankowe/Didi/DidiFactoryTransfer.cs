using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi.Banki;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi
{

     static class DidiFactoryTransfer
     {
         private static Dictionary<string, Func<DidiBankTransfer, IBank>> _dictionaryBank = new Dictionary<string, Func<DidiBankTransfer, IBank>>()
         {
             {"ING", (x) => new DidiINGBank(x)}
             ,{"PKO", (x)=> new DidiPKOBank(x)}

         };

         public static IBank SendBank(DidiBankTransfer bankTransfer, string bank)
         {
             if (_dictionaryBank.ContainsKey(bank))
             {
                 return _dictionaryBank[bank](bankTransfer);
             }
             return new DidiInnyBank(bankTransfer); 
         }
     }
}
