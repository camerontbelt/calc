using NUnit.Framework;
using System;

namespace calc.test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AstNode_CreateTreeThenPrint_ShouldPass()
        {
            //Arrange
            var plus = new Token(TokenTypes.PLUS, "+");
            var one = new Token(TokenTypes.INTEGER, "1");
            var two = new Token(TokenTypes.INTEGER, "2");
            var root = new AstNode(plus);
            root.AddChildNode(new AstNode(one));
            root.AddChildNode(new AstNode(two));
            //Act
            var rootString = root.ToStringTree();
            //Assert
            Assert.AreEqual("(+ 1 2)", rootString);
        }


        [Test]
        public void AstNode_CreateParseTreeThenPrint_ShouldPass()
        {
            // //Arrange
            // var text = "[a,b[c,d]]";
            // var lexer = new ListLexer(text);
            // var parser = new ListParser(lexer);
            // var root = parser.Parse();
            // //Act
            // var rootString = root.ToStringTree();
            // //Assert
            // Assert.Pass();
        }
    }
}