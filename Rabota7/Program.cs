using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер задания (4-13): ");
        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
            case 4:
                Console.Clear();
                double a = 3, b = 4, c = 5;
                if (a + b > c && a + c > b && b + c > a)
                    Console.WriteLine("Треугольник существует");
                else
                    Console.WriteLine("Треугольник не существует");
                break;

            case 5:
                Console.Clear();
                Console.Write("Введите номер месяца: ");
                int m = int.Parse(Console.ReadLine());
                switch (m)
                {
                    case 12:
                    case 1:
                    case 2:
                        Console.WriteLine("Зима");
                        break;
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("Весна");
                        break;
                    case 6:
                    case 7:
                    case 8:
                        Console.WriteLine("Лето");
                        break;
                    case 9:
                    case 10:
                    case 11:
                        Console.WriteLine("Осень");
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
                break;

            case 6:
                Console.Clear();
                a = 2; b = 3; c = 4;
                if (a < b && a < c)
                    a *= 2;
                else if (b < a && b < c)
                    b *= 2;
                else
                    c *= 2;
                Console.WriteLine($"A={a}, B={b}, C={c}");
                break;

            case 7:
                Console.Clear();
                double xA = 1, yA = 2;
                double xB = 3, yB = 4;
                double distA = Math.Sqrt(xA * xA + yA * yA);
                double distB = Math.Sqrt(xB * xB + yB * yB);
                if (distA < distB)
                    Console.WriteLine("Точка A ближе");
                else
                    Console.WriteLine("Точка B ближе");
                break;

            case 8:
                Console.Clear();
                a = 5; b = 5; c = 5;
                if (a == b && b == c)
                    Console.WriteLine("Равносторонний");
                else if (a == b || b == c || a == c)
                    Console.WriteLine("Равнобедренный");
                else
                    Console.WriteLine("Обычный");
                break;

            case 9:
                Console.Clear();
                double minutes = 100;
                double price1 = minutes * 50 * 0.9;
                double price2 = minutes * 45 * 0.92;
                double price3 = minutes * 55 * 0.88;
                Console.WriteLine($"Оператор 1: {price1}");
                Console.WriteLine($"Оператор 2: {price2}");
                Console.WriteLine($"Оператор 3: {price3}");
                break;

            case 10:
                Console.Clear();
                Console.Write("Введите вариант (1-3): ");
                int v = int.Parse(Console.ReadLine());
                switch (v)
                {
                    case 1:
                        Console.WriteLine("Новогодние");
                        break;
                    case 2:
                        Console.WriteLine("С Днем Рождения");
                        break;
                    case 3:
                        Console.WriteLine("С Днем Защитника Отечества");
                        break;
                    default:
                        Console.WriteLine("Ошибка");
                        break;
                }
                break;

            case 11:
                Console.Clear();
                int a_int = -3, b_int = 5;
                if (a_int * b_int < 0)
                {
                    int temp = a_int;
                    a_int = b_int;
                    b_int = temp;
                }
                Console.WriteLine($"a={a_int}, b={b_int}");
                break;

            case 12:
                Console.Clear();
                a_int = 5; b_int = 3; int c_int = 7;
                int min = a_int;
                if (b_int < min) min = b_int;
                if (c_int < min) min = c_int;
                Console.WriteLine($"Минимум: {min}");
                break;

            case 13:
                Console.Clear();
                double x = 1, y = 2, z = 3;
                double avg = (x + y + z) / 3;
                if (Math.Abs(x) > avg) Console.WriteLine(x);
                if (Math.Abs(y) > avg) Console.WriteLine(y);
                if (Math.Abs(z) > avg) Console.WriteLine(z);
                break;

            default:
                Console.WriteLine("Неверный номер задания");
                break;
        }
    }
}