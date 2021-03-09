using System.Collections.Generic;
using System.Text;

public class AstNode
{
    // Pattern 9 - homogenous AST node
    private List<AstNode> _children = new List<AstNode>();
    public Token Token { get; }

    public AstNode(Token token)
    {
        Token = token;
    }

    public AstNode(TokenTypes tokenType)
    {
        Token = new Token(tokenType, string.Empty);
    }

    public AstNode()
    {
        // Used for creating null token nodes
    }

    public void AddChildNode(AstNode node)
    {
        _children.Add(node);
    }

    public TokenTypes GetNodeType()
    {
        return Token.Type;
    }

    public bool IsNull()
    {
        return Token == null;
    }

    public override string ToString()
    {
        return Token != null ? Token.Value : "null";
    }

    public string ToStringTree()
    {
        if (_children == null || _children.Count == 0) return ToString();
        var stringBuilder = new StringBuilder();
        if(!IsNull())
        {
            stringBuilder.Append("(");
            stringBuilder.Append(ToString());
        }
        foreach(var child in _children)
        {
            stringBuilder.Append(" ");
            stringBuilder.Append(child.ToStringTree());
        }
        if(!IsNull()) stringBuilder.Append(")");
        return stringBuilder.ToString();
    }
}