using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Legnica.Amman.DelegatesSandbox;

namespace Toci.Hornets.UnitTests.Legnica.Amman
{
    [TestClass]
    public class AmmanUnitTests
    {
        [TestMethod]
        public void DelegatesSandboxTest()
        {
            var delegates = new DelegatesSandbox();
            delegates.Test();
        }
    }
}