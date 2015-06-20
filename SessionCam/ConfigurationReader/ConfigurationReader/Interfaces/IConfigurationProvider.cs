using System.Collections.Generic;

namespace ConfigurationReader.Interfaces
{
    public interface IConfigurationProvider<T>
    {
        Dictionary<string, T> GetConfiguration();

        T GetConfigurationEntry(string key);
    }
}