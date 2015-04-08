using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Duch.DuchOmr;
using Toci.TraininigLibrary.Developers.Duch.DuchOmr.DuchRiderClasses;
using Toci.TraininigLibrary.Developers.Duch.DuchOmr.DuchUtilities;


namespace Toci.TrainingLibrary.Test.Developers.Duch.DuchOmrTest
{
	[TestClass]
	public class DuchRiderFactoryTest
	{
		[TestMethod]
		public void test()
		{
			var RiderAndrzej = DuchRiderFactory.CreateRiderInstance(DuchUtilitiesClass.RiderType.Skier);
			var RiderGerwazy = DuchRiderFactory.CreateRiderInstance(DuchUtilitiesClass.RiderType.Snowboarder);
			var rider = RiderAndrzej.GetRiderType();
			var rider2 = RiderGerwazy.GetRiderType();
			var fahrzeug1 = RiderAndrzej.WhatAmIRiding();
			var fahrzeug2 = RiderGerwazy.WhatAmIRiding();
			var lift1 = new DuchLift("MountyMountain");
			var lift1name = lift1.GetName();
			var lift1liftsombiczes = lift1.Lift(RiderAndrzej);
		}
	}
}
