using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class HashPass
    {
        public static byte[] Hash256String(string input)
        {
            SHA256 sha256 = SHA256.Create();
            return sha256.ComputeHash(input.Select(x => (byte)x).ToArray());
        }
        public static byte[] Hash1String(string input)
        {
            SHA1 sha1 = SHA1.Create();
            return sha1.ComputeHash(input.Select(x => (byte)x).ToArray());
        }
        public static byte[] HashAddSalt(byte[] hash, byte[] salt)
        {
            for (int i = 0; i < salt.Length; i++)
            {
                hash[i] = (byte)(((int)hash[i] + 13 * (int)salt[i]) % 255);
            }
            byte[] final = new byte[hash.Length];
            Array.Copy(hash, final, hash.Length);
            return final;
        }
        public static byte[] PasswordToHashSalt(string password, string salt)
        {
            return HashAddSalt(Hash256String(password), Hash1String(salt));
        }
    }
}
