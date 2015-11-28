using System.Collections.Generic;

namespace Anathema.Rhonin.Chess
{
    public class Chess
    {
        BoardField board;

        public Chess()
        {
            BoardField board = new BoardField();
            List<IFigure> figures = new List<IFigure>();
            
        }

        public BoardField GetBoardField()
        {
            return board;
        }
    }
}