using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(">>>");
            var text = Console.ReadLine();
            var lexer = new CalcLexer(text);
            var tokens = lexer.Tokenize();
            foreach(var token in tokens)
            {
                Console.WriteLine(token);
            }
        }
    }
}
