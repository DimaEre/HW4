using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        int[] a = new int[0];
        int b = 0;
        while (b <= 2)
        {
            Console.WriteLine("Введіть розмір(більше 2):");
            b = Convert.ToInt32(Console.ReadLine());
        }
        a = new int[b];
        Console.WriteLine("Введіть перші 2 числа");
        for (int i = 0; i < 2; i++)
        {
            b = Convert.ToInt32(Console.ReadLine());
            a[i] = b;
        }
        for (int i = 2; i < a.Length; i++)
        {
            b = a[i - 2] + a[i - 1];
            a[i] = b;
        }
        Console.WriteLine("Результат:   ");
        foreach (int i in a)
            Console.WriteLine(i);
       

    }
}

