using System;

namespace ceasarCipher
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            {
                char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                Console.WriteLine("please enter your secret message: ");
                string message = Console.ReadLine();
                message = message.ToLower();
                char[] secretMessage = message.ToCharArray();
                char[] encryptedMessage = new char[secretMessage.Length];
                //Encrypting Process
                for (int i = 0; i < secretMessage.Length; i++)
                {

                    char letter = secretMessage[i];
                    int position = Array.IndexOf(alphabet, letter);
                    // modulo (%) returns remainder.
                    // if first number is smaller % operator always gives first smaller number.

                    int newPosition = (position + 3) % alphabet.Length;
                    encryptedMessage[i] = alphabet[newPosition];
                }
                //if we print inside for loop it will print all the messages from index 0 to last.
                //to print array either we need Foreach or Join.
                Console.WriteLine("your encrypted message is: " + String.Join("", encryptedMessage));

            }
        }
    }
}
 