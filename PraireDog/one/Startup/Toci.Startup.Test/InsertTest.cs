using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQLlib.SqlBases;

namespace Toci.Startup.Test
{
    [TestClass]
    public class InsertTest
    {
        Dictionary<string, string> _dictionary = new Dictionary<string, string>()
            {
                {
                    "id", "int"
                },
                {
                    "nazwaBanku", "text"
                },
                {
                    "numerKonta", "string"
                }

            };

        [TestMethod]
        public void InsertCommandTest()
        {
           var c = new SqlPostgres();
           var resault = c.PrepareInsertCommand(_dictionary, "cos");
        }
    }
}