using System;
using System.Collections.Generic;

namespace Adapter
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var documentReaders = new List<IDocumentReader>
            {
                new JsonDocumentReader("Files/file.json"),
                new JsonDocumentAdapter(new XmlDocumentReader("Files/file.xml"))
            };

            foreach (var reader in documentReaders)
            {
                Console.WriteLine(reader.GetJsonString());
            }

            

            Console.ReadKey();
        }
    }
}
