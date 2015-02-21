using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.postcodevalidator
{
    //PostCodeExtractor
    public class PostCode
    {
        public PostCode(int _prefix, int _suffix)
        {
            prefix = _prefix;
            suffix = _suffix;
        }

        private int prefix;
        private int suffix;

        public int Prefix()
        {
            return prefix;
        }

        public int Suffix()
        {
            return suffix;
        }
    }
}
