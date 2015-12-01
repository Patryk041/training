using Anathema.Patryk.TrainingOne.Chess;

namespace Anathema.Rhonin.Chess
{
    public class Board
    {
        private int _width = 8;
        private int _heigh = 8;
        BoardField[,] _boardField;

        public Board()
        {
            _boardField[_width, _heigh] = new BoardField();
        }


        public BoardField[,] GetFields()
        {
            return _boardField;
        }

    }
}