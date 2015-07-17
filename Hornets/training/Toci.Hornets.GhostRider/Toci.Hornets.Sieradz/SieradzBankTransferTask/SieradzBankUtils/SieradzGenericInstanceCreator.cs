using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Toci.Hornets.Sieradz.SieradzBankTransferTask.SieradzBankUtils
{
    public class SieradzGenericInstanceCreator<T>
    {
        public virtual List<T> CreateObjectList()
        {
            return CreateInstances(GetClassesList(Assembly.Load("Toci.Hornets.Sieradz")));
        }

        protected virtual List<Type> GetClassesList(Assembly assembly)
        {
            return assembly.GetTypes()
                .Where(type => type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof (T))).ToList();
        }

        protected virtual List<T> CreateInstances(List<Type> typeList)
        {
            return typeList.Select(Activator.CreateInstance).Cast<T>().ToList();
        }
    }
}