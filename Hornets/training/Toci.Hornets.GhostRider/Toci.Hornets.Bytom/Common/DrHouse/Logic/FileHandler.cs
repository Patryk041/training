using System;
using Toci.Hornets.Bytom.Common.DrHouse.Types;

namespace Toci.Hornets.Bytom.Common.DrHouse.Logic
{
    public abstract  class FileHandler
    {
        public abstract string ReadFromFile(string filepath);
        public abstract Object GetObjectFromXml(string content);
        public abstract Object GetObjectFromJson(string content);
        public abstract Patient GetPatientFromObject(Object obj);
    }
}