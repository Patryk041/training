using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Opole.Lausion.TaskFour;
using Toci.Hornets.Wroclaw.ProjectElixir.Test;

namespace Toci.Hornets.UnitTests.Lausion
{
    [TestClass]
    public class LausionGenericListTest
    {
        [TestMethod]
        public void Test()
        {
            LausionGenericList<string> myList=new LausionGenericList<string>();
            bool czyDodalem = true;
            for (int i = 0; i < 20 && czyDodalem; i++)
            {
                czyDodalem = myList.Add("Numer " + i);
            }
            string[] itemy = myList.GetAllItems();
            Debug.WriteLine(itemy.Length);
            foreach (var s in itemy)
            {
                Debug.WriteLine(s);
            }
            bool czyUsunolem = true;
            for (int i = 0; i <15 && czyUsunolem; i++)
            {
                czyUsunolem = myList.Remove("Numer " + i);
            }
            string[] item = myList.GetAllItems();
            Debug.WriteLine(item.Length);
            foreach (var s in item)
            {
                Debug.WriteLine(s);
            }
        }
    }
}