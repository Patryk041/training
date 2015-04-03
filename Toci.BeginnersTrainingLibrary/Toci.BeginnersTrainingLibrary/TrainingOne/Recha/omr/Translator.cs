using System.Collections.Generic;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.omr
{
     public abstract class Translator
    {
        protected string _atomicDefinitionOfTable;
        protected List<string> _newClass;

        protected Translator(string atomicDefinitionOfTable)
        {
            _atomicDefinitionOfTable = atomicDefinitionOfTable;
            _newClass = new List<string>();
        }

        public void GenerateClass()
        {
            var properties = GetProperties(_atomicDefinitionOfTable);
            _newClass.AddRange(GenerateBeginOfClass());
            foreach (var property in properties)
            {
                _newClass.AddRange(GenerateProperty(property));
            }
            _newClass.AddRange(GenerateEndOfClass());
        }

        public abstract void SaveClass(string fileName);

        protected abstract List<Properties> GetProperties(string atomicDefinitionOfTable);

        protected abstract List<string> GenerateBeginOfClass();

        protected abstract List<string> GenerateProperty(Properties property);

        protected abstract List<string> GenerateEndOfClass();
    }
}
