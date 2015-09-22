using Anathema.Lurppis.Wzorce.FactoryMethos.Interface;

namespace Anathema.Lurppis.Wzorce.FactoryMethos.Abstract
{
    public abstract class Animal : IAnimal
    {
        public abstract string Sound();

        public Color Color { get; set; }
    }
}