using System;
using System.Collections.Generic;

namespace calc
{
    public abstract class Lexer
    {
        internal char _currentChar;
        internal string _text;
        internal int _currentPosition = 0;
        internal List<Token> _tokens {get;set;}

        public Lexer(string text)
        {
            _text = text;
            _currentChar = text[_currentPosition];
        }

        public List<Token> Tokenize()
        {
            _tokens = new List<Token>();
            var token = NextToken();
            _tokens.Add(token);
            while(token.Type != TokenTypes.EOF)
            {
                token = NextToken();
                _tokens.Add(token);
            };
            return _tokens;
        }

        internal void Devour()
        {
            _currentPosition++;
            if(_currentPosition >= _text.Length) _currentChar = '\u001a';
            else _currentChar = _text[_currentPosition];
        }

        internal void Match(char c)
        {
            if (_currentChar == c) Devour();
            else throw new Exception($"expecting {_currentChar}; but found {c}");
        }

        public abstract Token NextToken();
    }
}