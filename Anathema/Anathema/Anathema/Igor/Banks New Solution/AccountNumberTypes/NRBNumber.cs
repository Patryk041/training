using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Igor.Banks_New_Solution.AccountNumberTypes
{
    class NRBNumber
    {
        public ushort institutionID { get; protected set; }
        public byte branchID { get; protected set; }
        public byte controlDigit { get; protected set; }
        public int clientAccountNumber { get; protected set; }
        public byte controlAmount { get; protected set; }
        public int bankRoutingNumber { get; protected set; }
        public string originalNumber { get; protected set; }

        public NRBNumber(string originalNumber)
        {
            this.originalNumber = originalNumber;
        }

        protected void designateValuesIfNumberIsCorrect()
        {

        }

        protected void designateControlAmount()
        {
            controlAmount = byte.Parse(originalNumber.Substring(0, 2));
        }

        protected void designateInstitutionID()
        {
            institutionID = ushort.Parse(originalNumber.Substring(2, 4));
        }

        protected void designateBranchID()
        {
            branchID = byte.Parse(originalNumber.Substring(6, 3));
        }
        
        protected void designateControlDigit()
        {
            controlDigit = byte.Parse(originalNumber.Substring(9, 1));
        }

        protected void designateClientAccountNumber()
        {
            clientAccountNumber = int.Parse(originalNumber.Substring(10, 16));
        }

        protected void designateBankRoutingNumber()
        {
            bankRoutingNumber = int.Parse(originalNumber.Substring(2, 8));
        }
    }
}
