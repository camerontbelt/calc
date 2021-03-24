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
                case TokenTypes.INTEGER: return Convert.ToDouble(node.Token.Value);
                case TokenTypes.FLOAT: return Convert.ToDouble(node.Token.Value);
                case TokenTypes.EOF: return 0;
                default: return 0;
            }
        }

        private double Divide(AstNode node)
        {
            if(node.GetChild(2).Token.Type == TokenTypes.INTEGER || node.GetChild(2).Token.Type == TokenTypes.FLOAT)
            {
                var lop = Convert.ToDouble(node.GetChild(1).Token.Value);
                var rop = Convert.ToDouble(node.GetChild(2).Token.Value);
                return lop/rop;
            }
            else if(node.GetChild(1).Token.Type == TokenTypes.INTEGER || node.GetChild(1).Token.Type == TokenTypes.FLOAT)
            {
                var lop = Convert.ToDouble(node.GetChild(1).Token.Value);
                return lop / Interpret(node.GetChild(2));
            }
            else return Interpret(node.GetChild(2));
        }

        private double Multiply(AstNode node)
        {
            if(node.GetChild(2).Token.Type == TokenTypes.INTEGER 
            || node.GetChild(2).Token.Type == TokenTypes.FLOAT)
            {
                var lop = Convert.ToDouble(node.GetChild(1).Token.Value);
                var rop = Convert.ToDouble(node.GetChild(2).Token.Value);
                return lop*rop;
            }
            else if(node.GetChild(1).Token.Type == TokenTypes.INTEGER 
            || node.GetChild(2).Token.Type == TokenTypes.FLOAT)
            {
                var lop = Convert.ToDouble(node.GetChild(1).Token.Value);
                return lop*Interpret(node.GetChild(2));
            }
            else
            {
                return Interpret(node.GetChild(2));
            }
        }

        private double Minus(AstNode node)
        {
            if(node.GetChild(2).Token.Type == TokenTypes.INTEGER 
            || node.GetChild(2).Token.Type == TokenTypes.FLOAT)
            {
                var lop = Convert.ToDouble(node.GetChild(1).Token.Value);
                var rop = Convert.ToDouble(node.GetChild(2).Token.Value);
                return lop-rop;
            }
            else if(node.GetChild(1).Token.Type == TokenTypes.INTEGER 
            || node.GetChild(1).Token.Type == TokenTypes.FLOAT)
            {
                var lop = Convert.ToDouble(node.GetChild(1).Token.Value);
                return lop-Interpret(node.GetChild(2));
            }
            else
            {
                return Interpret(node.GetChild(2));
            }
        }

        private double Plus(AstNode node)
        {
            if(node.GetChild(2).Token.Type == TokenTypes.INTEGER 
            || node.GetChild(2).Token.Type == TokenTypes.FLOAT)
            {
                var lop = Convert.ToDouble(node.GetChild(1).Token.Value);
                var rop = Convert.ToDouble(node.GetChild(2).Token.Value);
                return lop+rop;
            }
            else if(node.GetChild(1).Token.Type == TokenTypes.INTEGER 
            || node.GetChild(1).Token.Type == TokenTypes.FLOAT)
            {
                var lop = Convert.ToDouble(node.GetChild(1).Token.Value);
                return lop+Interpret(node.GetChild(2));
            }
            else
            {
                return Interpret(node.GetChild(2));
            }
        }
    }
}
