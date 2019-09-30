using System;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            if (n > 0 && n % 1 == 0)
            {
                for (double i = 1; i <= n; i++)
                {
                    sum = sum + (1 / i);
                    Console.WriteLine(sum);
                }
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadKey();
        }
    }
}
