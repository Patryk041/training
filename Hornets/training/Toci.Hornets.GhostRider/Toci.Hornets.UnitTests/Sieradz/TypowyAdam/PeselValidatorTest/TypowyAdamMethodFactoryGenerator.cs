using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.UnitTests.Sieradz.TypowyAdam.Interfaces;

namespace Toci.Hornets.UnitTests.Sieradz.TypowyAdam
{   
    //Pracuję nad tym żeby ta klasa mi zwróciła słownik dowolnych publicznych metod znajdujących się
    //w wybranym przez nas assembly, które później będzie można wywołać

    public class TypowyAdamMethodFactoryGenerator : ITypowyAdamMethodFactoryGenerator
    {
        protected List<Assembly> AssembliesList = new List<Assembly>();
        protected Dictionary<string, List<object>> ObjectDictionary = new Dictionary<string, List<object>>(); 
        protected Dictionary<string, MethodInfo> MethodFactory = new Dictionary<string, MethodInfo>();

        //assembliesCommonString służyć będzie do filtrowania co za assembly załadować - Hornets dla wszystkich, Sieradz dla sieradza etc.
        public void GetAssemblies(string assembliesPath, string assembliesCommonString) 
        {

            List<string> dllList = new List<string>(Directory.GetFiles(@assembliesPath));
            dllList = dllList.Where(s => s.Contains(".dll")).Where(s => s.Contains(assembliesCommonString)).ToList();
            foreach (var dllPatch in dllList)
            {
                AssembliesList.Add(Assembly.LoadFrom(dllPatch));      
            }
        }

        public void LoadObjects(Type targetType)//czy wystarczy targetType żeby wyciągnąć wszystkie obiekty?
        {
            
            foreach (Assembly assembly in AssembliesList)
            {
                List<object> objectList = new List<object>();
                foreach (Type assemblyObject in assembly.GetTypes().Where(type => type.IsClass && type.IsSubclassOf(targetType)))
                {
                    objectList.Add(Activator.CreateInstance(assemblyObject));//Czy jest szansa że obędzie się tu bez rzutowania?
                }
                ObjectDictionary.Add(assembly.FullName, objectList);
            }
        }

        public void GenerateMethodFactory(string methodName)
        {
            foreach (var objectList in ObjectDictionary.Values)
            {
                foreach (var assemblyObject in objectList)
                {
                    MethodFactory.Add(assemblyObject.GetType().FullName, assemblyObject.GetType().GetMethod(methodName));//czy MethodInfo wystarczy do wywołania metody?
                }
            }
        }
    }
}