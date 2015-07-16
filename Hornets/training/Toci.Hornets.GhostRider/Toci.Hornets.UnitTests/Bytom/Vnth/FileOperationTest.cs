using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Bytom.Coffee13.TaskTrainingTree;

namespace Toci.Hornets.UnitTests.Bytom.Vnth
{
	[TestClass]
	public class FileOperationTest
	{
		[TestMethod]
		public void FileOperationTestMethod()
		{
			var fo = new CoffeeFileOperation();

			//path fun, such fun
			Assert.AreEqual(fo.GetFileContent(@"..\..\Bytom\Coffee13\ContentFile.txt"), "Dane testowe");
			//Assert.AreEqual(fo.GetFileContent(@"ContentFile.txt"), "Dane testowe");		//file in Debug directory
			Assert.AreNotEqual(fo.GetFileContent(@"~\..\..\Bytom\Coffee13\ContentFile.txt"), "Dane testowe");
			Assert.AreNotEqual(fo.GetFileContent(@"~\Bytom\Coffee13\ContentFile.txt"), "Dane testowe");
		}
	}
}
