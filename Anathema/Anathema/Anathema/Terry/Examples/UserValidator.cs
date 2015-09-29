using System.Collections.Generic;
using Anathema.Terry.Examples.Interfaces;

namespace Anathema.Terry.Examples
{
    public class UserValidator
    {
        public List<User> ValidateUsers(List<User> usersList)
        {
            var results = new List<User>();

            foreach (var user in usersList)
            {
               if (user.Name == "Marcin")
                {
                    results.Add(user);
                }
            }
            
            return results;
        } 
    }
}