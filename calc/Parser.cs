using System;

public abstract class Parser
{
    private int _currentPosition = 0;
    private Token[] _tokens;
    private int _k;
    internal readonly ListLexer _lexer;

    public Parser(ListLexer lexer, int k)
    {
        _lexer = lexer;
        _k = k;
        _tokens = new Token[k];
        for(var i = 0;i<k;i++)
        {
            Devour();
        }
    }

    public void Match(TokenTypes tokenType)
    {
        if(LookAhead(1) == tokenType) Devour();
        else throw new Exception($"expecting {LookAhead(1)}; but found {tokenType}");
    }

    private void Devour()
    {
        _tokens[_currentPosition] = _lexer.NextToken();
        _currentPosition = (_currentPosition+1) % _k;
    }

    public TokenTypes LookAhead(int index)
    {
        return LookAheadToken(index).Type;
    }

    public Token LookAheadToken(int index)
    {
        return _tokens[(_currentPosition+index-1)%_k];
    }
}