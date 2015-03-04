using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Santi.FileParser;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TrainingLibrary.Test.Developers.Santi
{
	[TestClass]
	public class SantiFileParserTest
	{
		string FilePath = @"..\..\..\Toci.TraininigLibrary\data\transfer_2015-03-04_123456789_santi.txt";
		StreamReader stream;
		List<string> FieldsRead = new List<string>();

		[TestMethod]
		public void SantiFileDetailParserObjectTest()
		{
			List<FileEntityBase> FileEntityList = new List<FileEntityBase>();	

			SantiFileDetailParser fileDetailParser = new SantiFileDetailParser();

			using(stream = new StreamReader(FilePath))
			{
				while(!stream.EndOfStream)
					FieldsRead.Add(stream.ReadLine());
			}

			for(int i=0; i<FieldsRead.Count; i++)
				FileEntityList.Add(fileDetailParser.ReadEntry(FieldsRead[i]));

			Assert.AreEqual("Szymon", FileEntityList[0].Name);
			Assert.AreEqual("Mikołajewicz", FileEntityList[0].Surname);
			Assert.AreEqual("2015-03-04", FileEntityList[0].Date.ToShortDateString());
			Assert.AreEqual("123456789", FileEntityList[0].Account);
			Assert.AreEqual("Jan", FileEntityList[1].Name);
			Assert.AreEqual("Nowak", FileEntityList[1].Surname);
			Assert.AreEqual("2014-12-27", FileEntityList[1].Date.ToShortDateString());
			Assert.AreEqual("2353", FileEntityList[1].Account);
			Assert.AreEqual("Karol", FileEntityList[2].Name);
			Assert.AreEqual("Grandek", FileEntityList[2].Surname);
			Assert.AreEqual("2014-10-23", FileEntityList[2].Date.ToShortDateString());
			Assert.AreEqual("420432", FileEntityList[2].Account);

			Assert.AreNotEqual("Szymoon", FileEntityList[0].Name);
			Assert.AreNotEqual("Mikołajkiewicz", FileEntityList[0].Surname);
			Assert.AreNotEqual("2015-03-03", FileEntityList[0].Date.ToShortDateString());
			Assert.AreNotEqual("123446789", FileEntityList[0].Account);
			Assert.AreNotEqual("Janek", FileEntityList[1].Name);
			Assert.AreNotEqual("Nwak", FileEntityList[1].Surname);
			Assert.AreNotEqual("2014-12-26", FileEntityList[1].Date.ToShortDateString());
			Assert.AreNotEqual("2352", FileEntityList[1].Account);
			Assert.AreNotEqual("Karl", FileEntityList[2].Name);
			Assert.AreNotEqual("Grand", FileEntityList[2].Surname);
			Assert.AreNotEqual("2015-10-23", FileEntityList[2].Date.ToShortDateString());
			Assert.AreNotEqual("420431", FileEntityList[2].Account);
		}

		[TestMethod]
		public void SantiFileParserObjectTest()
		{
			SantiFileParser fileParser = new SantiFileParser(FilePath, new SantiFileDetailParser());

			using(stream = new StreamReader(FilePath))
			{
				while(!stream.EndOfStream)
					FieldsRead.Add(stream.ReadLine());
			}

			Assert.AreEqual("Szymon", fileParser.GetParsedData(FieldsRead[0]).Name);
			Assert.AreEqual("Mikołajewicz", fileParser.GetParsedData(FieldsRead[0]).Surname);
			Assert.AreEqual("2015-03-04", fileParser.GetParsedData(FieldsRead[0]).Date.ToShortDateString());
			Assert.AreEqual("123456789", fileParser.GetParsedData(FieldsRead[0]).Account);
			Assert.AreEqual("Jan", fileParser.GetParsedData(FieldsRead[1]).Name);
			Assert.AreEqual("Nowak", fileParser.GetParsedData(FieldsRead[1]).Surname);
			Assert.AreEqual("2014-12-27", fileParser.GetParsedData(FieldsRead[1]).Date.ToShortDateString());
			Assert.AreEqual("2353", fileParser.GetParsedData(FieldsRead[1]).Account);
			Assert.AreEqual("Karol", fileParser.GetParsedData(FieldsRead[2]).Name);
			Assert.AreEqual("Grandek", fileParser.GetParsedData(FieldsRead[2]).Surname);
			Assert.AreEqual("2014-10-23", fileParser.GetParsedData(FieldsRead[2]).Date.ToShortDateString());
			Assert.AreEqual("420432", fileParser.GetParsedData(FieldsRead[2]).Account);

			Assert.AreNotEqual("Szymoon", fileParser.GetParsedData(FieldsRead[0]).Name);
			Assert.AreNotEqual("Mikołajkiewicz", fileParser.GetParsedData(FieldsRead[0]).Surname);
			Assert.AreNotEqual("2015-03-03", fileParser.GetParsedData(FieldsRead[0]).Date.ToShortDateString());
			Assert.AreNotEqual("123446789", fileParser.GetParsedData(FieldsRead[0]).Account);
			Assert.AreNotEqual("Janek", fileParser.GetParsedData(FieldsRead[1]).Name);
			Assert.AreNotEqual("Nwak", fileParser.GetParsedData(FieldsRead[1]).Surname);
			Assert.AreNotEqual("2014-12-26", fileParser.GetParsedData(FieldsRead[1]).Date.ToShortDateString());
			Assert.AreNotEqual("2352", fileParser.GetParsedData(FieldsRead[1]).Account);
			Assert.AreNotEqual("Karl", fileParser.GetParsedData(FieldsRead[2]).Name);
			Assert.AreNotEqual("Grand", fileParser.GetParsedData(FieldsRead[2]).Surname);
			Assert.AreNotEqual("2015-10-23", fileParser.GetParsedData(FieldsRead[2]).Date.ToShortDateString());
			Assert.AreNotEqual("420431", fileParser.GetParsedData(FieldsRead[2]).Account);
		}
	}
}
