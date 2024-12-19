using FitnessCalc.Lib;

namespace FitnessCalc
{
    [TestClass]
    public class ValidFitnessCalc
    {
        private FitnessCalcLib calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new FitnessCalcLib();
        }

        [TestMethod]
        public void TestCalculateBMI()
        {
            double result = calculator.CalculateBMI(70, 1.75);
            Assert.AreEqual(22.857, result, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCalculateBMIWithZeroHeight()
        {
            double result = calculator.CalculateBMI(70, 0);
        }

        [TestMethod]
        public void TestCalculateBMRForMale()
        {
            var result = calculator.CalculateBMR(70, 175, 30, "male", "moderate");
            Assert.AreEqual(2628.3, result.Calories, 0.1);
            Assert.AreEqual(197.1, result.Proteins, 0.1);
            Assert.AreEqual(73.0, result.Fats, 0.1);
            Assert.AreEqual(295.7, result.Carbohydrates, 0.1);
        }

        [TestMethod]
        public void TestCalculateBMRForFemale()
        {
            var result = calculator.CalculateBMR(60, 165, 25, "female", "light");
            Assert.AreEqual(1932.3, result.Calories, 0.1);
            Assert.AreEqual(144.9, result.Proteins, 0.1);
            Assert.AreEqual(53.7, result.Fats, 0.1);
            Assert.AreEqual(217.4, result.Carbohydrates, 0.1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCalculateBMRWithInvalidGender()
        {
            var result = calculator.CalculateBMR(70, 175, 30, "invalid", "moderate");
        }
    }
}