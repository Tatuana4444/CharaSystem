using System.Security.Cryptography;
using System.IO;


namespace Plug
{
    public class Crypto
    {
        private byte[] aeskey;
        private byte[] aesiv;
        public byte[] AesKey
        {
            get { return aeskey;}
            set { aeskey = value; }
        }
        public byte[] AesIV
        {
            get { return aesiv; }
            set { aesiv = value; }
        }
        public string Decrypt(byte[] cipherText)
        {
            string plaintext = null;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Padding = PaddingMode.None;
                aesAlg.Key = aeskey;
                aesAlg.IV = aesiv;
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }
            return plaintext;
        }
        public byte[] Encrypt(string plainText)
        {
            byte[] encrypted;
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = aeskey;
                aesAlg.IV = aesiv;
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }

                return encrypted;
            }


        }
    }
}
