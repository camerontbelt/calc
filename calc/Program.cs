using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "9+5*\n7 \n#this is a comment\n";//args[0];
            var lexer = new CalcLexer(text);
            var tokens = lexer.Tokenize();
            tokens.ForEach(token => Console.WriteLine(token));

            var parser = new CalcParser(new CalcLexer(text));
            // var tree = parser.Parse();
            // Console.WriteLine("\nParse Tree");
            // Console.WriteLine(tree.ToStringTree());

            var interpreter = new CalcInterpreter();
            // Console.WriteLine("\nResult");
            // Console.WriteLine(interpreter.Interpret(tree));
        }
    }
}
