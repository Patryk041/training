using System.Collections.Generic;
using Toci.Hornets.GhostRider.NFZ.Przychodnia.ResourcesRequest;

namespace Toci.Hornets.GhostRider.NFZ.Przychodnia.Requestors
{
    public class NFZRequestor<TKey,TValue> : Requestor<INFZPatientIdentification,string> 
    {
        protected Dictionary<TKey, TValue> InstitutionDictionary;
        public override INFZPatientIdentification SendRequest(string request)
        {
            return default(INFZPatientIdentification);
        }
    }
}