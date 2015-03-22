using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Koziu;
using Toci.TraininigLibrary.Developers.Koziu.InternetStore;
using Toci.TraininigLibrary.Developers.Koziu.StringDictionary;

namespace Toci.TrainingLibrary.Test.Developers.Koziu
{
    [TestClass]
    public class KoziuStringDictionaryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Bike> resultAnagram = new List<Bike>();
            List<Bike> resultPalindrom= new List<Bike>();
            List<Bike> resultWildcard = new List<Bike>();

            Bike bike1 = new Bike(1200,4,"Bike1","s120", new KoziuDiscount("s120", 120.130), false, true, BikeKind.BMX );
            Bike bike2 = new Bike(1200, 4, "Bike2", "s130", new KoziuDiscount("s130", 130.120), false, true, BikeKind.City);
            
            KoziuStringDictionary<Bike> koziuStringDictionary = new KoziuStringDictionary<Bike>();
            koziuStringDictionary.Add("rrdaa",bike1);    
            koziuStringDictionary.Add("radar", bike2);
            koziuStringDictionary.Add("Elfukładałkufle", bike1);
            koziuStringDictionary.Add("ala", bike1);
            koziuStringDictionary.Add("kajakoo", bike1);      
            koziuStringDictionary.Add("niee",bike2);
            koziuStringDictionary.Add("kajak", bike2);
            
            resultAnagram = koziuStringDictionary.GetAnagramSet("radar");
            resultPalindrom= koziuStringDictionary.GetPalindromSet();
            resultWildcard = koziuStringDictionary.GetWildcardSet("kajak");
            

        }
    }
}
