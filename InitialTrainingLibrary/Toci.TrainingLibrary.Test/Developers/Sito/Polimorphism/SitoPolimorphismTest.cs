using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Sito.Polimorphism;
using Toci.TraininigLibrary.Developers.Sito.Polimorphism.TransferModels;

namespace Toci.TrainingLibrary.Test.Developers.Sito.Polimorphism
{
    [TestClass]
    public class SitoPolimorphismTest
    {
        [TestMethod]
        public void SitoTextParserTest()
        {
            List<string> fileList = new List<string>()
            {
                @"E:\Szkolenie\InitialTrainingLibrary\Toci.TraininigLibrary\data\transfer_2015-03-01_321434535_sito.txt",
                @"E:\Szkolenie\InitialTrainingLibrary\Toci.TraininigLibrary\data\transfer_2015_03_06_232325_mg.txt"
            };
            List<SitoTransfer> transfers = new List<SitoTransfer>();
            SitoTextTransferParser parser =new SitoTextTransferParser();


            foreach (var file in fileList)
            {
                transfers.AddRange(parser.GetTransfers(file));
            }
            var stop = 4;
        }
    }
}
