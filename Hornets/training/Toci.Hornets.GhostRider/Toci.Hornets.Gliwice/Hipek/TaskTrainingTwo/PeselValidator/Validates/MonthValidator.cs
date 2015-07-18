using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Gliwice.Hipek.TaskTrainingTwo.PeselValidator.Validates
{
    public static class MonthValidator
    {
        public static bool IsCorrect(int month)
        {
            return month >= 1 && month <= 12;
        }
    }
}
