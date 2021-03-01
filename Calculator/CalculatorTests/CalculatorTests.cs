using Calculator;
using NUnit.Framework;
using System;

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        SimpleCalculator _simpleCalculator;

        [SetUp]
        public void Init()
        {
            _simpleCalculator = new SimpleCalculator();
        }

        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(10, 2, 12)]
        [TestCase(55, 10, 65)]
        public void Addition_WhenCalled_ReturnTheSumOfArguments(double a, double b, double result)
        {
            double res = _simpleCalculator.Addition(a, b);
            Assert.That(result, Is.EqualTo(res));
        }

        [Test]
        [TestCase(1, 2, -1)]
        [TestCase(10, 2, 8)]
        [TestCase(55, 10, 45)]
        [TestCase(-10, 2, -12)]
        [TestCase(-55, -10, -45)]
        public void Subtraction_WhenCalled_ReturnTheSubtractionOfArguments(double a, double b, double result)
        {
            double res = _simpleCalculator.Subtraction(a, b);
            Assert.AreEqual(result,res);
        }

        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(-10, 2, -20)]
        [TestCase(-55, -10, 550)]
        [TestCase(-55, 0, 0)]
        [TestCase(0, 0, 0)]

        public void Multiplication_WhenCalled_ReturnTheMultiplicationOfArguments(double a, double b, double result)
        {
            double res = _simpleCalculator.Multiplication(a, b);
            Assert.AreEqual(result, res);
        }

        [Test]
        [TestCase(1, 2, 0.5)]
        [TestCase(-10, 2, -5)]
        [TestCase(-55, -10, 5.5)]
        [TestCase(-55, -5, 11)]
        public void Division_WhenCalled_ReturnTheDivisionOfArguments(double a, double b, double result)
        {
            double res = _simpleCalculator.Division(a, b);
            Assert.AreEqual(result, res);
            
        }

        [Test]
        [TestCase(12, 2, 6)]
        public void Division_WhenCalled_ArgumentException(double a, double b, double result)
        {
            Assert.That(() => _simpleCalculator.Division(a, b), Throws.ArgumentException);

        }


        [Test]
        [TestCase(1, 2)]
        [TestCase(10, 2)]
        [TestCase(55, 10)]
        public void TestAddAndClear(double a,double b)
        {
            var res = _simpleCalculator.Addition(a, b);
            Assert.AreEqual(_simpleCalculator.GetResult, res);

            _simpleCalculator.AllClear();
            Assert.AreEqual(_simpleCalculator.GetResult, 0);
        }
    }
}
