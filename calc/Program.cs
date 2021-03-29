using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            // while(true)
            // {
            //     Console.Write(">> ");
            //     var text = Console.ReadLine();
            //     if(text == "q") break;
                //Console.WriteLine("Input\n"+text);
                var text = "(9-2)+45";
                var lexer = new CalcLexer(text);
                var tokens = lexer.Tokenize();
                // Console.WriteLine("\nTokens");
                // foreach(var token in tokens)
                // {
                //     Console.WriteLine(token);
                // }

                var parser = new CalcParser(new CalcLexer(text));
                var tree = parser.Parse();
                Console.WriteLine("\nParse Tree");
                Console.WriteLine(tree.ToStringTree());

                var interpreter = new CalcInterpreter();
                Console.WriteLine("\nResult");
                Console.WriteLine(interpreter.Interpret(tree));
            //}
        }
    }
}
