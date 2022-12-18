namespace DependencyInjection
{
        public class Program
        {
            public static void Main(string[] args)
            {
                //CaesarCipher cipher = new CaesarCipher(6);
                var cipher = new VigenereCipher("supergeheim");

                User max = new User(cipher, "max", "geheim");
                System.Console.WriteLine($"Encrypted Password of max is '{max.PasswordEncrypted}' (decrypted: '{cipher.Decrypt(max.PasswordEncrypted)}')");
            }
        }
}
