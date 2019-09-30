using System;

namespace ForConsole6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            int a;
            if (n > 0 && n % 1 == 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    a = n + 1;
                    sum = sum + Math.Pow(i, a - i);
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadKey();
        }
    }
}
