using System;

namespace ForConsole5
{
    class Program
    {
        static int Fac(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Fac(n - 1);
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            if (n > 0 && n % 1 == 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    res = res + Fac(i);
                }
                Console.WriteLine(res);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadKey();
        }
    }
}
