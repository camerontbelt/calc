using System;
using System.Collections.Generic;

public abstract class Parser
{
    private readonly List<Token> _tokens;
    private int _currentPosition = 0;
    internal Token _currentToken;
    public Parser(List<Token> tokens)
    {
        _tokens = tokens;
        _currentToken = _tokens[_currentPosition];
    }

    public void Match(TokenTypes tokenType)
    {
        if(_currentToken.Type == tokenType) Devour();
        else throw new Exception($"expecting {_currentToken.Type}; but found {tokenType}");
    }

    private void Devour()
    {
        _currentPosition++;
        _currentToken = _tokens[_currentPosition];
    }
}