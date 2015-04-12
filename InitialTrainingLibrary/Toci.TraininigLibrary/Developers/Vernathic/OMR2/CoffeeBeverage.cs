using System.Collections.Generic;

namespace Toci.TraininigLibrary.Developers.Vernathic.OMR2
{
    public abstract class CoffeeBeverage
    {
        public enum TypeOfCoffee
        {
            Espresso,
            Cappuccino,
            LatteMacchiato,
            Latte,
            Americana
        }

        public List<Substance> CupContent = new List<Substance>();// { get; set; }
    }
}