using System.Collections.Generic;

namespace Toci.TraininigLibrary.Developers.Vernathic.OMR2
{
    public class CoffeeMachine
    {
        private Milk FrotherMilk()
        {
            var milk = new Milk();
            //use 1 from milk container
            UseFromContainer("Milk");
            //if (ContainersDictionary["Milk"] > 0)
            //    ContainersDictionary["Milk"] -= 1;
            milk.Frothered = true;
            return milk;
        }

        private void PutIntoCupContents(Substance substance, List<Substance> coffee)
        {
            //add substance into CupContents
            coffee.Add(substance);
        }

        private Substance MakeCoffee()
        {
            //mix water+coffee
            //use 1 from water container
            UseFromContainer("Water");
            //use 1 from coffee container
            UseFromContainer("Coffee");
            //create Coffee object
            var coffee = new Substance(Substance.TypeOfSubstance.Coffee);
            return coffee;
            //return Coffee object
        }

        public List<Substance> makeCoffeeBeverage(CoffeeBeverage.TypeOfCoffee typeOfCoffee)
        {
            if(AreEmptyContainers())
                FillContainers();

            var coffeeBeverage = new List<Substance>();
            var coffee = MakeCoffee();

            switch (typeOfCoffee)
            {
                case CoffeeBeverage.TypeOfCoffee.Espresso:
                    PutIntoCupContents(coffee, coffeeBeverage);
                    break;
                case CoffeeBeverage.TypeOfCoffee.Americana:
                    PutIntoCupContents(coffee, coffeeBeverage);
                    PutIntoCupContents(new Substance(Substance.TypeOfSubstance.Water), coffeeBeverage);
                    break;
                case CoffeeBeverage.TypeOfCoffee.LatteMacchiato:
                    //1. FrotherMilk();
                    //2. PutMilkIntoCup();
                    //3. PutCoffeeIntoCup(); - coffee is between milk and milk foam
                    var milk = FrotherMilk();
                    PutIntoCupContents(milk, coffeeBeverage);
                    PutIntoCupContents(coffee, coffeeBeverage);
                    break;
                case CoffeeBeverage.TypeOfCoffee.Latte:
                    //1. PutCoffeeIntoCup();
                    //2. FrotherMilk();
                    //3. PutMilkIntoCup();
                    PutIntoCupContents(coffee,coffeeBeverage);
                    var milk2 = FrotherMilk();
                    PutIntoCupContents(milk2,coffeeBeverage);
                    break;
            }
            return coffeeBeverage;
        }

        private bool AreEmptyContainers()
        {
            foreach (var key in ContainersDictionary.Keys)
            {
                if (ContainersDictionary[key] <= 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void UseFromContainer(string containername)
        {
            var unit = 1;
            if (ContainersDictionary[containername] > 0)
                ContainersDictionary[containername] -= unit;
        }

        private void FillContainers()
        {
            var max = 10;
            foreach (var key in ContainersDictionary.Keys)
            {
                if (ContainersDictionary[key] <= 0)
                    ContainersDictionary[key] += max;
            }
            
        }

        public enum StateOfMachine
        {
            Ready,
            Preparng,
            Error
        }

        private Dictionary<string, int> ContainersDictionary = new Dictionary<string, int>()
        {
            {"Coffee", 10},
            {"Water", 10},
            {"Milk", 10},
            {"Sugar", 10}
        };
    }
}