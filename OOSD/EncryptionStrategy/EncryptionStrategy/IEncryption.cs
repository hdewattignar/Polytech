using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionStrategy
{
    public interface IEncryption
    {
        string Encrypt(string input);

        string Decrypt(string input);
    }
}
