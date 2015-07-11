using System.Linq;

namespace Toci.Hornets.Sieradz.UCantTouchThis
{
    public static class GetProperyValueFromName
    {
        public static object GetPropertyValue(this object obj, string propertyName)
        {
            return obj.GetType().GetProperties().Single(propertyInfo => propertyInfo.Name == propertyName)
                    .GetValue(obj, null);
        }
    }
}