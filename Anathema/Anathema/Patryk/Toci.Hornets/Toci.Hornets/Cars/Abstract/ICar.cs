namespace Toci.Hornets.Cars.Abstract
{
    public interface ICar
    {
        bool Drive();

        Color Color { get; set; }

        string Description { get; set; }
    }
}