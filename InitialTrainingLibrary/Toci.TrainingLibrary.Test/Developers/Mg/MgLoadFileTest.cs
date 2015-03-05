using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Logic;

namespace Toci.TrainingLibrary.Test.Developers.Mg
{
    [TestClass]
    public class MgLoadFileTest
    {
        [TestMethod]
        public void LoadFiles()
        {



            var directoryList = "".GetDirectoryFileList();
            var parserName = directoryList[0].GetName();

            ParsersFactory pf = new ParsersFactory();
          //  pf.GetData()
            var z = pf.GetData(directoryList);


        }
    }
}
