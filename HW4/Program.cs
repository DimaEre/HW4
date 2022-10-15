using System;

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
        b = 0;
        for (int i = 0; i < 2; i++)
        {
            a[i] = b;
            b++;
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

