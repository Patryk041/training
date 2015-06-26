using System.Collections.Generic;
using ConfigurationReader.Interfaces;

namespace ConfigurationReader
{
    public abstract class ConfigurationProvider<T> : IConfigurationProvider<T>
    {
        protected IConfigurationManager ConfigurationManager;

        protected Dictionary<string, T> Configuration;

        protected ConfigurationProvider(IConfigurationManager configurationManager)
        {
            ConfigurationManager = configurationManager;
        }

        public Dictionary<string, T> GetConfiguration()
        {
            RefreshConfiguration();

            return Configuration;
        }

        public T GetConfigurationEntry(string key)
        {
            RefreshConfiguration();

            return Configuration.ContainsKey(key) ? Configuration[key] : default(T);
        }

        private void RefreshConfiguration()
        {
            // logic for getting config from db for certain time intervals
            if (ConfigurationManager.ShouldRefresh())
            {
                Configuration = GetConfigurationFromStorage();
            }
        }

        protected abstract Dictionary<string, T> GetConfigurationFromStorage();
    }
}