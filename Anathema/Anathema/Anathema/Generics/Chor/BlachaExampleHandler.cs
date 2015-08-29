namespace Anathema.Generics.Chor
{
    public class BlachaExampleHandler : IHandler<EntityRefTypeChor> //Credibility -> BlachaExample
    {
        public void Handle(EntityRefTypeChor entity)
        {
            entity.Credibility = new Credibility();


        }
    }
}