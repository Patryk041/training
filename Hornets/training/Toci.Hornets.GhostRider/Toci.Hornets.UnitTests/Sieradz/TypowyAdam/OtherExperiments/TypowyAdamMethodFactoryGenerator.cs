using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Toci.Hornets.UnitTests.Sieradz.TypowyAdam;

namespace Toci.Hornets.UnitTests.Sieradz.TypowyAdam
{   
    public class TypowyAdamMethodFactoryGenerator 
    {
        protected List<Assembly> AssembliesList = new List<Assembly>();
        protected Dictionary<string, List<object>> ObjectDictionary = new Dictionary<string, List<object>>(); 
        //protected Dictionary<string, MethodInfo> MethodFactory = new Dictionary<string, MethodInfo>();
        protected Dictionary<string, MethodInfo> MethodDictionary = new Dictionary<string, MethodInfo>();
        protected Type targetType;

        TypowyAdamMethodFactoryGenerator()
        {
            
        }

        
        public void GetAssemblies(string assembliesPath, string assembliesCommonString) 
        {

            List<string> dllList = new List<string>(Directory.GetFiles(@assembliesPath));
            dllList = dllList.Where(s => s.Contains(".dll")).Where(s => s.Contains(assembliesCommonString)).ToList();
            foreach (var dllPatch in dllList)
            {
                AssembliesList.Add(Assembly.LoadFrom(dllPatch));      
            }
        }

        public void LoadObjects(Type targetType)
        {
            this.targetType = targetType;
            foreach (Assembly assembly in AssembliesList)
            {
                List<object> objectList = new List<object>();
                foreach (Type assemblyObject in assembly.GetTypes().Where(type => type.IsClass && type.IsSubclassOf(targetType)))
                {
                    objectList.Add(Activator.CreateInstance(assemblyObject));
                }
                ObjectDictionary.Add(assembly.FullName, objectList);
            }
        }
        /*Left this for a while
        public Dictionary<string, MethodInfo> GatherMethodInfo(string[] methodNames)
        {
            foreach (var methodName in methodNames)
            {
                MethodDictionary.Add(methodName, targetType.GetMethod(methodName));
            }
            return MethodDictionary;
        }
        
        public void GenerateMethodFactory(string methodName)
        {
            foreach (var objectList in ObjectDictionary.Values)
            {
                foreach (var assemblyObject in objectList)
                {
                    MethodFactory.Add(assemblyObject.GetType().FullName, assemblyObject.GetType().GetMethod(methodName));
                }
            }
        }

        public void TestStuff(string methodName)
        {
            var test =  ObjectDictionary["a"].GetType().GetMethod(methodName);
            var test2 = test.GetParameters();
            var test3 = test.ReturnParameter;

            var type = Type.GetType(test2[0].ParameterType.FullName);

        }*/
    }
}