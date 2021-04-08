using System;

namespace calc
{
    public class CalcParserTwo : Parser
    {
        public CalcParserTwo(CalcLexer lexer) : base(lexer, 2)
        {
            
        }

        public AstNode Parse()
        {
            var root = Parse(LookAheadToken(2));
            return root;
        }

        public AstNode Parse(Token token)
        {
            switch(token.Type)
            {
                case TokenTypes.EXP:
                case TokenTypes.MULTIPLY: 
                case TokenTypes.DIVIDE:
                case TokenTypes.PLUS: 
                case TokenTypes.MINUS:  return BinOp(token);
                case TokenTypes.INTEGER:
                case TokenTypes.FLOAT: return new AstNode(LookAheadToken(1));
                case TokenTypes.EOF: return null;
                default: throw new Exception($"Token type not recognized ");
            }
        }

        private AstNode BinOp(Token op)
        {
            var left = LookAheadToken(1);
            Devour();
            var root = new AstNode(op);
            Devour();
            var right = LookAheadToken(1);
            Devour();
            root.AddChildNode(Parse(left));
            root.AddChildNode(Parse(right));
            return root;
        }
    }
}
