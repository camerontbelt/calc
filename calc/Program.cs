using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "[a, b,[c,d]]";
            Console.WriteLine(text);
            var lexer = new ListLexer(text);
            var parser = new ListParser(lexer);
            parser.List();
        }
    }
}
