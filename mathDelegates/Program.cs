using System.Security.Cryptography.X509Certificates;

namespace mathDelegates
{


    public class MathSolutions
    {
        // Declaring my custom delegate    
        public delegate double ProductDelegate(double x, double y);

        public double GetSum(double x, double y)
        {
            return x + y;
        }

        public double GetProduct(double a, double b)
        {
            return a * b;
        }

        public void GetSmaller(double a, double b)
        {
            if (a < b)
                Console.WriteLine($" {a} is smaller than {b}");
            else if (b < a)
                Console.WriteLine($" {b} is smaller than {a}");
            else
                Console.WriteLine($" {b} is equal to {a}");
        }
        static void Main(string[] args)
        {
            // create a class object
            MathSolutions answer = new MathSolutions();

            // Instatiating my custom delegate
            ProductDelegate product = new ProductDelegate(answer.GetProduct);

            // Func used for GetSum
            Func<double, double, double> calculate = answer.GetSum;

            // Action delegate used for GetSmaller
            Action<double, double> smaller = answer.GetSmaller;

            Random r = new Random();
            double num1 = Math.Round(r.NextDouble() * 100);
            double num2 = Math.Round(r.NextDouble() * 100);

            Console.WriteLine($" {num1} + {num2} = {calculate(num1, num2)}");
            Console.WriteLine($" {num1} * {num2} = {product(num1, num2)}");
            smaller(num1, num2);
        }
    }
}