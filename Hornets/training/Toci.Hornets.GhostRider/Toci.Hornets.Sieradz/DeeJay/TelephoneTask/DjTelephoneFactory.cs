using System;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.Sieradz.Duch;

namespace Toci.Hornets.Sieradz.DeeJay.TelephoneTask
{
    public class DjTelephoneFactory : DuchTelephoneFactory
    {
        public override Func<ITelephoneCommunication> GetInstance(int key)
        {
            return FactoryDictionary.ContainsKey(key) ? FactoryDictionary[key] : null;
        }
    }
}