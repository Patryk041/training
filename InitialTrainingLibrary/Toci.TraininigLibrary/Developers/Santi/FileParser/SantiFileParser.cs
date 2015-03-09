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
		//Constructors
		public SantiFileParser() : base(new SantiFileDetailParser())
		{

		}

		//Methods
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
