using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Chmura.ChmuraDeparture;

namespace Toci.TrainingLibrary.Test.Developers.Chmura.TrainingFour
{
    [TestClass]
    public class ChmuraDepartureVariousTests
    {
        [TestMethod]
        public void ChmuraDepartureListTest()
        {
            IEnumerable<CultureInfo> jezyk = CultureInfo.GetCultures(CultureTypes.AllCultures).Where(item => item.Name=="pl-PL");
            var jey = CultureInfo.InstalledUICulture;
            ChmuraDepartureEntity departure1 = new ChmuraDepartureEntity(1,2,3,DateTime.Now.AddDays(10),DateTime.Now);
            var weeks1 = departure1.WeeksCount;
            ChmuraDepartureList list = new ChmuraDepartureList();
            list.Add(departure1);
        }
    }
}
