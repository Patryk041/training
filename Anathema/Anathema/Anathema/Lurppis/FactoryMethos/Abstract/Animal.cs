using Anathema.Lurppis.FactoryMethos.Interface;

namespace Anathema.Lurppis.FactoryMethos.Abstract
{
    public abstract class Animal : IAnimal
    {
        public abstract string Sound();

        public Color Color { get; set; }
    }
}