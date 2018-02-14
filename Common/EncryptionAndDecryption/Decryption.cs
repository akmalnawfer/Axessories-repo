﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Common.EncryptionAndDecryption
{
    public class Decryption
    {
        private static readonly string EncryptionKey = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static string Decrypt(string ToDecrypt)
        {
            ToDecrypt = ToDecrypt.Replace(" ", "+");
            int mod4 = ToDecrypt.Length % 4;
            if (mod4 > 0)
            {
                ToDecrypt += new string('=', 4 - mod4);
            }
            byte[] cipherBytes = Convert.FromBase64String(ToDecrypt);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);
                        cryptoStream.Close();
                    }
                    ToDecrypt = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return ToDecrypt;
        }
    }
}