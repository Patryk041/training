using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.GhostRider.YourWork.TasksTrainingTwo;
using Toci.Hornets.Rzeszow.KSebal.traning2Homework;
using Toci.Hornets.Rzeszow.KSebal.traning2Homework.Pesel;

namespace Toci.Hornets.UnitTests.Rzeszow.Ksebal
{
    [TestClass]
   public  class Testy
    {

          [TestMethod]

           public void AnagramTest()
           {
              KsebalPeselValidator validator= new KsebalPeselValidator();

              
              Assert.IsTrue(validator.IsPeselValid("60813197717"));
              Assert.IsTrue(validator.IsPeselValid("04222959506"));
              Assert.IsTrue(validator.IsPeselValid("04222959506"));
              Assert.IsTrue(validator.IsPeselValid("92822998212"));
              Assert.IsFalse(validator.IsPeselValid("92822998211"));











           }
       
    }
}
