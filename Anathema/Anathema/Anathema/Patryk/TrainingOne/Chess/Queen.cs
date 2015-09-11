using Anathema.Patryk.TrainingOne.Chess.Abstract;

namespace Anathema.Patryk.TrainingOne.Chess
{
    public class Queen : IFigure
    {
        public Queen()
        {
            Description = "Queen";
        }

        public bool Move()
        {
            return true;
        }

        public string Color { get; set; }
        public string Description { get; set; }
    }
}