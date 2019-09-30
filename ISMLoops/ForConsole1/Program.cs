using System;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("B = ");
            int b = Convert.ToInt32(Console.ReadLine());
            int dob;
            if (a < b)
            {
                for (int i = a; i <= b; i++)
                {
                    dob = a * b;
                    Console.WriteLine(dob);
                    a++;
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
