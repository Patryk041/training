using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.TraininigLibrary.Developers.Duch.DuchOmr;
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
			var rider = RiderAndrzej.GetName();
			var rider2 = RiderGerwazy.GetName();

		}
	}
}
