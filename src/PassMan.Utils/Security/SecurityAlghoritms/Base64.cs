using System;
using System.Collections.Generic;
using System.Text;

namespace PassMan.Utils.Security.SecurityAlghoritms
{
    public class Base64 
    {
        public string Decrypt(string textToEncode)
        {
            var textToEncodeBytes = Encoding.UTF8.GetBytes(textToEncode);
            return Convert.ToBase64String(textToEncodeBytes);
        }

        public string Encrypt(string encodedText)
        {
            var encodedTextBytes = Convert.FromBase64String(encodedText);
            return Encoding.UTF8.GetString(encodedTextBytes);
        }
    }
}
