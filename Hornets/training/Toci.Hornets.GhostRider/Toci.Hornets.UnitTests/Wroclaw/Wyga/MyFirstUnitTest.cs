using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Wroclaw.Wyga;

namespace Toci.Hornets.UnitTests.Wroclaw.Wyga
{
    [TestClass]
    public class MyFirstUnitTest
    {
       
            [TestMethod]
            public void CheckMyStrings()
            {
                StringTask myTask = new StringTask();
               
                    var results = myTask.RunStringOperations("Wojtek", "Wojtek");
                  
                    Assert.IsTrue(results.IsStringInString);
                    //Assert.IsTrue(results.IsAnagram);
             
            }



        
    }
}
