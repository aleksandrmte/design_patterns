using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Adapter
{
    public class XmlDocumentReader
    {
        private string _xmlContent;
        private readonly string _filePath;

        public XmlDocumentReader(string filePath)
        {
            _filePath = filePath;
        }

        public string GetXmlString()
        {
            _xmlContent = File.ReadAllText(_filePath);
            return _xmlContent;
        }
    }
}
