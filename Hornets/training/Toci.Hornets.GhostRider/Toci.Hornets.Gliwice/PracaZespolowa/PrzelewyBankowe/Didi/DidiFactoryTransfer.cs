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
         private static Dictionary<string, Func<IBank>> _dictionaryBank = new Dictionary<string, Func<IBank>>()
         {
             {"ING", () => new DidiINGBank()}
             ,{"PKO", ()=> new DidiPKOBank()}

         };

         public static IBank SendBank( string bank) // GenerateTransferHandle
         {
             if (_dictionaryBank.ContainsKey(bank))
             {
                 return _dictionaryBank[bank]();
             }
             return new DidiInnyBank(); 
         }
     }
}
