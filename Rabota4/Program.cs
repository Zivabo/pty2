using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер задачи (1-20):");
        int z = int.Parse(Console.ReadLine());

        switch (z)
        {
            case 1:
                Console.Clear();
                Console.WriteLine("Введите два числа:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine($"Сумма чисел: {a + b}");
                break;

            case 2:
                Console.Clear();
                Console.WriteLine("Введите два числа:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine($"Разность чисел: {a - b}");
                break;

            case 3:
                Console.Clear();
                Console.WriteLine("Введите два числа:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine($"Произведение чисел: {a * b}");
                break;

            case 4:
                Console.Clear();
                Console.WriteLine("Введите два числа:");
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine($"Частное: {x / y}");
                break;

            case 5:
                Console.Clear();
                Console.WriteLine("Введите число:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine($"Квадрат числа: {a * a}");
                break;

            case 6:
                Console.Clear();
                Console.WriteLine("Введите число:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine($"Куб числа: {a * a * a}");
                break;

            case 7:
                Console.Clear();
                Console.WriteLine("Введите число:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine(a % 2 == 0);
                break;

            case 8:
                Console.Clear();
                Console.WriteLine("Введите число:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine(a % 2 != 0);
                break;

            case 9:
                Console.Clear();
                Console.WriteLine("Введите два числа:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine($"Максимум: {Math.Max(a, b)}");
                break;

            case 10:
                Console.Clear();
                Console.WriteLine("Введите два числа:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine($"Минимум: {Math.Min(a, b)}");
                break;

            case 11:
                Console.Clear();
                Console.WriteLine("Введите число:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine($"Модуль числа: {Math.Abs(a)}");
                break;

            case 12:
                Console.Clear();
                Console.WriteLine("Введите радиус:");
                double r = double.Parse(Console.ReadLine());
                Console.WriteLine($"Площадь круга: {Math.PI * r * r}");
                break;

            case 13:
                Console.Clear();
                Console.WriteLine("Введите число:");
                a = int.Parse(Console.ReadLine());
                bool s = true;
                if (a <= 1) s = false;
                else
                {
                    for (int i = 2; i * i <= a; i++)
                    {
                        if (a % i == 0)
                        {
                            s = false;
                            break;
                        }
                    }
                }
                Console.WriteLine($"Простое: {s}");
                break;

            case 14:
                Console.Clear();
                Console.WriteLine("Введите длину и ширину:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine($"Периметр прямоугольника: {2 * (a + b)}");
                break;

            case 15:
                Console.Clear();
                Console.WriteLine("Введите градусы Цельсия:");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine($"Фаренгейты: {c * 9 / 5 + 32}");
                break;

            case 16:
                Console.Clear();
                Console.WriteLine("Введите градусы Фаренгейта:");
                double f = double.Parse(Console.ReadLine());
                Console.WriteLine($"Цельсии: {(f - 32) * 5 / 9}");
                break;

            case 17:
                Console.Clear();
                Console.WriteLine("Введите два числа:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                Console.WriteLine($"Среднее арифметическое: {(a + b) / 2.0}");
                break;

            case 18:
                Console.Clear();
                Console.WriteLine("Введите два числа:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                while (b != 0)
                {
                    int t = b;
                    b = a % b;
                    a = t;
                }
                Console.WriteLine($"НОД: {a}");
                break;

            case 19:
                Console.Clear();
                Console.WriteLine("Введите два числа:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                int nod = a;
                int t2 = b;
                while (t2 != 0)
                {
                    int t = t2;
                    t2 = nod % t2;
                    nod = t;
                }
                Console.WriteLine($"НОК: {a * b / nod}");
                break;

            case 20:
                Console.Clear();
                Console.WriteLine("Введите число, min и max:");
                a = int.Parse(Console.ReadLine());
                int min = int.Parse(Console.ReadLine());
                int max = int.Parse(Console.ReadLine());
                Console.WriteLine($"В диапазоне: {a >= min && a <= max}");
                break;

            default:
                Console.WriteLine("Неверный номер задачи.");
                break;
        }
    }
}