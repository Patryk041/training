using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.SieradzBankTransferTask;

namespace Toci.Hornets.UnitTests.Sieradz.BankTransferTests
{
    [TestClass]
    public class FileOperationsTest
    {
        [TestMethod]
        public void SieradzFileOperationsTest() // UCTT
        {
            var fileList = Directory.GetFiles(SieradzBankFilesPathHolder.TransferFilesPath);

            var fileOperation = new SieradzFileOperation();

            foreach (var file in fileList)
            {
                var tmp = fileOperation.GetFileContent(file);
                Assert.IsNotNull(tmp);
//                Debug.WriteLine(fileOperation.GetFileContent(file));
            }
        }
    }
}