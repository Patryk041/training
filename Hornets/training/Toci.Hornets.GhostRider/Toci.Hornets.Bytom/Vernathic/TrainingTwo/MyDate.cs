using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toci.Hornets.Bytom.Vernathic.TrainingTwo
{
	class MyDate
	{
		public int Day { get; set; }
		public int Month { get; set; }
		public int Year { get; set; }


		private static MyDate _date;

		private MyDate() { }

		public MyDate Date
		{
			get
			{
				return _date ?? (_date = new MyDate());
				//if (date == null)
				//{
				//	date = new MyDate();
				//}
				//return date;
			}
		}
	}
}
