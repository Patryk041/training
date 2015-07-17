using System.Linq;
using System.Reflection;

namespace Toci.Hornets.Sieradz.UCantTouchThis.ExtensionMethods
{
    public static class UCTT_FieldsUtils
    {
        public static object GetProtectedFieldValue(this object obj, string fieldName)
        {
            var tmp = obj.GetType().GetFields( BindingFlags.Instance | BindingFlags.NonPublic);
            return tmp.Single(fieldInfo => fieldInfo.Name == fieldName).GetValue(obj);
        }
    }
}