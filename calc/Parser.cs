using System;
using System.Collections.Generic;
using calc;

public abstract class Parser
{
    private int _currentPosition = 0;
    internal Token _currentToken;
    private readonly ListLexer _lexer;

    public Parser(ListLexer lexer)
    {
        _currentToken = lexer.NextToken();
        _lexer = lexer;
    }

    public void Match(TokenTypes tokenType)
    {
        if(_currentToken.Type == tokenType) Devour();
        else throw new Exception($"expecting {_currentToken.Type}; but found {tokenType}");
    }

    private void Devour()
    {
        _currentPosition++;
        _currentToken = _lexer.NextToken();
    }
}