public class CalcParser : Parser
{
    public CalcParser(CalcLexer lexer) : base(lexer, 1)
    {
    }

    public AstNode Parse()
    {
        var root = LogicalOperations();
        return root;
    }

    public AstNode LogicalOperations()
    {
        var boolean = BooleanOperations();
        while(LookAhead(1) == TokenTypes.AND || LookAhead(1) == TokenTypes.OR)
        {
            var op = new AstNode(LookAheadToken(1));
            op.AddChildNode(boolean);
            Devour();// Eat the operator
            op.AddChildNode(Expression());
            boolean = op;
        }
        return boolean;
    }

    public AstNode BooleanOperations()
    {
        var expression = Expression();
        while(LookAhead(1) == TokenTypes.GTHAN 
        || LookAhead(1) == TokenTypes.LTHAN 
        || LookAhead(1) == TokenTypes.GTOE 
        || LookAhead(1) == TokenTypes.LTOE
        || LookAhead(1) == TokenTypes.EQUALS)
        {
            var op = new AstNode(LookAheadToken(1));
            op.AddChildNode(expression);
            Devour();// Eat the operator
            op.AddChildNode(Expression());
            expression = op;
        }
        return expression;
    }

    // E --> T {( "+" | "-" ) T}
    
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
        while(LookAhead(1) == TokenTypes.MULTIPLY || LookAhead(1) == TokenTypes.DIVIDE || LookAhead(1) == TokenTypes.MOD)
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
        if (LookAhead(1) == TokenTypes.EXP)
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
        if(LookAhead(1) == TokenTypes.FLOAT || LookAhead(1) == TokenTypes.INTEGER)
        {
            var factor = new AstNode(LookAheadToken(1));
            Devour();
            return factor;
        }
        else if(LookAhead(1) == TokenTypes.LPAREN)
        {
            Match(TokenTypes.LPAREN);
            var expression = LogicalOperations();
            Match(TokenTypes.RPAREN);
            return expression;
        }
        else if(LookAhead(1) == TokenTypes.MINUS)
        {
            Devour();
            var operand = Exponent();
            var factor = new AstNode(new Token(TokenTypes.MINUS,"-"));
            factor.AddChildNode(new AstNode(new Token(TokenTypes.INTEGER,"0")));
            factor.AddChildNode(operand);
            return factor;
        }
        else if(LookAhead(1) == TokenTypes.NOT)
        {
            var op = new AstNode(LookAheadToken(1));
            Devour();
            Match(TokenTypes.LPAREN);
            op.AddChildNode(LogicalOperations());
            Match(TokenTypes.RPAREN);
            return op;
        }
        else
            throw new System.Exception($"Failed to parse token {LookAhead(1)}");
    }
}