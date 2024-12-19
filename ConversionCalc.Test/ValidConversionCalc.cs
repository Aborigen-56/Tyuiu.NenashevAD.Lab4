using ConversionCalc.Lib;

namespace ConversionCalc
{
    [TestClass]
    public class ValidConversionCalc
    {
        private ConversionCalcLib calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new ConversionCalcLib();
        }

        [TestMethod]
        public void TestKilogramsToPounds()
        {
            double result = calculator.Convert(1, "kg", "lbs");
            Assert.AreEqual(2.20462, result, 0.0001);
        }

        [TestMethod]
        public void TestPoundsToKilograms()
        {
            double result = calculator.Convert(2.20462, "lbs", "kg");
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestKilogramsToOunces()
        {
            double result = calculator.Convert(1, "kg", "oz");
            Assert.AreEqual(35.274, result, 0.0001);
        }

        [TestMethod]
        public void TestOuncesToKilograms()
        {
            double result = calculator.Convert(35.274, "oz", "kg");
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestGramsToPounds()
        {
            double result = calculator.Convert(453.592, "g", "lbs");
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestPoundsToGrams()
        {
            double result = calculator.Convert(1, "lbs", "g");
            Assert.AreEqual(453.592, result, 0.0001);
        }

        [TestMethod]
        public void TestKilogramsToTons()
        {
            double result = calculator.Convert(1000, "kg", "tons");
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestTonsToKilograms()
        {
            double result = calculator.Convert(1, "tons", "kg");
            Assert.AreEqual(1000, result, 0.0001);
        }

        // Тесты для длины
        [TestMethod]
        public void TestMetersToFeet()
        {
            double result = calculator.Convert(1, "m", "ft");
            Assert.AreEqual(3.28084, result, 0.0001);
        }

        [TestMethod]
        public void TestFeetToMeters()
        {
            double result = calculator.Convert(3.28084, "ft", "m");
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestMetersToInches()
        {
            double result = calculator.Convert(1, "m", "in");
            Assert.AreEqual(39.3701, result, 0.0001);
        }

        [TestMethod]
        public void TestInchesToMeters()
        {
            double result = calculator.Convert(39.3701, "in", "m");
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestCentimetersToInches()
        {
            double result = calculator.Convert(2.54, "cm", "in");
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestInchesToCentimeters()
        {
            double result = calculator.Convert(1, "in", "cm");
            Assert.AreEqual(2.54, result, 0.0001);
        }

        // Тесты для объема
        [TestMethod]
        public void TestLitersToMilliliters()
        {
            double result = calculator.Convert(1, "l", "ml");
            Assert.AreEqual(1000, result, 0.0001);
        }

        [TestMethod]
        public void TestMillilitersToLiters()
        {
            double result = calculator.Convert(1000, "ml", "l");
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestLitersToGallons()
        {
            double result = calculator.Convert(1, "l", "gal");
            Assert.AreEqual(0.264172, result, 0.0001);
        }

        [TestMethod]
        public void TestGallonsToLiters()
        {
            double result = calculator.Convert(0.264172, "gal", "l");
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestLitersToCubicMeters()
        {
            double result = calculator.Convert(1, "l", "m3");
            Assert.AreEqual(0.001, result, 0.0001);
        }

        [TestMethod]
        public void TestCubicMetersToLiters()
        {
            double result = calculator.Convert(0.001, "m3", "l");
            Assert.AreEqual(1, result, 0.0001);
        }

        [TestMethod]
        public void TestMillilitersToGallons()
        {
            double result = calculator.Convert(1000, "ml", "gal");
            Assert.AreEqual(0.264172, result, 0.0001);
        }

        [TestMethod]
        public void TestMillilitersToCubicMeters()
        {
            double result = calculator.Convert(1000, "ml", "m3");
            Assert.AreEqual(0.001, result, 0.0001);
        }

        [TestMethod]
        public void TestCubicMetersToMilliliters()
        {
            double result = calculator.Convert(0.001, "m3", "ml");
            Assert.AreEqual(1000, result, 0.0001);
        }

        [TestMethod]
        public void TestGallonsToCubicMeters()
        {
            double result = calculator.Convert(1, "gal", "m3");
            Assert.AreEqual(0.00378541, result, 0.0001);
        }

        [TestMethod]
        public void TestCubicMetersToGallons()
        {
            double result = calculator.Convert(0.00378541, "m3", "gal");
            Assert.AreEqual(1, result, 0.0001);
        }
    }
}