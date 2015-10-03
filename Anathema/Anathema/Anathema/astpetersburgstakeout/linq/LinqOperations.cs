using System.Collections.Generic;
using System.Linq;

namespace Anathema.stpetersburgstakeout.linq
{
    public class LinqOperations
    {
        public Dictionary<string, string> ListaSlownikowa = new Dictionary<string, string>
        {
            { "adamW", "Developer" },
            { "blacha", "Developer" },
            { "bolec", "Developer" },
            { "coffeee", "Developer" },
            { "darek", "Developer" },
            { "daweidson", "Developer" },
            { "patryk", "Architect" },
            { "terry", "Architect" },
        };

        public List<string> GetDevelopersList(string value)
        {
            return ListaSlownikowa.Where(item => item.Value == value).Select(item => item.Key).ToList();
        }
    }
}