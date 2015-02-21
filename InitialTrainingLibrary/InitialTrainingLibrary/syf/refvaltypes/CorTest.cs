using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.refvaltypes
{
    public class CorTest
    {
        public void test()
        {
            var reftypeparam = new RefTypeExample();

            List<Handle> handlers = new List<Handle>
            {
                new AdvancedHandleChild(),
                new HandleChild(),
                new SimpleHandleChild()
            };

            int test2 = 0;

            foreach (var handler in handlers)
            {
                handler.ModifyIncomingRefTypeParameter(reftypeparam);
            }

            //handlers[0].ModifyIncomingRefTypeParameter(reftypeparam);
            //handlers[0].ModifyIncomingRefTypeParameter(reftypeparam);

            handlers[0].ModifyIncomingValTypeParameter(test2);

            var dsafdsa = reftypeparam.test;

            var dfsa = test2;
        }  
    }
}
