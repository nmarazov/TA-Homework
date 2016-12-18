using System;


class Program
{
    static void Main()
    {
        double a;
        double b;
        double sum;
        const double eps = 0.000001;
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        sum = Math.Abs(a - b);
        bool result = sum < eps;
        Console.WriteLine(result.ToString().ToLower());
    }   
}

