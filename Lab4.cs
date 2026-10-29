using System;

class Program
{
    static void A(in int x)
    {
        Console.WriteLine($"A (in): x = {x}");
    }

    static void B(out int x)
    {
        x = 42;
        Console.WriteLine($"B (out): x assigned = {x}");
    }

    static void C(ref int x)
    {
        Console.WriteLine($"C (ref): x before = {x}");
        x += 100;
        Console.WriteLine($"C (ref): x after = {x}");
    }

    static int SumValues(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
            sum += n;
        return sum;
    }

    static void Main()
    {
        int a = 5;
        A(in a);

        int b;
        B(out b);
        Console.WriteLine($"Main: b = {b}");

        int c = 7;
        C(ref c);
        Console.WriteLine($"Main: c = {c}");

        Console.WriteLine("Sum() = " + SumValues());
        Console.WriteLine("Sum(1,2,3) = " + SumValues(1, 2, 3));
        Console.WriteLine("Sum(10,20,30,40,50) = " + SumValues(10, 20, 30, 40, 50));
        Console.WriteLine("Sum(array) = " + SumValues(new int[] { 4, 5, 6 }));
    }
}
