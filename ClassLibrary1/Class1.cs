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
            return c;
        }

        public int DivTwoIntegers(int a, int b)
        {
            if (b == 0) { throw new System.ArgumentException("Cannot Divide by 0"); }
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
            double c = a / b;
            return c;
        }
    }
}