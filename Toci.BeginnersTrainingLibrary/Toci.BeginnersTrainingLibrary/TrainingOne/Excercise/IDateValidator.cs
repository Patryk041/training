using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Excercise
{
    public interface IDateValidator
    {
        bool CheckDate(int year, int month, int day);

        string GetNick();

        //bool Whatever();
    }
}
