using System.Collections.Generic;
using System.Text;

namespace Startup.TrainingOneHomeworks.redeye.IdentyficationOfBank.Interfaces
{
    public interface IMakeDictionaryFromFile
    {
        Dictionary<string, string> MakeDictionary(string path, Encoding en);
    }
}