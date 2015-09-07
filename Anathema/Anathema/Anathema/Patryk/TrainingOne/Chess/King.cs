using Anathema.Patryk.TrainingOne.Chess.Abstract;

namespace Anathema.Patryk.TrainingOne.Chess
{
    public class King : IFigure
    {
        public King()
        {
            Description = "King";
        }

        public bool Move()
        {
            return true;
        }

        public string Color { get; set; }

        public string Description { get; set; }
    }
}