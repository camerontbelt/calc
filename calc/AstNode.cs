using System.Collections.Generic;

public class AstNode
{
    private List<AstNode> _children;
    public Token Token { get; }

    public AstNode(Token token)
    {
        Token = token;
        _children = new List<AstNode>();
    }

    public void AddChildNode(AstNode node)
    {
        _children.Add(node);
    }
}