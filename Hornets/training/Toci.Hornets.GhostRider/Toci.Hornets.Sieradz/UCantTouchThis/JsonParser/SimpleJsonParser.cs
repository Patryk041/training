using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Toci.Hornets.Sieradz.UCantTouchThis.JsonParser
{
    public class SimpleJsonParser<TargetType>
    {
        protected List<string> PublicPropertiesNamesList;
        protected string Pattern = @"{0}""\s*:\s*"".*?(?=\"")";

        public virtual TargetType Parse(TargetType target, string jsonStringLine)
        {
            InitialiseParser(target);
            foreach (var propertyName in PublicPropertiesNamesList)
            {   //todo: check if success
                var tmp = Regex.Match(jsonStringLine, string.Format(@"{0}""\s*:\s*""(.*?)(?=\"")", "TransferTitle")).Groups[1];
                
            }
            return default(TargetType);
        }

        protected virtual void InitialiseParser(TargetType target)
        {
            PublicPropertiesNamesList = GetPublicPropertiesNamesList(target);
            //more to come
        }

        protected virtual List<string> GetPublicPropertiesNamesList(TargetType target)
        {
            return target.GetType().GetProperties().Select(property => property.Name).ToList();
        }
    }
}