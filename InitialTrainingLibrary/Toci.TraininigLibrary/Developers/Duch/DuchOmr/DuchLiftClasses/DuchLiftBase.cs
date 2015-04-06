using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Duch.DuchOmr.DuchInterfaces;

namespace Toci.TraininigLibrary.Developers.Duch.DuchOmr.DuchLiftClasses
{
	public class DuchLiftBase	   : IDuchLift
	{
		protected DuchLiftBase(string liftname)
		{
			this.LiftName = liftname;
		}

		public string LiftName { get; set; }

		public string GetName()
		{
			return LiftName;
		}

		

		public string Lift(IDuchRider rider)
		{
			return rider.WhatAmIRiding();
			
		}
	}
}
