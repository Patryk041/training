namespace Toci.Hornets.BankFactory.Chor
{
    public interface IHandler<TRefCHorEntity>
    {
        void Handle(TRefCHorEntity entity);
    }
}