using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.BeginnersTrainingLibrary.TrainingOne.ListsOfItems;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Doktor.DateValidator.Interfaces
{
    public interface IMonthValidator
    {
        bool IsMonthValid(int _month);
    }
}
