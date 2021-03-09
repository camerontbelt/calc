using System;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            // var text = "[a,b]";
            // var lexer = new ListLexer(text);
            // var parser = new ListParser(lexer);
            var text = "[a,b]";
            var lexer = new ListLexer(text);
            var parser = new ListParser(lexer);
            var root = parser.Parse();
            //Act
            var rootString = root.ToStringTree();
        }
    }
}
