using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace OOP_lab12
{
    public static class DES
    {
        private static string key = "1$H4567l";
        private static string iv = "87654321";

        public static string DESDecrypt(byte[] encryptedValue)
        {
            using (DESCryptoServiceProvider sa = new DESCryptoServiceProvider { Key = Encoding.UTF8.GetBytes(key), IV = Encoding.UTF8.GetBytes(iv) })
            {
                using (ICryptoTransform ct = sa.CreateDecryptor())
                {
                    using (var ms = new MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, ct, CryptoStreamMode.Write))
                        {
                            cs.Write(encryptedValue, 0, encryptedValue.Length);
                            cs.FlushFinalBlock();
                        }
                        return Encoding.UTF8.GetString(ms.ToArray());
                    }
                }
            }
        }


        public static byte[] DESEncrypt(string originalValue)
        {
            using (DESCryptoServiceProvider sa = new DESCryptoServiceProvider { Key = Encoding.UTF8.GetBytes(key), IV = Encoding.UTF8.GetBytes(iv) })
            {
                using (ICryptoTransform ct = sa.CreateEncryptor())
                {
                    byte[] by = Encoding.UTF8.GetBytes(originalValue);
                    using (var ms = new MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, ct, CryptoStreamMode.Write))
                        {
                            cs.Write(by, 0, by.Length);
                            cs.FlushFinalBlock();
                        }
                        return ms.ToArray();
                    }
                }
            }
        }
    }
}
