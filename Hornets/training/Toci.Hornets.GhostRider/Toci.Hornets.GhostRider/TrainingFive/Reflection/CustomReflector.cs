using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Toci.Hornets.GhostRider.GhostRider;

namespace Toci.Hornets.GhostRider.TrainingFive.Reflection
{
    public class CustomReflector
    {
        public T CreateMyType<T>(string assemblyName, string typeName) where T : class
        {
            return Activator.CreateInstance(assemblyName, typeName) as T;
        }

        public object CreateMyType(string typeName) 
        {
            //Activator.CreateInstance(assemblyName, typeName);
            return Activator.CreateInstance(Type.GetType(typeName));

            //return objHandle.InitializeLifetimeService();
        }

        public object CreateMyType(string assemblyPath, string typeName)
        {
            var res = Assembly.LoadFile(assemblyPath);
            //Activator.CreateInstance(assemblyName, typeName);
            //return Activator.CreateInstance(Type.GetType(typeName));

            var types = res.GetTypes().Where(item => item.Name == typeName).ToArray();
            
            var test = types[0];

            //return CreateMyType<test.GetType()>

            return Activator.CreateInstance(test);

            //return objHandle.InitializeLifetimeService();
        }

        public void RunReflection()
        {

            var jajca = CreateMyType(@"D:\self\trainings\Dropbox\szkolenie\v 2.0\code\Hornets\training\Toci.Hornets.GhostRider\Toci.Hornets.GhostRider.Base\bin\Debug\Toci.Hornets.GhostRider.Base.dll", "AbsolutelySpecificType");
           // jajca.
            var AbsolutelySpecificTypeMethods = jajca.GetType().GetMethods(BindingFlags.Instance | BindingFlags.Public);

            AbsolutelySpecificTypeMethods[0].Invoke(jajca, null);

            ReflectionExample example = new ReflectionExample();
            //100 100000
            // 100000
            //    100

            // 100100
            var methods = example.GetType().GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

            MethodInfo info = methods[0];

            var methodParameteres = info.GetParameters();

            List<object> naszeParametry = new List<object>();

            foreach (var methodParameter in methodParameteres)
            {
                var paramType = methodParameter.ParameterType;
                var param = CreateMyType(paramType.FullName);

                naszeParametry.Add(param);
            }


            //MyExampleOfHomework
            FieldInfo f = example.GetType().GetField("InvisibleAndNonDerivable", BindingFlags.Instance | BindingFlags.NonPublic); // InvisibleAndNonDerivable

            f.SetValue(example, 4);

            info.Invoke(example, naszeParametry.ToArray()); // 1


            // var fields = info.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            //var i = 9;
            //info.
        }
    }
}