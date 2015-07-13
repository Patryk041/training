using System.Diagnostics;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Sieradz.SieradzBankTransferTask;

namespace Toci.Hornets.UnitTests.Sieradz.BankTransferTests
{
    [TestClass]
    public class FileOperationsTest
    {
        [TestMethod]
        public void SieradzFileOperationsTest()
        {
            var fileList = Directory.GetFiles(SieradzBankFilesPathHolder.path);

            foreach (var file in fileList)
            {
                Debug.WriteLine(file);
            }
        }
    }
}