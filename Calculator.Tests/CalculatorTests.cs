using CalculatorTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            CalculatorClass calculator = new CalculatorClass();
            Assert.That(calculator.Additional(300, 10) == 310);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            CalculatorClass calculator = new CalculatorClass();
            Assert.That(calculator.Subtraction(250, 40) == 210);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            CalculatorClass calculator = new CalculatorClass();
            Assert.That(calculator.Miltiplication(40, 2) == 80);
        }

        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            CalculatorClass calculator = new CalculatorClass();
            Assert.That(calculator.Division(50, 5) == 10);
        }
    }
}
