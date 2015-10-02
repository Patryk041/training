namespace Anathema.Patryk.TrainingOne.Cars.Abstract
{
    public interface ICar
    {
        bool TryDrive();

        Color Color { get; set; }

        string Description { get; set; }
    }
}