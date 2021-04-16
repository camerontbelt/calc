using System;

namespace calc
{
    public class BinaryOp : AstNode
    {
        public BinaryOp(Token op, Token rightOperand, Token leftOperand) : base(op)
        { 
            base.AddChildNode(new AstNode(leftOperand));
            base.AddChildNode(new AstNode(rightOperand));
        }
    }
}
