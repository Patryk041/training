using Toci.Hornets.Cars.Abstract;

namespace Toci.Hornets.Cars
{
    public class Honda : ICar
    {
        public Honda()
        {
            Description = "Honda";
        }

        public bool Drive()
        {
            return true;
        }

        public Color Color { get; set; }
        public string Description { get; set; }
    }
}