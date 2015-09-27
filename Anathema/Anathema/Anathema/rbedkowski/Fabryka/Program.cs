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
            Dictionary<string, Func<IRestaurant>> Zamowienie = new Dictionary<string, Func<IRestaurant>>()
            {
                {"Polish", ()=>new PolishRestaurant()},
                {"English", ()=>new EnglishRestaurant()},
                {"Italian", ()=>new ItalianRestaurant() },
                {"Pasta", ()=>new PastaRestaurant() }
            };

            IRestaurant restauracja = new PolishRestaurant();
            restauracja.GetComponent();
            restauracja = new PastaRestaurant();
            restauracja.GetComponent();
            restauracja = new ItalianRestaurant();
            restauracja.GetComponent();
            restauracja = new EnglishRestaurant();
            restauracja.GetComponent();



        }


    }
}