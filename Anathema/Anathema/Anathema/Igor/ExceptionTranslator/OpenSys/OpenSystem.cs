using System.Collections.Generic;

namespace Anathema.Igor.ExceptionTranslator.OpenSys
{
    public abstract class OpenSystem
    {
        protected Dictionary<int, string> Elements = new Dictionary<int, string>();

        public virtual Dictionary<int, string> GetList()
        {
            return Elements;
        }
    }
}