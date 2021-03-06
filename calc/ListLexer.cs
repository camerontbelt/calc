using System;
using calc;
public class ListLexer : Lexer
{
    public ListLexer(string text) : base(text)
    {
    }

    public override Token NextToken()
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
                    Match(_currentChar);
                    return new Token(TokenTypes.COMMA, ",");
                case '[':
                    Match(_currentChar);
                    return new Token(TokenTypes.LBRACK,"[");
                case ']':
                    Match(_currentChar);
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
            Match(_currentChar);
        }while(Char.IsLetter(_currentChar));
        var result = new Token(TokenTypes.NAME, value);
        return result;
    }

    private void WhiteSpace()
    {
        if(_currentChar == ' ' 
        || _currentChar == '\t'
        || _currentChar == '\n'
        || _currentChar == '\r'){
            Devour();
        }
    }
}