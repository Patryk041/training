using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi
{
    public class DidiInformationTransfer : IBank
    {
        public string AccountClient { get; set; }
        public string NameClient { get; set; }
        public string Title { get; set; }
        public string Amount { get; set; }
        public string DateTransfer { get; set; }
        public string NameRecipe { get; set; }
        public string AccountRecipe { get; set; }
    }
}
