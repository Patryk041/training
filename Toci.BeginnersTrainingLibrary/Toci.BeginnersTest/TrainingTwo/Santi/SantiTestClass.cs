using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Santi;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Streams;
using Toci.BeginnersTrainingLibrary.TrainingTwo.Santi.Extensions;

namespace Toci.BeginnersTest.TrainingTwo.Santi
{
	[TestClass]
	public class SantiTestClass
	{
		[TestMethod]
		public void SantiGetBankFileNameTest()
		{
			string TestString = "sdfdscsdcsa\\csacsac\\asdcsac\\dsva\\ascd\\cd\\cs\\data\\ing.txt";
			Assert.AreEqual("ing.txt",TestString.GetBankFileName());
			Assert.AreNotEqual("img.txt", TestString.GetBankFileName());

			TestString = "sdfdscsdcsa\\csacsac\\asdcsac\\dsva\\ascd\\cd\\cs\\data\\multibank.txt";
			Assert.AreEqual("multibank.txt", TestString.GetBankFileName());
			Assert.AreNotEqual("\\multibank.txt", TestString.GetBankFileName());

			TestString = "sdfdscsdcsa\\csacsac\\asdcsac\\data\\dsvasdw";
			Assert.AreEqual("dsvasdw", TestString.GetBankFileName());
			Assert.AreNotEqual("\\dsvasdw.txt", TestString.GetBankFileName());
		}

		[TestMethod]
		public void SantiTransferFileParserINGTest()
		{
			SantiTransferFileParserING IngParser = new SantiTransferFileParserING();
			
			var results = IngParser.OpenFile(@"..\..\..\Toci.BeginnersTrainingLibrary\TrainingTwo\data\\ing.txt");

			Assert.AreEqual("imie", results[0].Name);
			Assert.AreNotEqual("Mikołajewicz", results[0].Name);

			Assert.AreEqual("nazwisko", results[0].Surname);
			Assert.AreNotEqual("Szymon", results[0].Surname);

			Assert.AreEqual("konto", results[0].Account);
			Assert.AreNotEqual("234235432524", results[0].Account);

			Assert.AreEqual("kwota", results[0].Amount);
			Assert.AreNotEqual("2015", results[0].Amount);

			Assert.AreEqual("data", results[0].Date);
			Assert.AreNotEqual("2342-35-43", results[0].Date);

			Assert.AreEqual("nadawaca", results[0].Sender);
			Assert.AreNotEqual("Santi", results[0].Sender);
		}

		[TestMethod]
		public void SantiTransferFileParserMultibankTest()
		{
			SantiTransferFileParserMultibank MultibankParser = new SantiTransferFileParserMultibank();

			var results = MultibankParser.OpenFile(@"..\..\..\Toci.BeginnersTrainingLibrary\TrainingTwo\data\\multibank.txt");

			Assert.AreEqual("imie", results[0].Name);
			Assert.AreNotEqual("Mikołajewicz", results[0].Name);

			Assert.AreEqual("nazwisko", results[0].Surname);
			Assert.AreNotEqual("Szymon", results[0].Surname);

			Assert.AreEqual("konto", results[0].Account);
			Assert.AreEqual("zaba", results[1].Account);
			Assert.AreNotEqual("234235432524", results[0].Account);

			Assert.AreEqual("kwota", results[0].Amount);
			Assert.AreNotEqual("2015", results[0].Amount);

			Assert.AreEqual("data", results[0].Date);
			Assert.AreNotEqual("2342-35-43", results[0].Date);

			Assert.AreEqual(null, results[0].Sender);
			Assert.AreNotEqual("Santi", results[0].Sender);
		}

		[TestMethod]
		public void SantiReadTransferFilesTest()
		{
			SantiTransfers Transfers = new SantiTransfers();

			var results = Transfers.ReadTransferFiles();

			Assert.AreEqual("..\\..\\..\\Toci.BeginnersTrainingLibrary\\TrainingTwo\\data\\ing.txt", results[0]);
			Assert.AreEqual("..\\..\\..\\Toci.BeginnersTrainingLibrary\\TrainingTwo\\data\\multibank.txt", results[1]);
		}

		[TestMethod]
		public void SantiGetAllTransfersTest()
		{
			SantiTransfers Transfers = new SantiTransfers();

			var ReadedFiles = Transfers.ReadTransferFiles();

			var result = Transfers.GetAllTransfers(ReadedFiles);
		}
	}
}
