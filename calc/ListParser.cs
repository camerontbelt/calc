using System;
using System.Collections.Generic;

public class ListParser : Parser 
{
    public ListParser(ListLexer lexer, int k) : base(lexer, k)
    {
        
    }

    public AstNode Parse()
    {
        var root = List();
        return root;
    }

    // list : '[' elements ']';
    public AstNode List()
    {
        var node = new AstNode();
        Match(TokenTypes.LBRACK);
        var children = Elements();
        Match(TokenTypes.RBRACK);
        foreach(var child in children)
        {
            node.AddChildNode(child);
        }
        return node;
    }

    // elements : element (',' element)*;
    private List<AstNode> Elements()
    {
        var result = new List<AstNode>();
        result.Add(Element());
        while(LookAhead(1) == TokenTypes.COMMA)
        {
            Match(TokenTypes.COMMA);
            result.Add(Element());
        }
        return result;
    }

    // element : NAME '=' NAME | NAME | list;
    private AstNode Element()
    {
        if (LookAhead(1) == TokenTypes.NAME && LookAhead(2) == TokenTypes.EQUALS)
        {
            var left = LookAheadToken(1);
            Match(TokenTypes.NAME);
            var op = LookAheadToken(1);
            Match(TokenTypes.EQUALS);
            var right = LookAheadToken(1);
            Match(TokenTypes.NAME);
            var node = new AstNode(op);
            node.AddChildNode(new AstNode(left));
            node.AddChildNode(new AstNode(right));
            return node;
        }
        else if(LookAhead(1) == TokenTypes.NAME){
            var result = new AstNode(LookAheadToken(1));
            Match(TokenTypes.NAME);
            return result;
        } 
        else if (LookAhead(1) == TokenTypes.LBRACK) return List();
        else throw new Exception($"expecting name or list; found {LookAhead(1).ToString()}");
    }
}