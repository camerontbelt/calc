using System;

namespace calc
{
    public class CalcInterpreter
    {
        public double Interpret(AstNode node)
        {
            switch(node.Token.Type)
            {
                case TokenTypes.PLUS: return Plus(node);
                case TokenTypes.MINUS: return Minus(node);
                case TokenTypes.MULTIPLY: return Multiply(node);
                case TokenTypes.DIVIDE: return Divide(node);
                default: return 0;
            }
        }

        private double Divide(AstNode node)
        {
            var lop = Convert.ToDouble(node.GetChild(1).Token.Value);
            if(node.GetChild(2).Token.Type == TokenTypes.INTEGER 
            || node.GetChild(2).Token.Type == TokenTypes.FLOAT)
            {
                var rop = Convert.ToDouble(node.GetChild(2).Token.Value);
                return lop/rop;
            }
            else
            {
                return lop / Interpret(node.GetChild(2));
            }
        }

        private double Multiply(AstNode node)
        {
            var lop = Convert.ToDouble(node.GetChild(1).Token.Value);
            if(node.GetChild(2).Token.Type == TokenTypes.INTEGER 
            || node.GetChild(2).Token.Type == TokenTypes.FLOAT)
            {
                var rop = Convert.ToDouble(node.GetChild(2).Token.Value);
                return lop*rop;
            }
            else
            {
                return lop * Interpret(node.GetChild(2));
            }
        }

        private double Minus(AstNode node)
        {
            var lop = Convert.ToDouble(node.GetChild(1).Token.Value);
            if(node.GetChild(2).Token.Type == TokenTypes.INTEGER 
            || node.GetChild(2).Token.Type == TokenTypes.FLOAT)
            {
                var rop = Convert.ToDouble(node.GetChild(2).Token.Value);
                return lop-rop;
            }
            else
            {
                return lop - Interpret(node.GetChild(2));
            }
        }

        private double Plus(AstNode node)
        {
            var lop = Convert.ToDouble(node.GetChild(1).Token.Value);
            if(node.GetChild(2).Token.Type == TokenTypes.INTEGER 
            || node.GetChild(2).Token.Type == TokenTypes.FLOAT)
            {
                var rop = Convert.ToDouble(node.GetChild(2).Token.Value);
                return lop+rop;
            }
            else
            {
                return lop + Interpret(node.GetChild(2));
            }
        }
    }
}
