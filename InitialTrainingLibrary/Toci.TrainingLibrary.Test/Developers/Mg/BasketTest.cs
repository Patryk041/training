using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Mg.Basket;
using Toci.TraininigLibrary.Developers.Mg.Basket.Products;

namespace Toci.TrainingLibrary.Test.Developers.Mg
{
    [TestClass]
    public class BasketTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            MgBasket mgBasket = new MgBasket();
            mgBasket.AddItemToBasket(new MgSamsungGalaxy(2,965.09,"Galaxy S2",false));

        }
    }
}
