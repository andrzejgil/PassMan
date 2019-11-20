using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace PassMan.Utils.FileHandlers.Xml
{
    public class XmlHandler : IXmlHandler
    {
        private readonly string _filePath;
        private XmlDocument _xDocument;

        public string XmlInnerText 
        { 
            get 
            { 
                return _xDocument.InnerXml; 
            } 
        }

        public XmlHandler(string filePath)
        {
            _filePath = filePath;
            _xDocument.Load(_filePath);
        }

        public string SaveFile()
        {
            throw new NotImplementedException();
        }
    }
}
