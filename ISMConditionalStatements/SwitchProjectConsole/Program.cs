using System;

namespace SwitchProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Расшифровка дня недели.");
            Console.WriteLine("2. Расшифровка месяца.");
            Console.WriteLine("3. Выполнение операций над числами.");
            Console.WriteLine("4. Выход.");
            int x;
            x = Int32.Parse(Console.ReadLine());

            switch (x){
                default: Console.WriteLine("Ошибка ввода команды!");break;
                case 1:
                        Console.WriteLine("Введите номер дня недели от 1 до 7");
                        int d;
                        d = Int32.Parse(Console.ReadLine());
                        switch(d){
                            default: Console.WriteLine("Такого дня не существует!"); break;
                        case 1:
                            Console.WriteLine("Понедельник.");
                            break;
                        case 2:
                            Console.WriteLine("Вторник.");
                            break;
                        case 3:
                            Console.WriteLine("Среда.");
                            break;
                        case 4:
                            Console.WriteLine("Четверг.");
                            break;
                        case 5:
                            Console.WriteLine("Пятница.");
                            break;
                        case 6:
                            Console.WriteLine("Суббота.");
                            break;
                        case 7:
                            Console.WriteLine("Воскресенье.");
                            break;
                    }
                break;
                case 2:
                    Console.WriteLine("Введите номер дня недели от 1 до 7");
                    int m;
                    m = Int32.Parse(Console.ReadLine());
                    switch (m)
                    {
                        default: Console.WriteLine("Такого месяца не существует!"); break;
                        case 1:
                            Console.WriteLine("Январь");
                            break;
                        case 2:
                            Console.WriteLine("Февраль");
                            break;
                        case 3:
                            Console.WriteLine("Март");
                            break;
                        case 4:
                            Console.WriteLine("Апрель");
                            break;
                        case 5:
                            Console.WriteLine("Май");
                            break;
                        case 6:
                            Console.WriteLine("Июнь");
                            break;
                        case 7:
                            Console.WriteLine("Июль");
                            break;
                        case 8:
                            Console.WriteLine("Август");
                            break;
                        case 9:
                            Console.WriteLine("Сентябрь");
                            break;
                        case 10:
                            Console.WriteLine("Октябрь");
                            break;
                        case 11:
                            Console.WriteLine("Ноябрь");
                            break;
                        case 12:
                            Console.WriteLine("Декабрь");
                            break;
                    }
                    break;
                case 3:
                    double a, b, c;
                    Console.WriteLine("Введите первое число:");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Выберите действие:");
                    Console.WriteLine("1. Сложение");
                    Console.WriteLine("2. Умножение");
                    Console.WriteLine("3. Вычитание");
                    Console.WriteLine("4. Деление");
                    
                    c = double.Parse(Console.ReadLine());
                    switch (c)
                    {
                        default: Console.WriteLine("Такого месяца не существует!"); break;
                        case 1:
                            string r1 = $"{a} + {b} = {a + b}";
                            Console.WriteLine(r1);
                            break;
                        case 2:
                            string r2 = $"{a} * {b} = {a * b}";
                            Console.WriteLine(r2);
                            break;
                        case 3:
                            string r3 = $"{a} - {b} = {a - b}";
                            Console.WriteLine(r3);
                            break;
                        case 4:
                            string r4 = $"{a} / {b} = {a / b}";
                            Console.WriteLine(r4);
                            break;
                    }
                    break;
                case 4:
                    Console.WriteLine("Завершение работы!");
                    System.Environment.Exit(0);
                    break;
                
            }
        }
    }
}
