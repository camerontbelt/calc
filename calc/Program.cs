using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "3+4";
            var lexer = new CalcLexer(text);
            var tokens = lexer.Tokenize();
            foreach(var token in tokens)
            {
                Console.WriteLine(token);
            }
        }
    }
}
