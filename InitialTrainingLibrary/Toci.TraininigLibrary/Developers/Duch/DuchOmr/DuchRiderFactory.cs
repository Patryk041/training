using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toci.TraininigLibrary.Developers.Duch.DuchOmr.DuchInterfaces;
using Toci.TraininigLibrary.Developers.Duch.DuchOmr.DuchRiderClasses;
using Toci.TraininigLibrary.Developers.Duch.DuchOmr.DuchUtilities;

namespace Toci.TraininigLibrary.Developers.Duch.DuchOmr
{
	public  class DuchRiderFactory
	{
		private static Dictionary<DuchUtilitiesClass.RiderType,Func<IDuchRider>> RidersDictionary = new Dictionary<DuchUtilitiesClass.RiderType, Func<IDuchRider>>()
		{
		  {DuchUtilitiesClass.RiderType.Skier, ()=> new DuchSkierClass("Skier")},
		  {DuchUtilitiesClass.RiderType.Snowboarder, ()=> new DuchSnowboarderClass("Snowboarder")}
		};

		 

		public static IDuchRider CreateRiderInstance(DuchUtilitiesClass.RiderType riderType)
		{
			return RidersDictionary.ContainsKey(riderType) ? RidersDictionary[riderType]() : null;

		}

		
	}
}
