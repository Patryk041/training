using System.Collections.Generic;
using System.Linq;
using System.Xml;
using Anathema.Patryk.TrainingTwo.Banks.Models;
using Anathema.Patryk.TrainingTwo.Banks.Parsers.Abstract;

namespace Anathema.Patryk.TrainingTwo.Banks.Parsers
{
    public abstract class XmlParser<TResult> : DocumentParser<TResult, XmlNodeList>
    {
        private XmlDocument _xmlDocument;
        private string TagName;

        protected XmlParser(string tagName)
        {
            TagName = tagName;
            _xmlDocument = new XmlDocument();
        }

        protected override List<XmlNodeList> GetEntries(string path)
        {
            _xmlDocument.Load(path);
            return _xmlDocument.GetElementsByTagName(TagName).Cast<XmlNode>().ToList().Select(item => item.ChildNodes).ToList();
        }

    }
}