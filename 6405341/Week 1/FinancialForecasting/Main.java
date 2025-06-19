package FinancialForecasting;

public class Main {
    public static void main(String[] args) {
        double initial = 10000;
        double growth = 0.10;
        int years = 5;

        double future = Forecast.futureValue(initial, growth, years);
        System.out.println("\nFuture Value (Recursive): Rs." + future);

        double[] memo = new double[years + 1];
        double futureOptimized = Forecast.futureValueMemo(initial, growth, years, memo);
        System.out.println("Future Value (Memoized): Rs." + futureOptimized);

        System.out.println("\nDone by Superset ID: 6405341\n");
    }
}

