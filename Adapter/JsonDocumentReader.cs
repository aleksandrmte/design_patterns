using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Adapter
{
    public class JsonDocumentReader: IDocumentReader
    {
        private string _jsonContent;
        private readonly string _filePath;

        public JsonDocumentReader(string filePath)
        {
            _filePath = filePath;
        }

        public string GetJsonString()
        {
            _jsonContent = File.ReadAllText(_filePath);
            return _jsonContent;
        }
    }
}
