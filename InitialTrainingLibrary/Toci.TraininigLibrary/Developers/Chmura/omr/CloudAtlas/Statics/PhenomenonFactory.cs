using System;
using System.Collections.Generic;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Concrete.Phenomenons;
using Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Interface;

namespace Toci.TraininigLibrary.Developers.Chmura.omr.CloudAtlas.Statics
{
    public class PhenomenonFactory
    {
        public static Dictionary<PhenomenonKinds, Func<IPhenomenon>> SpecificPhenomenon = new Dictionary<PhenomenonKinds, Func<IPhenomenon>>()
        {
            {PhenomenonKinds.Arcus,() => new Arcus()},
            {PhenomenonKinds.Incus,() => new Incus()},
            {PhenomenonKinds.Mammatus,() => new Mammatus()},
            {PhenomenonKinds.Pannus,() => new Pannus()},
            {PhenomenonKinds.Praecipitatio,() => new Praecipitatio()},
            {PhenomenonKinds.Tuba,() => new Tuba()},
            {PhenomenonKinds.Pileus,() => new Pileus()},
            {PhenomenonKinds.Velum,() => new Velum()},
            {PhenomenonKinds.Virga,() => new Virga()}
        };
    }
}