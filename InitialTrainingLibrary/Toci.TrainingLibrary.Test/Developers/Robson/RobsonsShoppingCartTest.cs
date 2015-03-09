using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Robson.ShoppingCartv2.CartItems;
using Toci.TraininigLibrary.Developers.Robson.ShoppingCartv2;

namespace Toci.TrainingLibrary.Test.Developers.Robson
{
    [TestClass]
    public class RobsonsShoppingCartTest
    {
        [TestMethod]
        public void TestShoppingCart()
        {
            RobsonsShoppingCart shoppingCart = new RobsonsShoppingCart();

            Book bookPosition_1 = new Book(1, 100, "Adam Mickiewicz", "Pan Tadeusz", 3);    //Cena z rabatem: 250.
            Book bookPosition_2 = new Book(2, 300, "Andrew Troelsen", "Pro C# 5.0...", 3);  //Cena z rabatem: 750.
            Book bookPosition_3 = new Book(3, 50, "Adam Mickiewicz", "Dziady", 1);     //Cena z rabatem: 50.

            shoppingCart.AddCartItem(bookPosition_1);
            shoppingCart.AddCartItem(bookPosition_2);
            shoppingCart.AddCartItem(bookPosition_3);

            Assert.IsTrue(1050 == shoppingCart.GetCartValue(shoppingCart.Purchases()));
            Assert.IsTrue(200 == shoppingCart.GetDiscount().Discount());

        }
    }
}
