using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Toci.Hornets.UnitTests.Sieradz.TypowyAdam.Interfaces
{
    public interface ITypowyAdamMethodFactoryGenerator
    {
        void GetAssemblies(string assembliesPath, string assembliesCommonString);
        void LoadObjects(Type targetType);
        void GenerateMethodFactory(string methodName);
    }
}