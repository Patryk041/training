using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Opole.OpoleKir;

namespace Toci.Hornets.UnitTests.Lausion
{
    [TestClass]
    public class LausionTestFileIO
    {
        [TestMethod]
        public void Test()
        {
            OpoleFileOperation op=new OpoleFileOperation();
            string s =
                op.GetFileContent(
                    @"D:\Szkolenie C#\SoutceTree\Hornets\training\Toci.Hornets.GhostRider\Toci.Hornets.UnitTests\Lausion\Check.txt");
            Debug.Write(s);

            string[] strings = s.Split('\n');

            foreach (var s1 in strings)
            {
                Debug.WriteLine(s1);
                Debug.WriteLine("\n\n");
            }
        }
    }
}