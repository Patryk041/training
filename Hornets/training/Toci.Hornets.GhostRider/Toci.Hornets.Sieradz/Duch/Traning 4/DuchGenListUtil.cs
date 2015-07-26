using System.Collections;
using System.Linq;

namespace Toci.Hornets.Sieradz.Duch.Traning 
{
    public static class DuchGenListUtil<T>
    {
        public static T[] ListMagic(T[] ista,ListEnum operation, T item )
        {

            var lista = ista.ToList();

            if (operation == ListEnum.Add )lista.Add(item);
            if (operation == ListEnum.Remove) lista.Remove(item);

            return lista.ToArray();

        }

    }
}