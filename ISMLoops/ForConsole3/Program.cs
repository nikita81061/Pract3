using System;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень числа: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double res = 1;
            if (n > 0 && n % 1 == 0)
            {
                for (double i = 1; i <= n; i++)
                {
                    res = res * a;
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
