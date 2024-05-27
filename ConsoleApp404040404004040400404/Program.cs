using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp404040404004040400404
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1

            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y = ");
            //int y = int.Parse(Console.ReadLine());
            //int i = x + y;
            //Console.WriteLine($"{x} + {y} = {i}");
            //Console.ReadLine();

            // Задача 2

            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y = ");
            //int y = int.Parse(Console.ReadLine());
            //Console.Write("z = ");
            //int z = int.Parse(Console.ReadLine());
            //int i = x + y + z;
            //Console.WriteLine($"{x} + {y} + {z} = {i}");
            //Console.ReadLine();

            // Задача 3

            //Console.Write("x = ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("y = ");
            //double y = double.Parse(Console.ReadLine());
            //double i = x * y;
            //Console.WriteLine($"{x:f1} * {y:f1} = {i:f1}");
            //Console.ReadLine();

            // Задача 4

            //Console.Write("x = ");
            //double x = double.Parse(Console.ReadLine());
            //Console.Write("y = ");
            //double y = double.Parse(Console.ReadLine());
            //double i = x / y;
            //Console.WriteLine($"{x:f3} / {y:f3} = {i:f3}");
            //Console.ReadLine();

            // Задача 5

            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y = ");
            //int y = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{x} + {y} = {y} + {x}");
            //Console.ReadLine();

            // Задача 6

            //Console.Write("a = ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("b = ");
            //int b = int.Parse(Console.ReadLine());
            //int i = a + b;
            //int o = a - b;
            //int p = a * b;
            //Console.WriteLine($"a + b = {a} + {b} = {i}\ta - b = {a} - {b} = {o}\ta * b = {a} * {b} = {p}");
            //Console.ReadLine();

            // Задача 7

            //Console.Write("Как тебя зовут? - ");
            //string a = Console.ReadLine();
            //Console.Write("Сколько тебе лет? - ");
            //int b = int.Parse(Console.ReadLine());
            //int i = 2009 - b;
            //Console.Write($"{a}, ты родился(лась) в {i} году");
            //Console.ReadLine();

            // Задача 8

            //Console.Write("Номинал купюры - ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Количество купюр - ");
            //int b = int.Parse(Console.ReadLine());
            //int i = a * b;
            //Console.WriteLine($"Сумма денег = {i:f2}");
            //Console.ReadLine();

            // Задача 9 

            //Console.Write("Сторона квадрата равна - ");
            //int a = int.Parse(Console.ReadLine());
            //int P = a * 4;
            //Console.Write($"Периметр квадрата равен - {P}");
            //Console.Read();

            // Задача 10

            //Console.Write("Первая сторона треугольнка равна - ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Вторая сторона треугольнка равна - ");
            //int b = int.Parse(Console.ReadLine());
            //int P = 2*(a+b);
            //Console.Write($"Периметр треугольника равен - {P}");
            //Console.Read();

            // Задача 11

            //Console.Write("Радиус окружности равен - ");
            //int R = int.Parse(Console.ReadLine());
            //double L = 2 * Math.PI * R;
            //Console.Write($"Длина окружности равна - {L:f1}");
            //Console.Read();

            // Задача 12

            Console.Write("Укажите объём на флешке (Гб) - ");
            double a = double.Parse(Console.ReadLine());
            double i = (a * 1024) - 820;
            if (i<0)
            {
                Console.Write("Не хватает места");
            }
            else
            {
                Console.Write($"Файл перемещён на флешку\nОсталось места на флешке - {i} Мб");
            }
            Console.ReadLine();
        }
    }
}
