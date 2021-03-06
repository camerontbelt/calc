using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "[a, b=c,[d,e]]";
            Console.WriteLine(text);
            var lexer = new ListLexer(text);
            // var tokens = lexer.Tokenize();
            // foreach(var token in tokens){
            //     Console.WriteLine(token);
            // }
            var parser = new ListParser(lexer, 3);
            parser.List();
        }
    }
}
