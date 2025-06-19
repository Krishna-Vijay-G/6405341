using System;

class TestSingleton
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        logger1.Log("First log message");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("Second log message");

        if (logger1 == logger2)
        {
            Console.WriteLine("Both logger1 and logger2 refer to the same instance.");
        }
        else
        {
            Console.WriteLine("Different instances exist.");
        }

        Console.WriteLine("\nDone by Superset ID: 6405341\n");
    }
}
