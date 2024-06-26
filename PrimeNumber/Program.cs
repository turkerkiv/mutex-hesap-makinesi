﻿using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the beginning of the range.");
        bool isNum1 = int.TryParse(Console.ReadLine(), out int num1);
        System.Console.WriteLine("Enter the end of the range.");
        bool isNum2 = int.TryParse(Console.ReadLine(), out int num2);

        if (!isNum1 || !isNum2)
        {
            System.Console.WriteLine("Please enter a number.");
            return;
        }

        var watch = new Stopwatch();
        watch.Start();


        if (num1 > num2)
        {
            System.Console.WriteLine("The beginning of the range must be less than the end of the range.");
            return;
        }

        if (num1 < 3)
        {
            num1 = 3;
            System.Console.Write("2 ");
        }

        num1 = num1 % 2 == 0 ? num1 + 1 : num1;

        for (int i = num1; i <= num2; i += 2)
        {
            if (IsPrime(i))
            {
            }
        }

        watch.Stop();
        System.Console.WriteLine("Runtime: {0} ms", watch.ElapsedMilliseconds);
    }

    static bool IsPrime(int num)
    {
        int sqrtNum = (int)Math.Sqrt(num);
        for (int i = 3; i <= sqrtNum; i += 2)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}