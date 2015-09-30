using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anathema.rbedkowski.Fabryka
{
    [TestClass]
    public class Program
    {
        [TestMethod]
        public void test()
        {
            Dictionary<string, Func<string>> Zamowienie = new Dictionary<string, Func<string>>()
            {
                {"Polish", ()=>new PolishRestaurant().GetComponent().GetComponent()},
                {"English", ()=>new EnglishRestaurant().GetComponent().GetComponent()},
                {"Italian", ()=>new ItalianRestaurant().GetComponent().GetComponent() },
                {"Pasta", ()=>new PastaRestaurant().GetComponent().GetComponent() }
            };


            var Order = Zamowienie["Polish"]();
            Order = Zamowienie["Pasta"]();
            Order = Zamowienie["Italian"]();
            Order = Zamowienie["English"]();


            



        }


    }
}