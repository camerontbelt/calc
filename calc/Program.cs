using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "1+2*3/4-5";
            Console.WriteLine("Input\n"+text);
            var lexer = new CalcLexer(text);
            var tokens = lexer.Tokenize();
            Console.WriteLine("\nTokens");
            foreach(var token in tokens)
            {
                Console.WriteLine(token);
            }
            var parser = new CalcParser(new CalcLexer(text));
            var tree = parser.Parse();
            Console.WriteLine("\nParse Tree");
            Console.WriteLine(tree.ToStringTree());
            var interpreter = new CalcInterpreter();
            Console.WriteLine(interpreter.Interpret(tree));
        }
    }
}
