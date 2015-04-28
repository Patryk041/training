using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateValidator.Interfaces
{
    public interface IDayList
    {
        bool VerifyLongMonthDay(int day);
        bool VerifyShortMonthDay(int day);
        bool VerifyLongFebruaryDay(int day);
        bool VerifyShortFebruaryDay(int day);

    }
}
