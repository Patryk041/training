using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.Hornets.GhostRider.Kir;

namespace Toci.Hornets.Gliwice.PracaZespolowa.PrzelewyBankowe.Didi
{
    public class DidiBankTransfer : BankTransfer, IBank
    {
        private DidiInformationTransfer m_Information; 
        public DidiInformationTransfer Information
        { 
            get { return m_Information; }
            set { m_Information = value;} 
        }
    }
}
