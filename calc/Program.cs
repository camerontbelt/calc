using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "[a, b]";
            var lexer = new ListLexer(text);
            var tokens = lexer.Tokenize();
            Console.WriteLine(text);
            foreach(var token in tokens)
            {
                Console.WriteLine(token.ToString());
            }
            var parser = new ListParser(tokens);
            parser.List();
        }
    }
}
