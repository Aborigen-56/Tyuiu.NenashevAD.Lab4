namespace ArithmeticCalc.Lib
{
    public class ArithmeticCalcLib
    {
        public double CalcNaturalLogarithm(double a)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Natural logarithm argument must be positive.");
            }
            return Math.Log(a);
        }

        public double CalcSin(double a)
        {
            return Math.Sin(a);
        }

        public double CalcCos(double a)
        {
            return Math.Cos(a);
        }

        public double CalcTan(double a)
        {
            return Math.Tan(a);
        }

        public double CalcPowerOfTen(double a)
        {
            return Math.Pow(a, 10);
        }

        public double CalcPowerOfNumber(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public double CalcFactorial(double a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Factorial is not defined for negative numbers.");
            }
            if (a == 0)
            {
                return 1;
            }
            double result = 1;
            for (int i = 1; i <= a; i++)
            {
                result *= i;
            }
            return result;
        }

        public double CalcPi()
        {
            return Math.PI;
        }

        public double CalcAbsoluteValue(double a)
        {
            return Math.Abs(a);
        }

        public double CalcExponent(double a)
        {
            return Math.Exp(a);
        }
    }
}
