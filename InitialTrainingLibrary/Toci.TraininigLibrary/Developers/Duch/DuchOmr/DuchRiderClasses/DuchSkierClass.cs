using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Duch.DuchOmr.DuchInterfaces;

namespace Toci.TraininigLibrary.Developers.Duch.DuchOmr.DuchRiderClasses
{
	class DuchSkierClass	  : IDuchRider
	{
		public string GetName()
		{
			return "skier";
		}
	}
}
