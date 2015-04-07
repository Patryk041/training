using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Robson.OMR;
using Toci.TraininigLibrary.Developers.Robson.OMR.VehicleComponents;
using System.Collections.Generic;
using Toci.TraininigLibrary.Developers.Robson.OMR.ChildClasses;
using Toci.TraininigLibrary.Developers.Robson.OMR.CarComponents;

namespace Toci.TrainingLibrary.Test.Developers.Robson
{
    [TestClass]
    public class RobsonsCarTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Transmission transmission = new Transmission(TransmissionType.Sequental_manual, 5, 240, "Robson_Company");
            Engine engine = new Engine(EngineType.Diesel, "V12", 12, "ChinatownModders", 6000, 700, 10000);
            Body carbody = new Body(BodyType.Muscle_car, "Fordinand");
            List<Light> lights = new List<Light>()
            {
                new Light(1100, "Łosram"),
                new Light(1100, "Łosram")
            };
            List<Wheel> wheels = new List<Wheel>()
            {
                new Wheel(new Tire(16, 0, "Majkelin"), new Rim(16, "Star", "Maak")),
                new Wheel(new Tire(16, 0, "Majkelin"), new Rim(16, "Star", "Maak")),
                new Wheel(new Tire(16, 0, "Majkelin"), new Rim(16, "Star", "Maak")),
                new Wheel(new Tire(16, 0, "Majkelin"), new Rim(16, "Star", "Maak"))
            };
            Radio radio = new Radio(true, true, 200, 80, 130, "Pointer");
            Airconditioner airconditioner = new Airconditioner(40, -20, true, "Igloo");

            Car firstCar = new Car(radio, airconditioner, carbody, engine, lights, wheels, transmission);

            firstCar.GetVehicleState();

            firstCar.SpeedUP(300);
            firstCar.SlowDown(120);
            firstCar.SlowDown(120);
            firstCar.SlowDown(20);

            firstCar.GetVehicleState();
        }
    }
}
