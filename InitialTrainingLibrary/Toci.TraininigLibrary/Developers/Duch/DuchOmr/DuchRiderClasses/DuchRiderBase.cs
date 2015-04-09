using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Duch.DuchOmr.DuchInterfaces;

namespace Toci.TraininigLibrary.Developers.Duch.DuchOmr.DuchRiderClasses
{
	public class DuchRiderBase : IDuchRider
	{
		public string GetRiderType()
		{
			return RiderType;
		}
		public string Stefan()
		{
			return RiderType;
		}

		public string RiderType { get; set; }

		public virtual string WhatAmIRiding()
		{
			throw new NotImplementedException();
		}

		public DuchRiderBase(string name)
		{
			this.RiderType = name;
		}

		
	}
}
