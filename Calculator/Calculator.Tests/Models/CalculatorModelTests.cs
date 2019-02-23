using NUnit.Framework;

namespace Calculator.Tests.Models
{
    class CalculatorModelTests
    {
        [TestFixture]
        public class OperationTests
        {
            [Test]
            public void OperationAdd()
            {
                var calculator = new Calculator.Models.CalculatorModel();
                calculator.Process("4");
                calculator.ProcessOperation("+");
                calculator.Process("5");
                calculator.ProcessOperation("=");
                Assert.IsTrue(calculator.Display == "9");
            }
            [Test]
            public void OperationSubtract()
            {
                var calculator = new Calculator.Models.CalculatorModel();
                calculator.Process("20");
                calculator.ProcessOperation("-");
                calculator.Process("11");
                calculator.ProcessOperation("=");
                Assert.IsTrue(calculator.Display == "9");
            }
            [Test]
            public void OperationMultiply()
            {
                var calculator = new Calculator.Models.CalculatorModel();
                calculator.Process("5");
                calculator.ProcessOperation("*");
                calculator.Process("5");
                calculator.ProcessOperation("=");
                Assert.IsTrue(calculator.Display == "25");
            }
            [Test]
            public void OperationDivide()
            {
                var calculator = new Calculator.Models.CalculatorModel();
                calculator.Process("5");
                calculator.ProcessOperation("/");
                calculator.Process("1");
                calculator.ProcessOperation("=");
                Assert.IsTrue(calculator.Display == "5");
            }
            [Test]
            public void OperationSqrt()
            {
                var calculator = new Calculator.Models.CalculatorModel();
                calculator.Process("16");
                calculator.ProcessOperation("sqrt");
                Assert.IsTrue(calculator.Display == "4");
            }
            [Test]
            public void OperationPercent()
            {
                var calculator = new Calculator.Models.CalculatorModel();
                calculator.Process("100");
                calculator.ProcessOperation("%");
                calculator.Process("50");
                calculator.ProcessOperation("=");
                Assert.IsTrue(calculator.Display == "50");
            }
            [Test]
            public void OperationErrorDivide()
            {
                var calculator = new Calculator.Models.CalculatorModel();
                try
                {
                    calculator.Process("5");
                    calculator.ProcessOperation("/");
                    calculator.Process("0");
                    calculator.ProcessOperation("=");
                    Assert.Fail();
                }
                catch
                {
                    Assert.IsTrue(calculator.Display == "ERROR");
                }
            }
            [Test]
            public void OperationErrorSqrt()
            {
                var calculator = new Calculator.Models.CalculatorModel();
                try
                {
                    calculator.Process("-1");
                    calculator.ProcessOperation("sqrt");
                    Assert.Fail();
                }
                catch
                {
                    Assert.IsTrue(calculator.Display == "ERROR");
                }

            }
            [Test]
            public void OperationLongExpression()
            {
                var calculator = new Calculator.Models.CalculatorModel();
                calculator.Process("4");
                calculator.ProcessOperation("+");
                calculator.Process("7");
                calculator.ProcessOperation("-");
                calculator.Process("8");
                calculator.ProcessOperation("+");
                calculator.Process("4");
                calculator.ProcessOperation("/");
                calculator.Process("2");
                calculator.ProcessOperation("+");
                calculator.Process("55");
                calculator.ProcessOperation("+");
                calculator.Process("4");
                calculator.ProcessOperation("*");
                calculator.Process("9");
                calculator.ProcessOperation("+");
                calculator.Process("53");
                calculator.ProcessOperation("%");
                calculator.Process("100");
                calculator.ProcessOperation("=");
                Assert.IsTrue(calculator.Display == "2");
            }
            [Test]
            public void OperationMultipleExpressions()
            {
                var calculator = new Calculator.Models.CalculatorModel();
                calculator.Process("2");
                calculator.ProcessOperation("+");
                calculator.Process("3");
                calculator.ProcessOperation("=");
                Assert.IsTrue(calculator.Display == "5");
                calculator.Process("4");
                calculator.ProcessOperation("-");
                calculator.Process("5");
                calculator.ProcessOperation("=");
                Assert.IsTrue(calculator.Display == "-1");
            }
        }
    }
}

