using System.ComponentModel;

namespace Anathema.stpetersburgstakeout
{
    public static class ExtensionMethods
    {
        public static void ExtendString(this string instnace)
        {
            //instnace.
        }

        public static void ExtendGeneric<T>(this T instance) where T : IEditableObject, IContainer
        {
            //8.
        }
    }
}