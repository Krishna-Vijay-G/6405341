namespace FinancialForecasting
{
    public class Forecast
    {
        public static double FutureValue(double initialValue, double growthRate, int years)
        {
            if (years == 0)
                return initialValue;

            return FutureValue(initialValue, growthRate, years - 1) * (1 + growthRate);
        }

        public static double FutureValueMemo(double initialValue, double growthRate, int years, double[] memo)
        {
            if (years == 0)
                return initialValue;

            if (memo[years] != 0)
                return memo[years];

            memo[years] = FutureValueMemo(initialValue, growthRate, years - 1, memo) * (1 + growthRate);
            return memo[years];
        }
    }
}
