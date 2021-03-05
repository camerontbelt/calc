using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "[a, b ]";
            var lexer = new Lexer(text);
            var output = lexer.Tokenize();
            Console.WriteLine(text);
            foreach(var token in output)
            {
                Console.WriteLine(token.ToString());
            }
        }
    }
}
