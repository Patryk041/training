using System;
using Anathema.rbedkowski.Singleton;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.rbedkowski
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

            Singleton single = Singleton.Instance;
            single.Lang = "US";
            single.Color = "Braun";
            Console.WriteLine("Jezyk : {0} kolor: {1}", single.Lang, single.Color);

            Singleton single2 = Singleton.Instance;
            single2.Lang = "NL";
            single2.Color = "Green";
            Console.WriteLine("Jezyk : {0} kolor: {1}", single.Lang, single.Color);

        }

    }
}
