using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public interface IDocumentReader
    {
        public string GetJsonString();
    }
}
