namespace Toci.Hornets.GhostRider.NFZ.Przychodnia.Base.Interface
{
    public interface IAdditionalFeature<T>
    {
        string ReturnName();
        string ReturnValue();
        T GetFeature();
    }
}