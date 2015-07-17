using System.Linq;
using System.Reflection;

namespace Toci.Hornets.Sieradz.UCantTouchThis.ExtensionMethods
{
    public static class UCTT_PropertiesUtils
    {
        public static object GetPublicPropertyValue(this object obj, string propertyName)
        {
            return GetPropertyByName(obj, propertyName).GetValue(obj, null);
        }

        public static void SetPublicPropertyValue(this object obj, string propertyName, object value)
        {
            GetPropertyByName(obj, propertyName).SetValue(obj, value);
        }

        private static PropertyInfo GetPropertyByName(object obj, string propertyName)
        {
            return obj.GetType().GetProperties().Single(propertyInfo => propertyInfo.Name == propertyName);
        }
    }
}