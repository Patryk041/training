using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Toci.Hornets.UnitTests.GhostRider.Abstraction
{
    public class TestBase
    {
        protected List<string> AssembliesNamespaces = new List<string>
        {
            "Toci.Hornets.Bytom",
            "Toci.Hornets.Gliwice",
            "Toci.Hornets.Kalisz",
            "Toci.Hornets.Legnica",
            "Toci.Hornets.Opole",
            "Toci.Hornets.Rzeszow",
            "Toci.Hornets.Sieradz",
            "Toci.Hornets.Wroclaw"
        };

        protected IEnumerable<T> GetDerivingTypes<T>()
        {
            List<T> objects = new List<T>();

            var myAssemblies = AssembliesNamespaces.Select(item => AppDomain.CurrentDomain.Load(item)).ToList();

            //GetAssembly(typeof(TelephoneInterpreter))
            foreach (var item in myAssemblies)
            { 
                foreach (Type type in item.GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
                {
                    objects.Add((T)Activator.CreateInstance(type));
                }
            }

            Debug.WriteLine("{0} homeworks found ! :)", objects.Count);

            return objects;
        } 
    }
}