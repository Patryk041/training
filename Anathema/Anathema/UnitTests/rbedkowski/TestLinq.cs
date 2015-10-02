using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anathema.rbedkowski.LINQ
{
    [TestClass]
    public class TestLinq
    {
        [TestMethod]
        public void MainTest()
        {
            List<ListLinq> lista = new List<ListLinq>();
            lista.Add(new ListLinq() {Imie = "Rafal", Nazwisko = "Bedkowski", Wiek = 40});
            lista.Add(new ListLinq() {Imie = "Mariusz", Nazwisko = "Mularczyk", Wiek = 16});
            lista.Add(new ListLinq() {Imie = "Bartłomiej", Nazwisko = "Korcz", Wiek = 25});
            lista.Add(new ListLinq() {Imie = "Adam", Nazwisko = "Ficek", Wiek = 33});
            lista.Add(new ListLinq() {Imie = "Amelia", Nazwisko = "Dydko", Wiek = 46});

            var counter = lista.Count;
            var wynik = lista.Where(x=>x.Imie.Equals("Rafal"));
            var latka = lista.Where(x => x.Wiek > 25);
            var next = lista.Average(x => x.Wiek);
            Console.ReadKey();

        }
        
    }
}
