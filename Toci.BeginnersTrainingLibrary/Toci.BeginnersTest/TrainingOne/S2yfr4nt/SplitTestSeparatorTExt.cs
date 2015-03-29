using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingTwo.common;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;

namespace Toci.BeginnersTest.TrainingOne.S2yfr4nt
{
    [TestClass]
    public class SplitTestSeparatorTExt
    {
        [TestMethod]
        public void SplitTest()
        {
            string testLine = "recha; fdadsf; asdfs; asfds; asfdsf;";
            var result = StringHelper.GetSeparatedItems("; ", testLine);
            Assert.IsTrue(5==result.Count);
        }

        [TestMethod]
        public void OpenAndParseFileTest()
        {
            RandomGenericFileParser parser = new RandomGenericFileParser();
            // ...\..\..\
            var result = parser.OpenFile(@"D:\self\trainings\Dropbox\szkolenie\v 2.0\code\Toci.BeginnersTrainingLibrary\Toci.BeginnersTrainingLibrary\TrainingTwo\data\multibank.txt");




        }
    }
}
