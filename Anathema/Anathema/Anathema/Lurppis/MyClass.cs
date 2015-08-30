using Anathema.Generics;

namespace Anathema.Lurppis
{
    public class MyClass : GhostRiderBase
    {
        public virtual bool AddElement(object item, bool unique = true)
        {
            return true;
        }

        public override string GetBankName()
        {
            throw new System.NotImplementedException();
        }
    }
}