using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anathema.rbedkowski.FilesOperations
{
    [TestClass]
    public class TestFilesOperations
    {
        [TestMethod]
        public void MainFileTest()
        {
            try
            {
                List<string> ListOfSTring = new List<string>();
                StreamReader reader;
                string Line;
                using (reader = new StreamReader("tekst.txt"))
                {
                    while ((Line = reader.ReadLine()) != null)
                    {
                        ListOfSTring.Add(Line);
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
