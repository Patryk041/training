using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateValidator.Interfaces
{
    public interface IYearValidation
    {
        bool ValidYear(int year);
        bool ValidLeapsed(int year);
    }
}
