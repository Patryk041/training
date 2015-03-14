using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Common.Eacrm
{
    public abstract class DepartureList<T> : List<T> where T : DepartureEntity
    {
        public new abstract bool Add(T element);
    }
}
