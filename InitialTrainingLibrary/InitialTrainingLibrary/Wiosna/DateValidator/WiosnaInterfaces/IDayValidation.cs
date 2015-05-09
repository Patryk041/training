using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.Wiosna.DateValidator.WiosnaInterfaces
{
    public interface IDayValidation 
    {
        bool DayValid(int _day,int _month, int _year);

        
    }
}
