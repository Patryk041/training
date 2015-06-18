using System.Collections.Generic;
using ConfigurationReader.Interfaces;

namespace ConfigurationReader.ConfigurationProviders
{
    public class XmlConfigurationProvider<T> : ConfigurationProvider<T>
    {
        public XmlConfigurationProvider(IConfigurationManager configurationManager) : base(configurationManager)
        {
        }

        protected override Dictionary<string, T> GetConfigurationFromStorage()
        {
            throw new System.NotImplementedException();
        }
    }
}