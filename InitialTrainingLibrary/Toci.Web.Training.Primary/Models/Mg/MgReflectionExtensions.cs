using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Toci.Web.Training.Primary.Models.Mg
{
    public static class MgReflectionExtensions
    {
       public static string GetPropertyName(this string stringText)
        {
            const char propertySignOne = '<';
            const char propertySignTwo = '>';

            if (!(stringText.Contains(propertySignOne) || stringText.Contains(propertySignTwo))) return stringText.ToUpper();
           

            var start = stringText.IndexOf(propertySignOne) + 1;
            var stringLength = stringText.IndexOf(propertySignTwo) - start;

           return stringText.Substring(start, stringLength).ToUpper();


        }
    }
}