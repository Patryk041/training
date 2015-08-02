using System;
using System.Collections.Generic;

namespace Toci.Hornets.GhostRider.TrainingFive.Generics
{
    public class RegularFactory<TFactoryItem>  //ChorHandlerStack<TRefChorStackHandler, TSegment>
    {
        protected Dictionary<string, Func<TFactoryItem>> factoryItemsList;
        //protected Dictionary<string, Func<TFactoryItem>> factoryItemsList;


        public TFactoryItem GetFactoryElement(string key)
        {
            return factoryItemsList[key]();
        }
    }
}