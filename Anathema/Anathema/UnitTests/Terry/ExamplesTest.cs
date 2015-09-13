using System;
using System.Collections.Generic;
using Anathema.Terry.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Terry
{
    [TestClass]
    public class ExamplesTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var usersList = new List<User>()
            {
                new User()
                {
                    Age = 20,
                    Name = "Mariusz",
                },
                new User()
                {
                    Age = 34,
                    Name = "Marcin"
                },
                new User()
                {
                    Age = 16,
                    Name = "Marcin"
                },
                new User()
                {
                    Age = 28,
                    Name = "Adam"
                },
                new User()
                {
                    Age = 12,
                    Name = "Jan"
                }
            };

            UserValidator validator = new UserValidator();

            var testResult = validator.ValidateUsers(usersList);
        }
    }
}
