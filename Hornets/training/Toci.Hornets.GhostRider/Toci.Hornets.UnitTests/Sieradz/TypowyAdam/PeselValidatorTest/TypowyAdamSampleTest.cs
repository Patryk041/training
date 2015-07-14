using System;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.Legnica.Filip_Sokolowski.homeWork.peselValidator;
using Toci.Hornets.Sieradz.TypowyAdam.UndergroundTasks;

namespace Toci.Hornets.UnitTests.Sieradz.TypowyAdam.PeselValidatorTest
{
    [TestClass]
    public class TypowyAdamSampleTest
    {
                  

        [TestMethod]
        public void TestMethod1()
        {
            TypowyAdamPeselValidator peselValidator = new TypowyAdamPeselValidator();
             MethodInfo test = peselValidator.GetType().GetMethod("IsPeselValid");
            var test1 = peselValidator.GetType().GetMethod("IsPeselValid");
            
               var test2 = test1.GetParameters();
            var test3 = test1.ReturnType;
            //var type = Type.ReflectionOnlyGetType(test2[0].ParameterType.FullName,true,true);
            var type = test2[0].GetType();


        }

    }
}
