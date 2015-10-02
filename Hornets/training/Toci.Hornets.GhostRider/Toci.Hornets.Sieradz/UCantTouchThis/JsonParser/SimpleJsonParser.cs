using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Toci.Hornets.Sieradz.UCantTouchThis.ExtensionMethods;

namespace Toci.Hornets.Sieradz.UCantTouchThis.JsonParser
{
    public class SimpleJsonParser<TargetType>
    {
        protected List<string> PublicPropertiesNamesList;
        protected string Pattern = @"{0}""\s*:\s*"".*?(?=\"")";

        public virtual TargetType Parse(TargetType target, string jsonStringLine)
        {
            FillPublicPropertiesNamesList(target);
            PublicPropertiesNamesList.ForEach(propertyName => SetPropertyValue(jsonStringLine, propertyName, target));
            return target;
        }

        protected virtual void FillPublicPropertiesNamesList(TargetType target)
        {
            PublicPropertiesNamesList = target.GetType().GetProperties().Select(property => property.Name).ToList();
        }

        protected virtual void SetPropertyValue(string jsonStringLine, string propertyName, TargetType target)
        {
            target.SetPublicPropertyValue(propertyName, FindValue(jsonStringLine, propertyName));
        }

        protected virtual string FindValue(string jsonStringLine, string propertyName)
        {
            var match = Regex.Match(jsonStringLine, string.Format(@"{0}""\s*:\s*""(.*?)(?=\"")", propertyName));
            return (match.Success) ? match.Groups[1].ToString() : null;
        }
    }
}