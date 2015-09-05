using Toci.Hornets.Cars.Abstract;

namespace Toci.Hornets.Cars
{
    public class Fiat : ICar
    {
        public Fiat()
        {
            Description = "Fiat";
        }

        public bool Drive()
        {
            return true;
        }

        public Color Color { get; set; }
        public string Description { get; set; }
    }
}