namespace ClassLibrary1
{
    public class Calculator
    {
        public int AddTwoIntegers(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public int SubTwoIntegers(int a, int b)
        {
            int c = a - b;
            return c;
        }

        public int MultTwoIntegers(int a, int b)
        {
            int c = a * b;
            if (a > 0 && b > 0)
            {
                if (c < 0) { throw new System.ArgumentException("Number to large for Int, should use Double"); }
            }
            if (a < 0 && b < 0)
            {
                if (c < 0) { throw new System.ArgumentException("Number to large for Int, should use Double"); }
            }
            if (a > 0 && b < 0)
            {
                if (c > 0) { throw new System.ArgumentException("Number to large for Int, should use Double"); }
            }
            if (a < 0 && b > 0)
            {
                if (c > 0) { throw new System.ArgumentException("Number to large for Int, should use Double"); }
            }
            return c;
        }

        public int DivTwoIntegers(int a, int b)
        {
            int c = a / b;
            return c;
        }

        public double MultTwoDoubles(double a, double b)
        {
            double c = a * b;
            return c;
        }
        public double DivTwoDoubles(double a, double b)
        {
            if (b == 0) { throw new System.ArgumentException("Cannot Divide by 0"); }
            double c = a / b;
            return c;
        }
    }
}