namespace Anathema.Generics.Chor
{
    public interface IHandler<TRefCHorEntity>
    {
        void Handle(TRefCHorEntity entity);
    }
}