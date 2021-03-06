using System;
using System.Collections.Generic;

public class ListParser : Parser 
{
    public ListParser(ListLexer lexer, int k) : base(lexer, k)
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
        while(LookAhead(1) == TokenTypes.COMMA)
        {
            Match(TokenTypes.COMMA);
            Element();
        }
    }

    // element : NAME '=' NAME | NAME | list;
    private void Element()
    {
        if (LookAhead(1) == TokenTypes.NAME && LookAhead(2) == TokenTypes.EQUALS)
        {
            Match(TokenTypes.NAME);
            Match(TokenTypes.EQUALS);
            Match(TokenTypes.NAME);
        }
        else if(LookAhead(1) == TokenTypes.NAME) Match(TokenTypes.NAME);
        else if (LookAhead(1) == TokenTypes.LBRACK) List();
        else throw new Exception($"expecting name or list; found {LookAhead(1).ToString()}");
    }
}