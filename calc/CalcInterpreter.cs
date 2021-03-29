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
            var result = Interpret(node.GetChild(1))/Interpret(node.GetChild(2));
            return result;
        }

        private double Multiply(AstNode node)
        {
            var result = Interpret(node.GetChild(1))*Interpret(node.GetChild(2));
            return result;
        }

        private double Minus(AstNode node)
        {
            var result = Interpret(node.GetChild(1))-Interpret(node.GetChild(2));
            return result;
        }

        private double Plus(AstNode node)
        {
            var result = Interpret(node.GetChild(1))+Interpret(node.GetChild(2));
            return result;
        }
    }
}
