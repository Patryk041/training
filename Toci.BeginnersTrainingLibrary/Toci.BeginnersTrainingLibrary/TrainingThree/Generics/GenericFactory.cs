using System;
using System.Collections.Generic;

namespace Toci.BeginnersTrainingLibrary.TrainingThree.Generics
{
    public class GenericFactory<TKey, TValue, TInstance> where TValue : AnotherExampleClass, IErley, new() //where TInstance : new()//Func<TInstance>
    {
        protected Dictionary<TKey, TValue> FactoryValues;

        public TValue CreateInstance(TKey key)
        {
            var test = new TValue();
            test.Whatever();

            test.IsPalindrom();

            return FactoryValues[key];
        }

        public TKey ReturnTInstnace()
        {
            //TInstance ins = new TInstance();
            //return (Func<TKey>)ins();
            return default(TKey);
        }
    }
}
