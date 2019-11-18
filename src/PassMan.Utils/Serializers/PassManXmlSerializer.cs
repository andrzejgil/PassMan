using PassMan.Utils.Models.PassEntry;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;


namespace PassMan.Utils.Serializers
{
    public class PassManXmlSerializer
    {
        public static string Serialize(object obj)
        {
            using (var stringWriter = new StringWriter())
            {
                var serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(stringWriter, obj);
                return stringWriter.ToString();
            }
        }

        public static TObject Deserialize<TObject>(string xml)
        {
            using (var stringReader = new StringReader(xml))
            {
                var serializer = new XmlSerializer(typeof(TObject));
                return (TObject)serializer.Deserialize(stringReader);
            }
        }

    }
}
