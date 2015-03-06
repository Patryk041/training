using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Mg.FileParser;
using Toci.TraininigLibrary.Logic;

namespace Toci.TrainingLibrary.Test.Developers.Mg
{
    [TestClass]
    public class MgLoadFileTest
    {
        [TestMethod]
        public void LoadFiles()
        {



            var directoryList = "defaultPath".GetDirectoryFileList();
            var parserName = directoryList[0].GetName();
            MgFileDetailsParser fp = new MgFileDetailsParser();
            var mgEntity = fp.ReadEntry(@"Michał/Garbacz/2015_03_06/1353403124232932323");

            ParsersFactory pf = new ParsersFactory();
          //  pf.GetData()
            var z = pf.GetData(directoryList);


        }
    }
}
