using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anathema.rbedkowski.Delegaty
{
    [TestClass]
    public class TestDelegat
    {
        public delegate string TestMSG(string msg);

        [TestMethod]
        public void Main()
        {
            DelegatString str = new DelegatString();
            
            TestMSG msg = new TestMSG(str.Tekst1);
            msg += str.Tekst2;
            Console.WriteLine(msg("YFHGFhgfhgfhgfHGFhgfh"));


            

        }
        

        

       
    }
}
