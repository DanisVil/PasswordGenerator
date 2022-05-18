﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class HashPass
    {
        public static string Hash256StringToString(string input)
        {
            var sha256 = SHA256.Create();
            byte[] byteStringAfter = sha256.ComputeHash(input.Select(x => ((byte)x)).ToArray());
            return string.Concat(byteStringAfter.Select(x => (char)x));
        }
        public static string Hash1StringToString(string input)
        {
            var sha1 = SHA1.Create();
            byte[] byteStringAfter = sha1.ComputeHash(input.Select(x => ((byte)x)).ToArray());
            return string.Concat(byteStringAfter.Select(x => (char)x));
        }
        public static string HashRememberSaltTeam(string hash, string salt)
        {
            if (hash.Length != 32)
            {
                throw new Exception("Тут должно быть 32 символа не больше, не меньше.");
            }
            StringBuilder sb = new StringBuilder(hash);
            salt = Hash1StringToString(salt);
            for (int i = 0; i < salt.Length; i++)
            {
                sb.Insert(salt[i] % 32, salt[i]);
            }
            return sb.ToString();
        }
        public static byte[] HashStringToByte(string input)
        {
            var sha256 = SHA256.Create();
            return sha256.ComputeHash(input.Select(x => ((byte)x)).ToArray());
        }
        
        public static bool CompareHashAndPass(string hash, string pass, string login)
        {
            return hash.Equals(HashRememberSaltTeam(Hash256StringToString(pass), login));
        }
        public static string PasswordToHashSalt(string password, string salt)
        {
            return HashRememberSaltTeam(Hash256StringToString(password), salt);
        }
    }
}
