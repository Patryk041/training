using Anathema.Generics;

namespace Anathema.Mati
{
    public class MyNewClass : GhostRiderBase
	{
		public string MyNewMessage()
		{
			return "Hy";

		}

        public override string GetBankName()
        {
            throw new System.NotImplementedException();
        }
	}
}