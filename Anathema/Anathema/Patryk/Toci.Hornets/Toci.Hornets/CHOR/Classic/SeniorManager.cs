using System;

namespace Toci.Hornets.CHOR.Classic
{
    public class SeniorManager : Handler
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
            return (mobile.Type == Type.Premium);
        } 
    }
}