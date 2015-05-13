using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Amman.Chess;
using InitialTrainingLibrary.Interfaces.chess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InitialTrainingLibrary.Amman.UnitTests
{
    [TestClass]
    public class DebugChessTest
    {
        [TestMethod]
        public void GoGame()
        {
            var testBoard = new Board();

            Assert.AreEqual(0, 0); // for breakpoint stop


        }
    }
}
