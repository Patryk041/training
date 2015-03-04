using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Common.FileParser;

namespace Toci.TraininigLibrary.Developers.Santi.FileParser
{
	public class SantiFileDetailParser : FileDetailParserBase
	{
		public override FileEntityBase ReadEntry(string fileLine)
		{
			SantiFileEntity fileEntity = new SantiFileEntity();
			string[] fieldsArray;

			if(fileLine != null)
			{
				fieldsArray = fileLine.Split(';');

				fileEntity.SetName(fieldsArray[0]);
				fileEntity.SetSurname(fieldsArray[1]);
				fileEntity.SetAccount(fieldsArray[3]);
				
				//Now in fieldsArray [0]Year, [1]Month, [2]Day
				fieldsArray = fieldsArray[2].Split('-');
				fileEntity.SetDate(new DateTime(int.Parse(fieldsArray[0]), int.Parse(fieldsArray[1]), int.Parse(fieldsArray[2])));
			}

			return fileEntity;
		}
	}
}
