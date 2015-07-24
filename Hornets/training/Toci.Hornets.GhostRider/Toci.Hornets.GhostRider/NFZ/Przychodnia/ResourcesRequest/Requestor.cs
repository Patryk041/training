namespace Toci.Hornets.GhostRider.NFZ.Przychodnia.ResourcesRequest
{
    public abstract class Requestor<TReturn,TRequest> //where TRequest
    {
        public abstract TReturn SendRequest(TRequest reuqest);
    }
}