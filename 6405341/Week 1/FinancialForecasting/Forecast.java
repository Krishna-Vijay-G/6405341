package FinancialForecasting;

public class Forecast {

    public static double futureValue(double initialValue, double growthRate, int years) {
        if (years == 0) return initialValue;

        return futureValue(initialValue, growthRate, years - 1) * (1 + growthRate);
    }

    public static double futureValueMemo(double initialValue, double growthRate, int years, double[] memo) {
        if (years == 0) return initialValue;

        if (memo[years] != 0) return memo[years];

        memo[years] = futureValueMemo(initialValue, growthRate, years - 1, memo) * (1 + growthRate);
        return memo[years];
    }
}

