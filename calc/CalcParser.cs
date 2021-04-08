public class CalcParser : Parser
{
    public CalcParser(CalcLexer lexer) : base(lexer, 1)
    {
    }

    public AstNode Parse()
    {
        var root = Expression();
        return root;
    }

    public AstNode Expression()
    {
        var term = Term();
        AstNode expression = null;
        while(LookAhead(1) == TokenTypes.PLUS || LookAhead(1) == TokenTypes.MINUS)
        {
            expression = new AstNode(LookAheadToken(1));
            expression.AddChildNode(term);
            Devour();// Eat the operator
            expression.AddChildNode(Term());
        }
        if(expression == null) return term;
        return expression;
    }

    public AstNode Term()
    {
        var factor = Exponent();
        AstNode term = null;
        while(LookAhead(1) == TokenTypes.MULTIPLY || LookAhead(1) == TokenTypes.DIVIDE)
        {
            term = new AstNode(LookAheadToken(1));
            term.AddChildNode(factor);
            Devour();// Eat the operator
            term.AddChildNode(Exponent());
        }
        if(term == null)return factor;
        return term;
    }

    public AstNode Exponent()
    {
        var factor = Factor();
        AstNode term = null;
        while(LookAhead(1) == TokenTypes.EXP)
        {
            term = new AstNode(LookAheadToken(1));
            term.AddChildNode(factor);
            Devour();// Eat the operator
            term.AddChildNode(Factor());
        }
        if(term == null)return factor;
        return term;
    }

    public AstNode Factor()
    {
        var factor = new AstNode(LookAheadToken(1));
        Devour();
        return factor;
    }
}