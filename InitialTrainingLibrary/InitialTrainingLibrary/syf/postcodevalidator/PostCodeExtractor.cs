using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.syf.postcodevalidator.interfaces;

namespace InitialTrainingLibrary.syf.postcodevalidator
{
    class PostCodeExtractor : IPostCodeExtractor
    {
        public PostCode GetPostCode(string code)
        {
            int prefix = int.Parse(code.Substring(0, 2));
            int suffix = int.Parse(code.Substring(3, 3));

            return new PostCode(prefix, suffix);
        }
    }
}
