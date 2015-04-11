using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Doktor.DateValidator.Interfaces
{
    public interface IMonthValid
    {
        bool WhichMonth(int y, int m, int d);
    }
}
