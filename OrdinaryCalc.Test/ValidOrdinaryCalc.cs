using OrdinaryCalc.Lib;

namespace OrdinaryCalc
{
    [TestClass]
    public class ValidOrdinaryCalc
    {
        private OrdinaryCalcLib calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new OrdinaryCalcLib();
        }
        [TestMethod]
        public void TestCalcSumma()
        {
            double result = calculator.CalcSumma(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestCalcDifference()
        {
            double result = calculator.CalcDifference(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestCalcMultiplication()
        {
            double result = calculator.CalcMultiplication(2, 3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestCalcQuotient()
        {
            double result = calculator.CalcQuotient(6, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestCalcQuotientByZero()
        {
            double result = calculator.CalcQuotient(6, 0);
        }

        [TestMethod]
        public void TestCalcPercentage()
        {
            double result = calculator.CalcPercentage(500);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestCalcReciprocal()
        {
            double result = calculator.CalcReciprocal(4);
            Assert.AreEqual(0.25, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestCalcReciprocalOfZero()
        {
            double result = calculator.CalcReciprocal(0);
        }

        [TestMethod]
        public void TestCalcSquare()
        {
            double result = calculator.CalcSquare(4);
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void TestCalcSquareRoot()
        {
            double result = calculator.CalcSquareRoot(16);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCalcSquareRootOfNegativeNumber()
        {
            double result = calculator.CalcSquareRoot(-1);
        }
    }
}