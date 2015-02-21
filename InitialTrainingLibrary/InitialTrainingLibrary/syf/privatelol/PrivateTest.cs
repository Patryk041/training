using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialTrainingLibrary.syf.privatelol
{
    public class PrivateTest
    {
        private int test = 3;

        public void InjectValue(PrivateTest testObj, int newValue)
        {
            testObj.test = newValue;
        }

        public void Metoda()
        {
            
        }

        public void Metoda(double fsdagsg)
        {

        }

        public void Metoda(int dfsafgads)
        {

        }
    }

    public class TestRunner
    {
        public void test()
        {
            var obj1 = new PrivateTest();
            var obj2 = new PrivateTest();

            obj1.Metoda(12.3);

            obj1.InjectValue(obj1, 7);

            obj1.InjectValue(obj2, 5);
        }
    }
}
