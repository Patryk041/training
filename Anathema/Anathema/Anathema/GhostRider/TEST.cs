using System;
using System.Collections.Generic;

namespace Anathema.GhostRider
{
    public abstract class TEST<T,T2>
    {
        private Dictionary<T, Func<T2>> dict;
    }
}