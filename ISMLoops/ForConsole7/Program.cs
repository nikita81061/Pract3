using System;

namespace ForConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("K = ");
            int k = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            if(n > 0 && k > 0)
            {
                for(int i = 1; i <= n; i++)
                {
                    sum = sum + Math.Pow(i, k); 
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
