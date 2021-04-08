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
        public void Interpreter_GivenEquationSolve_1_ShouldPass()
        {
            //Arrange
            var text = "8.23987456*0.3+9-2+45";
            var lexer = new CalcLexer(text);
            var parser = new CalcParser(new CalcLexer(text));
            var tree = parser.Parse();
            var interpreter = new CalcInterpreter();
            //Act
            var result = interpreter.Interpret(tree);
            //Assert
            Assert.AreEqual(54.471962368,result);
        }

        [Test]
        public void Interpreter_GivenEquationSolve_2_ShouldPass()
        {
            //Arrange
            var text = "9-2+45";
            var lexer = new CalcLexer(text);
            var parser = new CalcParser(new CalcLexer(text));
            var tree = parser.Parse();
            var interpreter = new CalcInterpreter();
            //Act
            var result = interpreter.Interpret(tree);
            //Assert
            Assert.AreEqual(52,result);
        }


        [Test]
        public void Interpreter_GivenEquationSolve_3_ShouldPass()
        {
            //Arrange
            var text = "2^4+9*6/7";
            var lexer = new CalcLexer(text);
            var parser = new CalcParser(new CalcLexer(text));
            var tree = parser.Parse();
            var interpreter = new CalcInterpreter();
            //Act
            var result = interpreter.Interpret(tree);
            //Assert
            Assert.GreaterOrEqual(result,23.7);
        }


        [Test]
        public void Interpreter_GivenEquationSolve_4_ShouldPass()
        {
            //Arrange
            var text = "1-(2+3)";
            var lexer = new CalcLexer(text);
            var parser = new CalcParser(new CalcLexer(text));
            var tree = parser.Parse();
            var interpreter = new CalcInterpreter();
            //Act
            var result = interpreter.Interpret(tree);
            //Assert
            Assert.AreEqual(-4,result);
        }


        [Test]
        public void Interpreter_GivenEquationSolve_5_ShouldPass()
        {
            //Arrange
            var text = "2^(-3)";
            var lexer = new CalcLexer(text);
            var parser = new CalcParser(new CalcLexer(text));
            var tree = parser.Parse();
            var interpreter = new CalcInterpreter();
            //Act
            var result = interpreter.Interpret(tree);
            //Assert
            Assert.AreEqual(0.125,result);
        }


        [Test]
        public void Interpreter_GivenEquationSolve_6_ShouldPass()
        {
            //Arrange
            var text = "2^-(4+9*6/7)";
            var lexer = new CalcLexer(text);
            var parser = new CalcParser(new CalcLexer(text));
            var tree = parser.Parse();
            var interpreter = new CalcInterpreter();
            //Act
            var result = interpreter.Interpret(tree);
            //Assert
            Assert.AreEqual(0.0002976107554210143,result);
        }


        [Test]
        public void Interpreter_GivenEquationSolve_7_ShouldFail()
        {
            //Arrange
            var text = "2^-(4+9*6/7)a";
            var lexer = new CalcLexer(text);
            var parser = new CalcParser(new CalcLexer(text));
            //Act
            //Assert
            Assert.Throws<Exception>(() => parser.Parse());
        }
    }
}