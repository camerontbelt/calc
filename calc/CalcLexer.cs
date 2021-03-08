using System;
using calc;

public class CalcLexer : Lexer
{

    public CalcLexer(string input) : base(input)
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
                case '+':
                    Devour();
                    return new Token(TokenTypes.PLUS, "+");
                case '-':
                    Devour();
                    return new Token(TokenTypes.MINUS, "-");
                case '*':
                    Devour();
                    return new Token(TokenTypes.MULTIPLY, "*");
                case '.':
                    Devour();
                    return new Token(TokenTypes.DOT, ".");
                case '\\':
                case '/':
                    Devour();
                    return new Token(TokenTypes.DIVIDE, "\\");
                default:
                    if(char.IsDigit(_currentChar)) return Number();
                    else throw new Exception($"unexpected character '{_currentChar}'");
            }
        }
        return new Token(TokenTypes.EOF, "EOF");
    }

    private Token Number()
    {
        var digitString = _currentChar.ToString();
        Devour();  
        while(char.IsDigit(_currentChar))
        {
            digitString += _currentChar.ToString();
            Devour();
        }
        if(_currentChar == '.')
        {
            digitString += ".";
            Devour();
            while(char.IsDigit(_currentChar))
            {
                digitString += _currentChar.ToString();
                Devour();
            }
            return new Token(TokenTypes.FLOAT, digitString);
        }       
        return new Token(TokenTypes.INTEGER, digitString);
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