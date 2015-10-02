namespace Anathema.Generics
{
    public interface IAbstractFactory<T>
    {
        T Create(string index);
    }
}