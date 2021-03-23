public class CalcParser : Parser
{
    public CalcParser(CalcLexer lexer) : base(lexer, 3)
    {
    }

    public AstNode Parse()
    {
        var root = Expression();
        return root;
    }

    public AstNode Expression()
    {
        var loperand = new AstNode(LookAheadToken(1));
        Devour();
        var op = new AstNode(LookAheadToken(1));
        op.AddChildNode(loperand);
        Devour();
        if(LookAhead(2) == TokenTypes.EOF)
        {
            var roperand = new AstNode(LookAheadToken(1));
            Devour();
            op.AddChildNode(roperand);
            return op;
        } 
        if(LookAhead(2) == TokenTypes.PLUS 
        || LookAhead(2) == TokenTypes.MULTIPLY
        || LookAhead(2) == TokenTypes.DIVIDE
        || LookAhead(2) == TokenTypes.MINUS)
        {
            op.AddChildNode(Expression());
            return op;
        } 
        return null;
    }
}