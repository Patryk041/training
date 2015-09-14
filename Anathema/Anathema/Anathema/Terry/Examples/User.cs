using System.Collections.Specialized;
using System.Security.AccessControl;
using Anathema.Terry.Examples.Interfaces;

namespace Anathema.Terry.Examples
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        

        /*private string _name;

        public string GetName()
        {
            return _name;
        }

        public void SetName(string newName)
        {
            if (newName != null)
            _name = newName;
        }*/
    }
}