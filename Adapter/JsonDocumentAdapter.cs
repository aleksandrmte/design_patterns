using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Newtonsoft.Json;

namespace Adapter
{
    public class JsonDocumentAdapter: IDocumentReader
    {
        private readonly XmlDocumentReader _xmlDocumentReader;

        public JsonDocumentAdapter(XmlDocumentReader xmlDocumentReader)
        {
            _xmlDocumentReader = xmlDocumentReader;
        }

        public string GetJsonString()
        {
            return JsonConvert.SerializeXmlNode(GetXmlDocument());
        }

        private XmlDocument GetXmlDocument()
        {
            var xmlContent = _xmlDocumentReader.GetXmlString();
            var doc = new XmlDocument();
            doc.LoadXml(xmlContent);
            return doc;
        }
    }
}
