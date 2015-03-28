using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Wiosna.DateValidator.WiosnaInterfaces
{
    interface IMonthAndMonthLength
    {
        bool GetMonth(int month, int day);
    }
}
