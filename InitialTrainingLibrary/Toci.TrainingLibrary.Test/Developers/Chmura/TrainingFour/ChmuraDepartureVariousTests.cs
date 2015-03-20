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
            ChmuraDepartureEntity departure1 = new ChmuraDepartureEntity(1,2,3,DateTime.Now.AddDays(-10),DateTime.Now.AddDays(10), 7);
            ChmuraDepartureList<ChmuraDepartureEntity> list = new ChmuraDepartureList<ChmuraDepartureEntity>();
            list.Add(departure1);
        }
    }
}
