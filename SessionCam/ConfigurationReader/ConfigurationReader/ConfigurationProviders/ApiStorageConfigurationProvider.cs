using System.Collections.Generic;
using ConfigurationReader.Interfaces;

namespace ConfigurationReader.ConfigurationProviders
{
    public class ApiConfigurationProvider<T> : ConfigurationProvider<T>
    {
        public ApiConfigurationProvider(IConfigurationManager configurationManager) : base(configurationManager)
        {
        }

        protected override Dictionary<string, T> GetConfigurationFromStorage()
        {
            throw new System.NotImplementedException();
        }
    }
}