using System;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите N: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            if (n > 0)
            {
                while (k != Math.Floor(Math.Log(n, 3)) + 1)
                {
                    k++;
                }
                Console.WriteLine(k);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            Console.ReadKey();
        }
    }
}
