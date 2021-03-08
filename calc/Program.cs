using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
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
}
