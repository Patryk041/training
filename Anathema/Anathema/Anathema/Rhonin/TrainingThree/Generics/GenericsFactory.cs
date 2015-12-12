using System.Collections.Generic;

namespace Anathema.Rhonin.TrainingThree
{
    public class GenericsFactory<TKey,TValue,TInstance> where TValue : OtherClass,ISome,new() where TInstance : new()
    {
        Dictionary<TKey, TValue> GenericFactory;

        public TValue CreateValue(TKey key)
        {
            var test = new TValue();
            test.SomeMethod();
            test.OtherMethod();
            return new TValue();
        }

        public TKey GetInstance()
        {
            return default(TKey);
        }
    }

}