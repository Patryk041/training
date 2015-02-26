using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InitialTrainingLibrary.Interfaces.chess;

namespace InitialTrainingLibrary.szymon93._2__Chess
{
	class Board : IBoard
	{
		//Fields
		IBoardField[,] boardFields;

		//Constructors
		public Board()
		{

		}
		
		//Methods
		public IBoardField[,] GetFields()
		{
			return boardFields;
		}
	}
}
