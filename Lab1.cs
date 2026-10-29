using System;

class Matrix
{
    private int N { get; set; }
    private int A { get; set; }
    private int B { get; set; }

    private int[,] data;

    public Matrix(int n, int a, int b)
    {
        N = n;
        A = a;
        B = b;
        FillMatrix();
    }

    private void FillMatrix()
    {
        Random rnd = new Random();
        data = new int[N, N];
        for (int i = 0; i < N; i++)
            for (int j = 0; j < N; j++)
                data[i, j] = rnd.Next(A, B + 1);
    }

    public void ShowMatrix()
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
                Console.Write($"{data[i, j],5}");
            Console.WriteLine();
        }
    }

    public int CountOdd()
    {
        int count = 0;
        foreach (int x in data)
            if (x % 2 != 0)
                count++;
        return count;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("A = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("B = ");
        int b = int.Parse(Console.ReadLine());

        Matrix m = new Matrix(n, a, b);
        m.ShowMatrix();
        Console.WriteLine("Odd numbers count: " + m.CountOdd());
    }
}
