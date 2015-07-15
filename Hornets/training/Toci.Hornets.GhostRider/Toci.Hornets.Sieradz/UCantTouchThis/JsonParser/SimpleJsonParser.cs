using System.Collections.Generic;
using System.Linq;

namespace Toci.Hornets.Sieradz.UCantTouchThis.JsonParser
{
    public class SimpleJsonParser<Type>
    {
        protected Type TargetType;
        protected List<string> PublicPropertiesNamesList;
        protected string Pattern = "";

        public SimpleJsonParser(Type type, string jsonString)
        {
            TargetType = type;
        }

        public virtual Type Parse()
        {
            InitialiseParser();
            return default(Type);
        }

        protected virtual void InitialiseParser()
        {
            PublicPropertiesNamesList = GetPublicPropertiesNamesList();
            //more to come
        }

        protected virtual List<string> GetPublicPropertiesNamesList()
        {
                return TargetType.GetType().GetProperties().Select(x => x.Name).ToList();
        }
    }
}