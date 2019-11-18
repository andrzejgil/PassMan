using System;
using System.Collections.Generic;
using System.Text;

namespace PassMan.Utils.Security
{
    interface ISecurityAlghoritm
    {
        string Encrypt(string textToEncode);
        string Decrypt(string encodedText);
    }
}
