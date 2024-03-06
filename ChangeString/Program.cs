using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere uma frase: ");
            string user_setence = Console.ReadLine();
            Console.Write("Que caracter quer substituir?: ");
            string user_char = Console.ReadLine();
            string replaceChar = "X";
            string modified = user_setence.Replace(user_char, replaceChar);
            Console.WriteLine(modified);

        }
    }
}
