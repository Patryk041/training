using System.Collections.Generic;

namespace Anathema.Generics.Chor
{
    public abstract class AbstractChainOfResponsibility<THandler, TRefCHorEntity> where THandler : IHandler<TRefCHorEntity>
    {
        protected List<THandler> Handlers;

        public virtual void Handle(TRefCHorEntity entity)
        {
            foreach (var handler in Handlers)
            {
                handler.Handle(entity);
            }
        }
    }
}