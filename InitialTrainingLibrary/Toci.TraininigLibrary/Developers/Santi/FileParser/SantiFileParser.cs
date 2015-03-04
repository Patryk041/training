using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Santi.FileParser
{
	public class SantiFileParser : FileParser<SantiFileHeaderParser,SantiFileDetailParser,SantiFileFooterParser>
	{
		//Fields
		private string FilePath;
		private SantiFileDetailParser detailParser;

		//Constructors
		public SantiFileParser(string fileName, SantiFileDetailParser detailParser) : base(fileName, new SantiFileDetailParser())
		{
			FilePath = fileName;
			this.detailParser = detailParser;
		}

		//Methods
		public FileEntityBase GetParsedData(string line)
		{
			return detailParser.ReadEntry(line);
		}

		public override string GetName()
		{
			return "Santi";
		}

		public override void Dispose()
		{
			GC.Collect();
		}
	}
}
