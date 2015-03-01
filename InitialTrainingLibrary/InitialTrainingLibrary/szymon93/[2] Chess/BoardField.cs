using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.szymon93._2__Chess
{
	class BoardField : IBoardField
	{
		//Fields
		ICoordinates coordinates = null;
		IFigure figure;
		int x, y;

		//Constructors
		public BoardField(IFigure figure, int X, int Y)
		{
			x = X;
			y = Y;
			this.figure = figure;
		}

		//Methods
		public bool IsFieldWhite()
		{
			bool isWhite = false;
			//White if remainder of division coordinates by 2 is equal to 0
			if((coordinates.GetX() + coordinates.GetY()) % 2 == 0)
				isWhite = true;

			return isWhite;
		}

		public ICoordinates GetCoordinates()
		{
			return coordinates;
		}

		public bool HasFigure()
		{
			bool hasFigure = false;
			if(figure != null)
				hasFigure = true;

			return hasFigure;
		}

		public void SetFigure(IFigure figure)
		{
			this.figure = figure;
		}

		public IFigure GetFigure()
		{
			return figure;
		}
	}
}
