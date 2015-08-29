using Anathema.Generics;

namespace Anathema.Lurppis
{
    public class MyClass : GhostRiderBase
    {
        public string write()
        {
            return "Yo";
        }

        public override string GetBankName()
        {
            throw new System.NotImplementedException();
        }
    }
}