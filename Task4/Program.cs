using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат");
            int max = a;
            if (max < b) max = b;
            if (max < c) max = c;
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
