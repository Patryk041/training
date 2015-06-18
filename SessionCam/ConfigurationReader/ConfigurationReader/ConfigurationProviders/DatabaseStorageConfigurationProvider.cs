using System.Collections.Generic;
using ConfigurationReader.Interfaces;

namespace ConfigurationReader.ConfigurationProviders
{
    public class DatabaseConfigurationProvider<T> : ConfigurationProvider<T>
    {
        public DatabaseConfigurationProvider(IConfigurationManager configurationManager) : base(configurationManager)
        {
        }

        protected override Dictionary<string, T> GetConfigurationFromStorage()
        {
            throw new System.NotImplementedException();
        }
    }
}