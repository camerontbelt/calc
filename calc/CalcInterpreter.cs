using System;

namespace calc
{
    public class CalcInterpreter
    {
        private readonly AstNode _root;

        public CalcInterpreter(AstNode root)
        {
            _root = root;
        }

        public double Interpret()
        {
            switch(_root.Token.Type)
            {
                case TokenTypes.PLUS: return Plus(_root);
                //case TokenTypes.INTEGER: return 
                default: return 0;
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
            if(node.GetChild(2).Token.Type == TokenTypes.PLUS)
            {
                return lop + Plus(node.GetChild(2));
            }
            return 0;
        }
    }
}
