using System;
using System.IO;
using System.Runtime.Serialization;

namespace Toci.Hornets.Bytom.Common.DrHouse.Logic
{
	public interface ISerialization
	{
		Object Serialize(Stream data);

		Stream DeserializeStream(Object obj);
	}
}