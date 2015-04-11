using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Duch.DuchOmr.DuchInterfaces;

namespace Toci.TraininigLibrary.Developers.Duch.DuchOmr.DuchRiderClasses
{
	public class DuchSkierClass	  : DuchRiderBase
	{
		public DuchSkierClass(string name) : base(name)
		{
		}

		public override string WhatAmIRiding()
		{
			return "Skies bicz";
		}
	}
}
