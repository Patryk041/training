using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Iwona.GenericsClass
{
    public class MainClass
    {
        public void testMethodGenerics()
        {
            var doc = new GenericClass<Document>();
            var docList = doc.Data;
        }
    }
}
