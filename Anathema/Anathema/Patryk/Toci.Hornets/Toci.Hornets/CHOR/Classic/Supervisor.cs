using System;

namespace Toci.Hornets.CHOR.Classic
{
    class Supervisor : Handler
    {
        public override void HandleRequest(Mobile mobile)
        {
            if (CanHandle(mobile))
            {
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(mobile);
            }
        }
        public bool CanHandle(Mobile mobile)
        {
            return (mobile.Type == Type.Budget);
        }
    }
}