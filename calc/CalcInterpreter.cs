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
                case TokenTypes.EXP: return Exponent(node);
                case TokenTypes.MOD: return Modulo(node);
                case TokenTypes.GTHAN: return GreaterThan(node);
                case TokenTypes.LTHAN: return LessThan(node);
                case TokenTypes.GTOE: return GreaterThanOrEqual(node);
                case TokenTypes.LTOE: return LessThanOrEqual(node);
                case TokenTypes.AND: return And(node);
                case TokenTypes.OR: return Or(node);
                case TokenTypes.NOT: return Not(node);
                case TokenTypes.EQUALS: return Equality(node);
                case TokenTypes.INTEGER: return Convert.ToInt32(node.Token.Value);
                case TokenTypes.FLOAT: return Convert.ToDouble(node.Token.Value);
                case TokenTypes.EOF: return 0;
                default: return 0;
            }
        }

        private double Equality(AstNode node)
        {
            var result = Interpret(node.GetChild(1)) == Interpret(node.GetChild(2)) ? 1 : 0;
            return result;
        }

        private double LessThanOrEqual(AstNode node)
        {
            var result = Interpret(node.GetChild(1)) <= Interpret(node.GetChild(2)) ? 1 : 0;
            return result;
        }

        private double GreaterThanOrEqual(AstNode node)
        {
            var result = Interpret(node.GetChild(1)) >= Interpret(node.GetChild(2)) ? 1 : 0;
            return result;
        }

        private double Not(AstNode node)
        {
            var result = Interpret(node.GetChild(1)) == 1 ? 0 : 1;
            return result;
        }

        private double Or(AstNode node)
        {
            var result = Interpret(node.GetChild(1)) == 1 || Interpret(node.GetChild(2)) == 1 ? 1 : 0;
            return result;
        }

        private double And(AstNode node)
        {
            var result = Interpret(node.GetChild(1)) == 1 && Interpret(node.GetChild(2)) == 1 
            ? 1 
            : 0;
            return result;
        }

        private double LessThan(AstNode node)
        {
            var result = Interpret(node.GetChild(1)) < Interpret(node.GetChild(2)) ? 1 : 0;
            return result;
        }

        private double GreaterThan(AstNode node)
        {
            var result = Interpret(node.GetChild(1)) > Interpret(node.GetChild(2)) ? 1 : 0;
            return result;
        }

        private double Modulo(AstNode node)
        {
            var result = Interpret(node.GetChild(1)) % Interpret(node.GetChild(2));
            return result;
        }

        private double Exponent(AstNode node)
        {
            var result = Math.Pow(Interpret(node.GetChild(1)), Interpret(node.GetChild(2)));
            return result;
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
