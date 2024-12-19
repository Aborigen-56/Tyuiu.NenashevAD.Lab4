using ArithmeticCalc.Lib;

namespace ArithmeticCalc
{
    [TestClass]
    public class ValidArithmeticCalc
    {
        private ArithmeticCalcLib calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new ArithmeticCalcLib();
        }

        [TestMethod]
        public void TestNaturalLogarithm()
        {
            double result = calculator.CalcNaturalLogarithm(Math.E);
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestNaturalLogarithmWithNonPositiveArgument()
        {
            double result = calculator.CalcNaturalLogarithm(-1);
        }

        [TestMethod]
        public void TestSine()
        {
            double result = calculator.CalcSin(Math.PI / 2);
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestCosine()
        {
            double result = calculator.CalcCos(0);
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestTangent()
        {
            double result = calculator.CalcTan(Math.PI / 4);
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestPowerOfTen()
        {
            double result = calculator.CalcPowerOfTen(2);
            Assert.AreEqual(1024, result);
        }

        [TestMethod]
        public void TestPowerOfPower()
        {
            double result = calculator.CalcPowerOfNumber(2, 3);
            Assert.AreEqual(Math.Pow(2, 3), result);
        }

        [TestMethod]
        public void TestFactorial()
        {
            double result = calculator.CalcFactorial(5);
            Assert.AreEqual(120, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestFactorialWithNegativeNumber()
        {
            double result = calculator.CalcFactorial(-1);
        }

        [TestMethod]
        public void TestPi()
        {
            double result = calculator.CalcPi();
            Assert.AreEqual(Math.PI, result);
        }

        [TestMethod]
        public void TestAbsoluteValue()
        {
            double result = calculator.CalcAbsoluteValue(-5);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestExponent()
        {
            double result = calculator.CalcExponent(1);
            Assert.AreEqual(Math.E, result, 0.0001);
        }
    }
}