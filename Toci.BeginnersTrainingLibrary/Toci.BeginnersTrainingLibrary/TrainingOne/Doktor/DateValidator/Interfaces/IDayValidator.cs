using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Doktor.DateValidator.Interfaces
{
    public interface IDayValidator
    {
        bool IsDayValid(int _day, int _month, int _year);
    }
}
