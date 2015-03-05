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
           
            //const string path = @"C:\Dropbox\SzkolenieBartek\InitialTrainingLibrary\Toci.TraininigLibrary\data";

            var directoryList = DirectoryFileList.GetPathList();
            var parsersNames = DirectoryFileList.GetParsersNames(directoryList);

            ParsersFactory pf = new ParsersFactory();

            var xyz = pf.GetData(parsersNames[0],directoryList[0]);

        }
    }
}
