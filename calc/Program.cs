using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                var text = Console.ReadLine();
                var lexer = new Lexer(text);
                var output = lexer.Tokenize();
            }
        }
    }
}
