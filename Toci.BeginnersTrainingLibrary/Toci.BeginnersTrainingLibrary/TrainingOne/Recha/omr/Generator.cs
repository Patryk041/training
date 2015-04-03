using System.Collections.Generic;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Recha.omr
{
    public abstract class Generator
    {
        protected string _atomicDefinitionOfTable;
        protected Parser _parser;
        protected List<string> _newClass;
        protected List<Properties> _properties;

        protected Generator(string atomicDefinitionOfTable)
        {
            _atomicDefinitionOfTable = atomicDefinitionOfTable;
            _newClass = new List<string>();
        }

        public virtual void GenerateClass(string namespaceName, string className)
        {
            //in override create instance of parser derivative class
            //then  var properties = _parser.GetProperties(_atomicDefinitionOfTable);

            _newClass.AddRange(GenerateBeginOfClass(namespaceName, className));
            foreach (var property in _properties)
            {
                _newClass.AddRange(GenerateProperty(property));
            }
            _newClass.AddRange(GenerateEndOfClass());
        }

        public void SaveClass(string fileName)
        {
            var fileStream = new Io();
            fileStream.Save(_newClass, fileName);
        }

        protected abstract List<string> GenerateBeginOfClass(string namespaceName, string className);

        protected abstract List<string> GenerateProperty(Properties property);

        protected abstract List<string> GenerateEndOfClass();
    }
}
