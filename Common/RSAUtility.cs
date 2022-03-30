using System.Security.Cryptography;
using System.Text;

namespace rsa_decryptor.Common
{
    public static class RSAUtility
    {
        /// <summary>
        /// base64 public key -> encrypt content
        /// </summary>
        /// <param name="publicKey">must base64 string</param>
        /// <param name="content">encrypt content</param>
        /// <returns></returns>
        public static string Encrypt(string publicKey, string content)
        {
            Chilkat.SshKey puttyKey = new Chilkat.SshKey();
            if (puttyKey.FromOpenSshPublicKey(publicKey))
            {
                string xmlPublicKey = puttyKey.ToXml();

                string encryptedContent = string.Empty;
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(xmlPublicKey);
                    byte[] encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(content), false);
                    encryptedContent = Convert.ToBase64String(encryptedData);
                }
                return encryptedContent;
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// base64 private key -> decrypt content
        /// </summary>
        /// <param name="privateKey">must base64 string</param>
        /// <param name="content">decrypt content</param>
        /// <returns></returns>
        public static string Decrypt(string privateKey, string content)
        {
            Chilkat.SshKey puttyKey = new Chilkat.SshKey();
            if (puttyKey.FromOpenSshPrivateKey(privateKey))
            {
                string xmlPrivateKey = puttyKey.ToXml();
                string decryptedContent = string.Empty;
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.FromXmlString(xmlPrivateKey);
                    byte[] decryptedData = rsa.Decrypt(Convert.FromBase64String(content), false);
                    decryptedContent = Encoding.UTF8.GetString(decryptedData);
                }
                return decryptedContent;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}