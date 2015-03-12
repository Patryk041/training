using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Dysq.Polymorphism.Factory
{
    public class DysqFileExtension
    {
        public static string GetFileExtension(string path)
        {
            const char delimiter = '.';
            var ext = path.Split(delimiter).LastOrDefault();

            return ext;
        }
    }
}
