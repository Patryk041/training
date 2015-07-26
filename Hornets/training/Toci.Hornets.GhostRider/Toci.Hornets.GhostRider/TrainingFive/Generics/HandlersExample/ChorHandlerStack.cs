using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Toci.Hornets.GhostRider.TrainingFive.Generics.HandlersExample
{
    public class ChorHandlerStack<TRefChorStackHandler, TSegment>
    {
        protected List<Handler<TRefChorStackHandler, TSegment>> handlers;

        public void RunAllHandlers(TRefChorStackHandler refType)
        {

            handlers.AsParallel().WithDegreeOfParallelism(4).ForAll(handler => handler.RunHandlerOperation(refType));
            //Stopwatch 
//            foreach (var handler in handlers)
//            {
//                handler.RunHandlerOperation(refType);
//            }
        }
    }
}