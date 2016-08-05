using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionStrategy
{
    public class StringReverse : IEncryption
    {
        public string Encrypt(string input)
        {
            char[] encryptedText = new char[input.Length];

            for(int i = 0; i < encryptedText.Length; i++)
            {
                encryptedText[(input.Length -1) - i] = input[i];
            }

            return new string(encryptedText);
        }

        public string Decrypt(string input)
        {
            return Encrypt(input);
        }
    }
}
