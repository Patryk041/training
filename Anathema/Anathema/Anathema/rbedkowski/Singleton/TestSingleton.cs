using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.rbedkowski.Singleton
{
    [TestClass]
    public class TestSingleton
    {
        [TestMethod]
        public void MainTest()
        {
            Configuration konfiguracja = Configuration.GetInstance();
            konfiguracja.Lang = "PL";
            konfiguracja.Color = "Red";
            Configuration konfiguracja1 = Configuration.GetInstance();
            konfiguracja1.Lang = "GB";
            konfiguracja1.Color = "Blue";

            Console.WriteLine("Jezyk : {0} kolor: {1}", konfiguracja.Lang, konfiguracja.Color);
            Console.WriteLine("Jezyk : {0} kolor: {1}", konfiguracja1.Lang, konfiguracja1.Color);

            Singleton _single = Singleton.Instance;
            _single.Lang = "US";
            _single.Color = "Braun";
            Console.WriteLine("Jezyk : {0} kolor: {1}", _single.Lang, _single.Color);

            Singleton _instancja = Singleton.Instance;
            _single.Lang = "NL";
            _single.Color = "Green";
            Console.WriteLine("Jezyk : {0} kolor: {1}", _single.Lang, _single.Color);

        }

    }
}
