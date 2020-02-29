using Encryptor;
using System;

namespace TastHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello World";
            string key = "MUMBOJumbo";
            string encryptedInput = input.EncryptAES(key);
            string decryptedInput = encryptedInput.DecryptAES(key);

            Console.WriteLine($"Original string: {input}");
            Console.WriteLine($"Encrypted string: {encryptedInput}");
            Console.WriteLine($"Decrypted string: {decryptedInput}");
        }
    }
}
