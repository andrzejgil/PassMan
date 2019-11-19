using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace PassMan.Utils.Security
{
    class SecurityAlghoritm : ISecurityAlghoritm
    {
        public string Encrypt(string key, string textToEncrypt)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();

            rijndaelManaged.Mode = CipherMode.CBC;
            rijndaelManaged.Padding = PaddingMode.PKCS7;
            rijndaelManaged.KeySize = 0x80;
            rijndaelManaged.BlockSize = 0x80;

            byte[] passBytes = Encoding.UTF8.GetBytes(key);
            byte[] encryptKeyBytes = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            int passBytesLength = passBytes.Length;

            if (passBytesLength > encryptKeyBytes.Length)
            {
                passBytesLength = encryptKeyBytes.Length;
            }

            Array.Copy(passBytes, encryptKeyBytes, passBytesLength);
            rijndaelManaged.Key = encryptKeyBytes;
            rijndaelManaged.IV = encryptKeyBytes;
            ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
            byte[] textDataByte = Encoding.UTF8.GetBytes(textToEncrypt);

            return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(textDataByte, 0, textDataByte.Length));
        }

        public string Decrypt(string key, string textToDecrypt)
        {
            RijndaelManaged rijndaelManaged = new RijndaelManaged();

            rijndaelManaged.Mode = CipherMode.CBC;
            rijndaelManaged.Padding = PaddingMode.PKCS7;
            rijndaelManaged.KeySize = 0x80;
            rijndaelManaged.BlockSize = 0x80;

            byte[] encryptedTextByte = Convert.FromBase64String(textToDecrypt);
            byte[] passBytes = Encoding.UTF8.GetBytes(key);
            byte[] encryptKeyBytes = new byte[0x10];
            int passBytesLength = passBytes.Length;

            if (passBytesLength > encryptKeyBytes.Length)
            {
                passBytesLength = encryptKeyBytes.Length;
            }

            Array.Copy(passBytes, encryptKeyBytes, passBytesLength);
            rijndaelManaged.Key = encryptKeyBytes;
            rijndaelManaged.IV = encryptKeyBytes;
            byte[] textBytes = rijndaelManaged.CreateDecryptor().TransformFinalBlock(encryptedTextByte, 0, encryptedTextByte.Length);

            return Encoding.UTF8.GetString(textBytes);
        }
    }
}
