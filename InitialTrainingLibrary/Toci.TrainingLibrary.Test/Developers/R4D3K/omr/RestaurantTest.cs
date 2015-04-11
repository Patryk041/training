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
        private PizzeriaRestaurant p;

        [TestInitialize]
        public void InitializeTest()
        {
            List<IRoom> rooms = new List<IRoom>();
            rooms.Add(new Bar());
            rooms.Add(new Kitchen());
            List<IService> services = new List<IService>();
            services.Add(new ServiceKatering(1, "Katering Basic", 100));
            List<IEmployee> employees = new List<IEmployee>();
            employees.Add(new Barman(1, "Franek", "Dolas"));
            p = new PizzeriaRestaurant("Poland", "Radoszewice", "Super", 22, "Łasuch", services, employees, rooms);
        }
        [TestMethod]
        public void PizzeriaKind()
        {
         
            var kind = KindOfResteurant.Pizzeria;
            //var serLis = new List<IService>();
            //serLis.Add(new ServiceKatering(1, "Katering Basic", 100));
            // assert
            Assert.AreEqual(kind, p.GetKind());
            Assert.AreEqual("Łasuch", p.GetName());
            //Assert.AreEqual(serLis, p.GetService());
        }
    }
}
