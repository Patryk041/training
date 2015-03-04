using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Santi.FileParser
{
	public class SantiFileParser : FileParser<SantiFileHeaderParser,SantiFileDetailParser,SantiFileFooterParser>
	{
		//Fields

		//Constructors
		public SantiFileParser(string fileName, SantiFileDetailParser detailParser) : base(fileName, new SantiFileDetailParser())
		{
		}

		//Methods
		public override string GetName()
		{
			return "Santi";
		}

		public override void Dispose()
		{
			throw new NotImplementedException();
		}
	}
}
