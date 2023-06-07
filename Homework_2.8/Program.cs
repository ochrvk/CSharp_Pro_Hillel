//Симетричне шифрування.
//Є строка на вхід, який має бути зашифрований.
//Ключ можна задати в коді або згенерувати та зберегти.
//Два методи, шифрування та дешифрування.

using System.Security.Cryptography;
using System.Text;

Console.Write("Enter the line for encryption: ");
string originalString = Console.ReadLine();

string key = GenerateKey();

string encryptedString = Encrypt(originalString, key);
Console.WriteLine("Encrypted line: " + encryptedString);

string decryptedString = Decrypt(encryptedString, key);
Console.WriteLine("Decrypted line: " + decryptedString);

static string GenerateKey()
{
    Aes aes = Aes.Create();
    aes.GenerateKey();
    string key = Convert.ToBase64String(aes.Key);
    aes.Dispose();
    return key;
}

static string Encrypt(string plainText, string key)
{
    byte[] encryptedBytes;
    byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

    Aes aes = Aes.Create();
    aes.Key = Convert.FromBase64String(key);
    aes.Mode = CipherMode.ECB;

    MemoryStream memoryStream = new MemoryStream();
    CryptoStream cryptoStream = null;
    try
    {
        cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
        cryptoStream.Write(plainBytes, 0, plainBytes.Length);
        cryptoStream.FlushFinalBlock();
        encryptedBytes = memoryStream.ToArray();
    }
    finally
    {
        if (cryptoStream != null)
            cryptoStream.Close();
        memoryStream.Close();
        aes.Dispose();
    }

    return Convert.ToBase64String(encryptedBytes);
}

static string Decrypt(string encryptedText, string key)
{
    byte[] decryptedBytes;
    byte[] encryptedBytes = Convert.FromBase64String(encryptedText);

    Aes aes = Aes.Create();
    aes.Key = Convert.FromBase64String(key);
    aes.Mode = CipherMode.ECB;

    MemoryStream memoryStream = new MemoryStream(encryptedBytes);
    CryptoStream cryptoStream = null;
    try
    {
        cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
        decryptedBytes = new byte[encryptedBytes.Length];
        cryptoStream.Read(decryptedBytes, 0, decryptedBytes.Length);
    }
    finally
    {
        if (cryptoStream != null)
            cryptoStream.Close();
        memoryStream.Close();
        aes.Dispose();
    }

    return Encoding.UTF8.GetString(decryptedBytes);
}
