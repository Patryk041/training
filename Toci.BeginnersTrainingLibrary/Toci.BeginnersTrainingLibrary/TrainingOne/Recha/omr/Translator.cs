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
            _newClass = new List<string>
            {
            "using System;",
            "using System.Collections.Generic;",
            "",
            "namespace GenerateClassFromAtomicDefinitionOfTable",
            "{",
            "   public class ClassOfTable",
            "   {",
            }; 
        }

        public void GenerateClass()
        {
            var properties = GetProperties(_atomicDefinitionOfTable);

            foreach (var property in properties)
            {
                GenerateProperty(property);
            }

            _newClass.Add("   }");
            _newClass.Add("}");
        }

        public void SaveClass()
        {
            IO.Save(_newClass);
        }

        private void GenerateProperty(Properties property)
        {
            _newClass.Add("     public " + property.Type + " " + property.Name);
            _newClass.Add("     {");
            GenerateGet(property.Name);
            GenerateSet(property.Name, property.CannotBeNull);
            _newClass.Add("     }");
            _newClass.Add("");
        }

        private void GenerateGet(string propertyName)
        {
            _newClass.Add("         get");
            _newClass.Add("         {");
            _newClass.Add("             return " + propertyName + ";");
            _newClass.Add("         }");
        }

        private void GenerateSet(string propertyName, bool propertyCannotBeNull)
        {
            _newClass.Add("         set");
            _newClass.Add("         {");
            IfCanBeNull(propertyCannotBeNull);
            _newClass.Add("             " + propertyName + " = value;");
            _newClass.Add("         }");
        }

        private void IfCanBeNull(bool propertyCannotBeNull)
        {
            if (!propertyCannotBeNull) return;
            _newClass.Add("             if (value == null)");
            _newClass.Add("             {");
            _newClass.Add("                 throw new ArgumentNullException(\"value\");");
            _newClass.Add("             }");
        }

        protected abstract List<Properties> GetProperties(string atomicDefinitionOfTable);
    }
}
