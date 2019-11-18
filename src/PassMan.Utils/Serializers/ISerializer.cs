using System;
using System.Collections.Generic;
using System.Text;

namespace PassMan.Utils.Serializers
{
    interface ISerializer
    {
        string Serialize(object obj);
        TObject Deserialize<TObject>(string xml);
    }
}
