using System;
using System.Collections.Generic;
using System.Net.Configuration;
using Toci.Hornets.GhostRider.InterfacesExtending;
using Toci.Hornets.GhostRider.TElephoneCommunication;


namespace Toci.Hornets.Sieradz.Duch
{
    public class DuchTelephoneFactory : DuchGenFactory<int,Func<ITelephoneCommunication>> 
    {
        public DuchTelephoneFactory()
        {
            FactoryDictionary = new Dictionary<int, Func<ITelephoneCommunication>> ()
            {
                {1,() => new PhotoCommunication()},
                {2,() => new SmsCommunication()},
                {3,() => new VoiceCommunication()}   
            };
        }

    }
}