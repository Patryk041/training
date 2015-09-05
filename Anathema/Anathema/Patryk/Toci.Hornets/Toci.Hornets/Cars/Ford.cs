using Toci.Hornets.Cars.Abstract;

namespace Toci.Hornets.Cars
{
    public class Ford : ICar
    {
        public Ford()
        {
            Description = "Ford";
        }


        public bool Drive()
        {
            return true;
        }

        public Color Color { get; set; }
        public string Description { get; set; }
    }
}