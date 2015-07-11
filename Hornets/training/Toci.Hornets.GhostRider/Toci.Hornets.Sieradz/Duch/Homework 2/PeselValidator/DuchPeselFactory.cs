using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Sieradz.Duch.Homework_2.PeselValidator
{
	class DuchPeselFactory : DuchGenFactory<Func<int, bool>, int[]>
	{


		public DuchPeselFactory()
		{

			FactoryDictionary = new Dictionary<Func<int, bool>, int[]>()
            {
                { x => x > 80 ,   new[]{1800,80}   },
                { x => x > 60 ,   new[]{2200,60}   },
                { x => x > 40 ,   new[]{2100,40}   },
                { x => x > 20 ,   new[]{2000,20}   },
                { x => x < 13 ,   new[]{1900,00}   }
            };


		}


		public int[] GetInstance(int month)
		{
			return GetDate(month);
		}

		private int[] GetDate(int month)
		{
			return FactoryDictionary.Where(item => item.Key(month)).Select(item => item.Value).FirstOrDefault();
		}
	}
}