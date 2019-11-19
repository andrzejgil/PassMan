using System;
using System.Collections.Generic;
using System.Text;

namespace PassMan.Utils.Security
{
    interface ISecurityAlghoritm
    {
        string Encrypt(string key, string textToEncode);
        string Decrypt(string key, string encodedText);
    }
}
