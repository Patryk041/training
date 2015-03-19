using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Chmura;
using Toci.TraininigLibrary.Developers.Chmura.ChmuraInheritanceTask;
using Toci.TraininigLibrary.Developers.Chmura.Common;

namespace Toci.TrainingLibrary.Test.Developers.Chmura.TrainingThree
{
    [TestClass]
    public class ChmuraTrainingThreeTest
    {
        [TestMethod]
        public void ChmuraExtensions3Test()
        {
            string a = "radar";
            string b = "darra";
            string c = "wild";
            string d = "wildHabababa";
            string e = "kajak";

            Assert.AreEqual(e.ChmuraIsPalindrom(),true);
            Assert.AreEqual(a.ChmuraIsAnagram(b),true);
            Assert.AreEqual(c.ChmuraIsWildcard(d),true);
        }

        [TestMethod]
        public void ChmuraDictionaryTest()
        {
            ChmuraStringDictionary<ChmuraClass> chmuraDic = new ChmuraStringDictionary<ChmuraClass>();
            chmuraDic.Add("radar", new ChmuraClass() { Name = "pierwszy" });
            chmuraDic.Add("arrad", new ChmuraClass() { Name = "drugi" });
            chmuraDic.Add("radarowo", new ChmuraClass() { Name = "trzeci" });
            chmuraDic.Add("JestemInny", new ChmuraClass() { Name = "czwarty" });
            chmuraDic.Add("romek", new ChmuraClass() { Name = "piaty" });

            List<ChmuraClass> myList = new List<ChmuraClass>();

            myList = chmuraDic.GetPalindromSet();
            myList = chmuraDic.GetAnagramSet(chmuraDic.ElementAt(0).Key);
            myList = chmuraDic.GetWildcardSet(chmuraDic.ElementAt(0).Key);

        }
    }
}
