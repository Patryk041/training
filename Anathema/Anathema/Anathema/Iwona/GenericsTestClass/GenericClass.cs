using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Iwona.GenericsClass
{
    public class GenericClass<T>
    {
        public int NumberElements { get; set; }
        public int NumberDisplayElements { get; set; }
        public int PageNumber { get; set; }
        public int AllPagesNumber { get; set; }
        public List<T> Data { get; set; }
    
    }
}
