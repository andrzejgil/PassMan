using System;
using System.Collections.Generic;
using System.Text;

namespace PassMan.Utils.FileHandlers.Xml
{
    public interface IXmlHandler
    {
        string XmlInnerText { get; }
        string SaveFile();
    }
}
