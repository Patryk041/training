namespace Anathema.Patryk.TrainingOne.Chess.Abstract
{
    public interface IFigure
    {
        bool Move();

        string Color { get; set; }

        string Description { get; set; }
    }
}