using System;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите %");
            double s = 10;
            double p = Convert.ToDouble(Console.ReadLine());
            int days = 0;
            if(p > 0 && p < 50)
            {
                while(s < 200)
                {
                    s += s * (p / 100);
                    days++;
                }
                Console.WriteLine("Количество дней:" + days);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
        }
    }
}
