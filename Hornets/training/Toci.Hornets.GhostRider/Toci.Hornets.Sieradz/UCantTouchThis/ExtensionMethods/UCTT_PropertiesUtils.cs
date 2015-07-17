using System.Linq;

namespace Toci.Hornets.Sieradz.UCantTouchThis.ExtensionMethods
{
    public static class UCTT_PropertiesUtils
    {
        public static object GetPropertyValue(this object obj, string propertyName)
        {
            return obj.GetType().GetProperties().Single(propertyInfo => propertyInfo.Name == propertyName)
                    .GetValue(obj, null);
        }

        public static void SetPropertyValue(this object obj, string propertyName, object value)
        {
            obj.GetType().GetProperties().Single(propertyInfo => propertyInfo.Name == propertyName)
                .SetValue(obj, value);
        }
    }
}