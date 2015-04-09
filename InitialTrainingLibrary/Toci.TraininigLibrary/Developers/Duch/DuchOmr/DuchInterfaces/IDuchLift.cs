using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.TraininigLibrary.Developers.Duch.DuchOmr.DuchInterfaces
{
	public interface IDuchLift
	{
		string GetName();
		string LiftName { get; set; }
		string Lift(IDuchRider rider);
		
	}
}
