using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Restaurant;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Interfaces;
using System.Collections.Generic;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Service;
using Toci.TraininigLibrary.Developers.R4D3K.OMR.Employee.Employees;

namespace Toci.TrainingLibrary.Test.Developers.R4D3K.omr
{
    [TestClass]
    public class RestaurantTest
    {
        // arrange

        // act

        // assert

        [TestMethod]
        public void PizzeriaKind()
        {
            // arrange
            List<IRoom> rooms = new List<IRoom>();
            rooms.Add(new Bar());
            rooms.Add(new Kitchen());
            List<IService> services = new List<IService>();
            services.Add(new ServiceKatering(1, "Katering Basic", 100));
            List<IEmployee> employees = new List<IEmployee>();
            employees.Add(new Barman(1, "Franek", "Dolas"));
            var pizza = new PizzeriaRestaurant("Poland", "Radoszewice", "Super", 22, "Łasuch", services, employees, rooms);
            // act
            var kind = KindOfResteurant.Pizzeria;
            // assert
            Assert.AreEqual(kind, pizza.GetKind());
        }
    }
}
