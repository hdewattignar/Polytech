using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionStrategy
{
    public class ROT13 : IEncryption
    {
        public string Encrypt(string input)
        {
            char[] encryptedText = input.ToCharArray();

            for (int i = 0; i < encryptedText.Length; i++ )
            {
                int charValue = (int)encryptedText[i];

                if (charValue >= 'a' && charValue <= 'z')
                {
                    if (charValue > 'm')
                    {
                        charValue -= 13;
                    }
                    else
                    {
                        charValue += 13;
                    }
                }

                else if (charValue >= 'A' && charValue <= 'Z')
                {
                    if (charValue > 'M')
                    {
                        charValue -= 13;
                    }
                    else
                    {
                        charValue += 13;
                    }
                }

                encryptedText[i] = (char)charValue;
            }

            return new string(encryptedText);

        }

        public string Decrypt(string input)
        {
            char[] encryptedText = input.ToCharArray();

            for( int i = 0; i < encryptedText.Length; i++ )
            {
                int charValue = (int)encryptedText[i];

                if (charValue >= 'a' && charValue <= 'z')
                {
                    if (charValue < 'm')
                    {
                        charValue += 13;
                    }
                    else
                    {
                        charValue -= 13;
                    }
                }

                else if (charValue >= 'A' && charValue <= 'Z')
                {
                    if (charValue < 'M')
                    {
                        charValue += 13;
                    }
                    else
                    {
                        charValue -= 13;
                    }
                }

                encryptedText[i] = (char)charValue;
            }

            return new string(encryptedText);
        }
    }
}
