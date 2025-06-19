using System;

namespace FinancialForecasting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double initial = 10000;
            double growth = 0.10;
            int years = 5;

            double future = Forecast.FutureValue(initial, growth, years);
            Console.WriteLine($"\nFuture Value (Recursive): Rs.{future:F2}");

            double[] memo = new double[years + 1];
            double futureOptimized = Forecast.FutureValueMemo(initial, growth, years, memo);
            Console.WriteLine($"Future Value (Memoized): Rs.{futureOptimized:F2}");

            Console.WriteLine("\nDone by Superset ID: 6405341\n");
        }
    }
}
