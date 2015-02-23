using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.koziu.DateValidator
{
    public class Month
    {
        private int _month;

        public Month(int month)
        {
            _month = month;
        }
        public int GetMonth()
        {
            return _month;
        }

        public bool isMonth()
        {
            return (_month > 0 && _month < 13) ? true : false;
        }

    }
}
