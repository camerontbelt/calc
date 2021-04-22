using System;
using calc;

public class CalcLexer : Lexer
{
    private int _lineNumber = 0;
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
                case '#':// comments
                    Comments();
                    continue;
                case '+':
                    Devour();
                    return new Token(TokenTypes.PLUS, "+",_lineNumber);
                case '-':
                    Devour();
                    return new Token(TokenTypes.MINUS, "-",_lineNumber);
                case '*':
                    Devour();
                    return new Token(TokenTypes.MULTIPLY, "*",_lineNumber);
                case '.':
                    Devour();
                    return new Token(TokenTypes.DOT, ".",_lineNumber);
                case '^':
                    Devour();
                    return new Token(TokenTypes.EXP, "^",_lineNumber);
                case '(':
                    Devour();
                    return new Token(TokenTypes.LPAREN, "(",_lineNumber);
                case ')':
                    Devour();
                    return new Token(TokenTypes.RPAREN, ")",_lineNumber);
                case '%':
                    Devour();
                    return new Token(TokenTypes.MOD, "%",_lineNumber);
                case '>':
                    Devour();
                    if (_currentChar == '=')
                    {
                        Devour();
                        return new Token(TokenTypes.GTOE,">=",_lineNumber);
                    }
                    return new Token(TokenTypes.GTHAN, ">",_lineNumber);
                case '<':
                    Devour();
                    if (_currentChar == '=')
                    {
                        Devour();
                        return new Token(TokenTypes.LTOE,"<=",_lineNumber);
                    }
                    return new Token(TokenTypes.LTHAN, "<",_lineNumber);
                case '=':
                    Devour();
                    Match('=');
                    return new Token(TokenTypes.EQUALS, "==",_lineNumber);
                case '&':
                    Devour();
                    return new Token(TokenTypes.AND, "&",_lineNumber);
                case '|':
                    Devour();
                    return new Token(TokenTypes.OR, "|",_lineNumber);
                case '!':
                    Devour();
                    return new Token(TokenTypes.NOT, "!",_lineNumber);
                case '\\':
                case '/':
                    Devour();
                    return new Token(TokenTypes.DIVIDE, "\\",_lineNumber);
                default:
                    if(char.IsDigit(_currentChar)) return Number();
                    else throw new Exception($"unexpected character '{_currentChar}'");
            }
        }
        return new Token(TokenTypes.EOF, "EOF",_lineNumber);
    }

    private void Comments()
    {
        Devour();
        while(_currentChar != '\n' || _currentChar != '\u001a'){
            Devour();
        }
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
        || _currentChar == '\r'){
            Devour();
        }
        if(_currentChar == '\n')
        {
            _lineNumber++;
            Devour();
        }
    }
}