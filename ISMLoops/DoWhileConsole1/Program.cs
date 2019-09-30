using System;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int n;
            double s = 0;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                s = s + n;
            } while (n != 0);
            Console.WriteLine(s);
        }
    }
}
