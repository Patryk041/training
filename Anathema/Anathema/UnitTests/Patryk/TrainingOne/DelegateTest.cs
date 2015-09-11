using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Patryk.TrainingOne
{
    [TestClass]
    public class DelegateTest
    {
        public delegate int Foo(int x);

        [TestMethod]
        public void TestMethod1()
        {
            Foo myFoo = new Foo(DivValue);

            int result = myFoo(20);

            Assert.AreEqual(result,10);

            /*******************************************/

            myFoo = a => a + 5;

            int resultFromLambda = myFoo(15);

            Assert.AreEqual(resultFromLambda, 20);


            /*******************************************/


            myFoo = Power;

            int resultFromPower = myFoo(10);

            Assert.AreEqual(resultFromPower, 100);


        }

        public int DivValue(int value)
        {
            return value/2;
        }

        public int Power(int value)
        {
            return value*value;
        }

        public string badMethod()
        {
            return "tekst";
        }
    }
}
