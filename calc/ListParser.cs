using System;
using System.Collections.Generic;

public class ListParser : Parser 
{
    public ListParser(List<Token> tokens) : base(tokens)
    {
        
    }

    // list : '[' elements ']';
    public void List()
    {
        Match(TokenTypes.LBRACK);
        Elements();
        Match(TokenTypes.RBRACK);
    }

    // elements : element (',' element)*;
    private void Elements()
    {
        Element();
        while(_currentToken.Type == TokenTypes.COMMA)
        {
            Match(TokenTypes.COMMA);
            Element();
        }
    }

    // element : NAME | list;
    private void Element()
    {
        if(_currentToken.Type == TokenTypes.NAME) Match(TokenTypes.NAME);
        else if (_currentToken.Type == TokenTypes.LBRACK) List();
        else throw new Exception($"expecting name or list; found {_currentToken.ToString()}");
    }
}