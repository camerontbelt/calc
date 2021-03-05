using System;
using System.Collections.Generic;

namespace calc
{
    internal class Lexer
    {
        private char _currentChar;
        private string _text;
        private int _currentPosition = 0;
        private List<Token> _tokens {get;set;}

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

        public Token NextToken()
        {
            while(_currentChar != '\u001a')
            {
                switch(_currentChar)
                {
                    case ' ':
                    case '\t':
                    case '\n':
                    case '\r':
                        WhiteSpace();
                        continue;
                    case ',':
                        Devour();
                        return new Token(TokenTypes.COMMA, ",");
                    case '[':
                        Devour();
                        return new Token(TokenTypes.LBRACK,"[");
                    case ']':
                        Devour();
                        return new Token(TokenTypes.RBRACK, "]");
                    default:
                        if(Char.IsLetter(_currentChar)) return Name();
                        else throw new Exception($"invalid character {_currentChar}");
                }
            }
            return new Token(TokenTypes.EOF,"EOF");
        }

        private Token Name()
        {
            var value = string.Empty;
            do
            {
                value += _currentChar;
                Devour();
            }while(Char.IsLetter(_currentChar));
            var result = new Token(TokenTypes.NAME, value);
            return result;
        }

        private void WhiteSpace()
        {
            while(_currentChar == ' ' 
            || _currentChar == '\t'
            || _currentChar == '\n'
            || _currentChar == '\r'){
                Devour();
            }
        }

        private void Devour()
        {
            _currentPosition++;
            if(_currentPosition >= _text.Length) _currentChar = '\u001a';
            else _currentChar = _text[_currentPosition];
        }

        private void Match(char c)
        {
            if (_currentChar == c) Devour();
            else throw new Exception($"expecting {_currentChar}; but found {c}");
        }
    }
}