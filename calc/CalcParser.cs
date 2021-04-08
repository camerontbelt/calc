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
        while(LookAhead(1) == TokenTypes.PLUS || LookAhead(1) == TokenTypes.MINUS)
        {
            var op = new AstNode(LookAheadToken(1));
            op.AddChildNode(term);
            Devour();// Eat the operator
            op.AddChildNode(Term());
            term = op;
        }
        return term;
    }

    public AstNode Term()
    {
        var factor = Exponent();
        while(LookAhead(1) == TokenTypes.MULTIPLY || LookAhead(1) == TokenTypes.DIVIDE)
        {
            var op = new AstNode(LookAheadToken(1));
            op.AddChildNode(factor);
            Devour();// Eat the operator
            op.AddChildNode(Exponent());
            factor = op;
        }
        return factor;
    }

    public AstNode Exponent()
    {
        var factor = Factor();
        while(LookAhead(1) == TokenTypes.EXP)
        {
            var op = new AstNode(LookAheadToken(1));
            op.AddChildNode(factor);
            Devour();// Eat the operator
            op.AddChildNode(Factor());
            factor = op;
        }
        return factor;
    }

    public AstNode Factor()
    {
        var factor = new AstNode(LookAheadToken(1));
        Devour();
        return factor;
    }
}