namespace OrdinaryCalc.Lib
{
    public class OrdinaryCalcLib
    {
        public double CalcSumma(double a, double b)
        {
            return a + b;
        }

        public double CalcDifference(double a, double b)
        {
            return a - b;
        }

        public double CalcMultiplication(double a, double b)
        {
            return a * b;
        }

        public double CalcQuotient(double a, double b)
        {
            if (a == 0 || b == 0)
            {
                throw new DivideByZeroException("Quotient of zero is not allowed.");
            }
            return a / b;
        }

        public double CalcPercentage(double a)
        {
            return a / 100;
        }

        public double CalcReciprocal(double a)
        {
            if (a == 0)
            {
                throw new DivideByZeroException("Reciprocal of zero is not allowed.");
            }
            return 1 / a;
        }

        public double CalcSquare(double a)
        {
            return a * a;
        }

        public double CalcSquareRoot(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Square root of negative number is not allowed.");
            }
            return Math.Sqrt(a);
        }
    }
}
