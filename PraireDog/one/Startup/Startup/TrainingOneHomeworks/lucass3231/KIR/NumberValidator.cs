using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace Startup.TrainingOneHomeworks.lucass3231.KIR
{
    public class NumberValidator
    {
        public static bool Validation(string AccountNumber)
        {
            AccountNumber = AccountNumber.Replace(" ", string.Empty);

            if (AccountNumber.Length == 26 || AccountNumber.Length == 28)
            {

                if (AccountNumber.All(char.IsDigit))
                {
                    AccountNumber = AccountNumber.Remove(0, 2);
                    AccountNumber = AccountNumber.Remove(4, 20);
                }
                else
                {
                    AccountNumber = AccountNumber.Remove(0, 2);
                    if (AccountNumber.All(char.IsDigit))
                    {
                        AccountNumber = AccountNumber.Remove(0, 2);
                        AccountNumber = AccountNumber.Remove(4, 20);
                    }

                }
            }
            else
            {
                return false;
            }
            return true;

        }
        
    }
}