using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Rzeszow.Terry.TrainingFour.GenericList;
using Toci.Hornets.Rzeszow.Terry.TrainingThree.TerryBank;

namespace Toci.Hornets.UnitTests.Rzeszow.Terry.GenericList
{
    [TestClass]
    public class TerryGenericsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            TerryGenericList<int> listOfInt = new TerryGenericList<int>(11);
            TerryGenericList<string> listOfString = new TerryGenericList<string>(11);
            //TerryGenericList<int> listOfInt = new TerryGenericList<int>();
           // TerryGenericList<int> listOfInt = new TerryGenericList<int>();

            for (int i = 0; i < 10; i++)
            {
                listOfInt.Add(i);
            }

            var all = listOfInt.GetAllItems();

            for (int i = 0; i < 7; i++)
            {
                listOfInt.Remove(i);
            }

            all = listOfInt.GetAllItems();
            listOfInt.Add(123);
            listOfInt.Add(578656);
            listOfInt.Remove(7);

            listOfString.Add("dupa");

            var transfer = new TerryBankTransfer();
            var lista = new TerryGenericList<TerryBankTransfer>(3);

            lista.Add(transfer);
        }
    }
}
