using System.Diagnostics;
using System.Linq;
using Anathema.Brzydal.Zad1GenerycznaLista;
using Anathema.Lurppis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Brzydal
{

    [TestClass]
    public class BrzydalTestListaGeneryczna
    {
        [TestMethod]
        public void TestListaGeneryczna()

        {
            BrzydkaGenerycznaLista<MyClass> mojaLista = new BrzydkaGenerycznaLista<MyClass>();


            mojaLista.AddElement(new MyClass());
            mojaLista.AddElement(new MyClass());
            mojaLista.AddElement(new MyClass());
            mojaLista.AddElement(new MyClass());
            mojaLista.AddElement(new MyClass());
            mojaLista.AddElement(new MyClass());
            mojaLista.AddElement(new MyClass());
            mojaLista.AddElement(new MyClass());
            mojaLista.AddElement(new MyClass());
            mojaLista.AddElement(new MyClass());
            mojaLista.AddElement(new MyClass());
     

         
         
           Debug.WriteLine(mojaLista);
        } 

    }
}