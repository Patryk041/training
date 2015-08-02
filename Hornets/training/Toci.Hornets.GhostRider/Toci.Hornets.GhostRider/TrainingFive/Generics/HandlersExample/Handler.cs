namespace Toci.Hornets.GhostRider.TrainingFive.Generics.HandlersExample
{
    public abstract class Handler<TRefParam, TRefSegment> //where TRefParam : object
    {
        private static object lockObject;

        public virtual void RunHandlerOperation(TRefParam refChorParam)
        {
            if (refChorParam == null)
            {
                return;
            }

            var result = Operate(refChorParam);

            lock (lockObject)
            {
                SaveDataInType(refChorParam, result);
            }
        }

        protected abstract TRefSegment Operate(TRefParam refChorParam);
        protected abstract bool SaveDataInType(TRefParam refChorParam, TRefSegment segment);
    }
}