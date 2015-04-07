using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Mg.Omr.Enums;
using Toci.TraininigLibrary.Developers.Mg.Omr.Helpers;
using Toci.TraininigLibrary.Developers.Mg.Omr.Mammals;

namespace Toci.TrainingLibrary.Test.Developers.Mg.Omr
{
    [TestClass]
    public class MgOmrTest
    {
        [TestMethod]
        public void OmrMethod()
        {

            Cow milka = new Cow(200,150,5);

            Assert.IsTrue(milka.Name == VertebraeAnimalsNameEnum.Cow);
            Assert.IsTrue(milka.BodyTemperatureType==BodyTemperatureEnum.WarmBlooded);
            Assert.IsTrue(milka.MultiplicationType==MultiplicationEnum.Oviparity);
            Assert.IsTrue(milka.Sex==SexEnum.Female);
            Assert.IsTrue(milka.MakeNoise() == "Moooo");

            
            var milk = milka.GiveMilk();
            var blood = milka.AmountOfBlood;

            Horse konrafal = new Horse(VertebraeAnimalsNameEnum.Horse, 100,150,6,SexEnum.Male);


        }
    }
}
