using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.szymon93._2__Chess
{
	class Coordinates : ICoordinates
	{
		//Fields
		public int x, y;

		//Constructors
		public Coordinates(int X, int Y)
		{
			x = X;
			y = Y;
		}

		//Methods
		public int GetX()
		{
			return x;
		}

		public int GetY()
		{
			return y;
		}
	}
}
