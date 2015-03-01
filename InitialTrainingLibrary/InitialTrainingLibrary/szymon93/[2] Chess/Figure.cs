using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.szymon93._2__Chess
{
	class Figure : IFigure
	{
		//Fields
		public bool isWhite;
        // private int x, y; // Temporary redundant
        int ID; 
		FigureKind figureKind;
		ICoordinates coordinates;

		//Constructors
		public Figure(bool isWhite, FigureKind figureKind, int ID)
		{
			this.isWhite = isWhite;
			this.figureKind = figureKind;
			this.ID = ID;
		}

		//Methods
		public bool IsFigureWhite()
		{
			return isWhite;
		}

		public ICoordinates GetCoordinates()
		{
			return coordinates;
		}

		public bool Move(ICoordinates newCoordinates)
		{
			if(newCoordinates == coordinates)
				return false;
			else
			{
				coordinates = new Coordinates(newCoordinates.GetX(),newCoordinates.GetY());
				return true;
			}
		}

		public FigureKind GetFigureKind()
		{
			return figureKind;
		}
	}
}
