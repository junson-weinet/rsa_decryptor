//execute sample
//rsa_decryptor r C:\Users\admin\id_rsa ba8QutmxuSEyx4g+nDDybIqtUWzXwaGgeuAQ4NWuLCk9V5GlQCF64EhPwbKEcCo+8h3ZJN2Ke74fRpx79fYMajJ2adZzm016EJU0tLPX5A3/ITIOH/PDxHulI9mVCzWwv7pNOb2K86CdHZOnYrIfqbQyw8EIQBJ9sCyA54SVDpbpjlEJPNLA3WKOVgg5WGDvCPAOlIIEyH1bBm0FieKH07TuvlCoAnESpQDun7QHmE5ksaIDed+x9NXkG4QMfOhRasJNTHDpOHdCIgYWRxBWqVQ0ttLHdmQZGBzU6TwQ7OJbqmA6bZeE8P6KkaOFqpjuzEwceMJm/Ja/cibK2UNoqw==
using rsa_decryptor.Common;

if (args[0] == "r")
{
    string privateKey = File.ReadAllText(args[1]);
    Console.WriteLine(RSAUtility.Decrypt(privateKey, args[2]));
}