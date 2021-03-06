using System.Collections.Generic;

namespace calc
{
    public interface ILexer
    {
        List<Token> Tokenize();
        void Devour();
        void Match(char c);
    }
}