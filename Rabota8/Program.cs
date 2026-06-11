using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер варианта (1-30): ");
        int n = int.Parse(Console.ReadLine());

       
        double x = 0, y = 0, a = 0, b = 0, c = 0, d = 0, m = 0;

        Console.WriteLine("Введите x, y, a, b, c, d, m (через Enter):");
        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());
        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());
        d = double.Parse(Console.ReadLine());
        m = double.Parse(Console.ReadLine());

        int t = 1;
        int h = 1;

        double result = 0;

        switch (n)
        {
            case 1:
                result = (Math.Sqrt(Math.Exp(-c) - Math.Pow(Math.Cos(x * x * a), 3))
                         + Math.Atan(a - Math.Pow(x, 3)))
                         / (Math.Exp(Math.Sqrt(Math.Abs(a + x * c))));
                break;

            case 2:
                result = Math.Pow(1 / Math.Tan(c), 2) + (2 * x * x + 5) / Math.Sqrt(c + t);
                break;

            case 3:
                result = (Math.Tan(Math.Pow(y, 3) - Math.Pow(b, 4)) + Math.Pow(h, 2)) /
                         (Math.Pow(Math.Sin(1), 3) + y);
                break;

            case 4:
                result = (Math.Sqrt(Math.Pow(2 + y, 2)) + Math.Sqrt(Math.Sin(y + 5))) /
                         (Math.Log(x + 1) - Math.Pow(y, 3));
                break;

            case 5:
                result = (Math.Tan(Math.Pow(x, 4) - 6) - Math.Pow(Math.Cos(1 + x * y), 3)) /
                         (Math.Pow(Math.Cos(x), 4) * Math.Pow(c, 2));
                break;

            case 6:
                result = (Math.Sqrt(x + b - a) + Math.Log(y)) / Math.Atan(b + a);
                break;

            case 7:
                result = (Math.Cos(Math.Pow(x, 3) + 6) - Math.Sin(y - a)) /
                         (Math.Log(Math.Pow(x, 4)) - 2 * Math.Pow(Math.Sin(x), 5));
                break;

            case 8:
                result = (Math.Pow(a, 5) + Math.Pow(Math.Sin(y - c), 4)) /
                         (Math.Pow(Math.Sin(x + y), 3) + Math.Abs(x - y));
                break;

            case 9:
                result = (Math.Pow(Math.Cos(y), 3) + 2 * d) /
                         (Math.Exp(y) + Math.Log(Math.Pow(Math.Sin(x), 2) + 7.4));
                break;

            case 10:
                result = (Math.Exp(x) + Math.Pow(Math.Cos(x - 4), 2)) /
                         (Math.Atan(x) + 5.2 * y);
                break;

            case 11:
                result = (2.33 * Math.Log(Math.Sqrt(1 + Math.Pow(Math.Cos(y), 2)))) /
                         (Math.Exp(y) + Math.Pow(Math.Sin(x), 2));
                break;

            case 12:
                result = (Math.Pow(Math.Cos(Math.Abs(y + x)), 3) - (x + y)) /
                         (Math.Pow(Math.Atan(x + a), 4) * Math.Pow(x, 5));
                break;

            case 13:
                result = a / (x - a) + (Math.Pow(b, 4) + Math.Pow(Math.Cos(x), 3)) /
                         (Math.Pow(Math.Log(a), 3) + 4.5);
                break;

            case 14:
                result = (Math.Sin(Math.Pow(x, 2) + 4) + 4.3) /
                         Math.Pow(Math.Sin(x), 3);
                break;

            case 15:
                result = (Math.Pow(m, 2) + 2.8 * m + 0.355) /
                         (Math.Cos(2 * y) + 3.6);
                break;

            case 16:
                result = (Math.Pow(Math.Sin(x), 3) + Math.Log(2 * y + 3 * x)) /
                         (Math.Pow(x, 2) + Math.Sqrt(x));
                break;

            case 17:
                result = (Math.Sqrt(x + b - a) + Math.Log(y)) /
                         Math.Atan(b + a);
                break;

            case 18:
                result = (4.35 * Math.Pow(y, 3) + 2 * Math.Log(1)) /
                         Math.Sqrt(Math.Cos(2 * y) + 4.35);
                break;

            case 19:
                result = (Math.Pow(x, a) - a * Math.Sqrt(6) - Math.Cos(3 * a * b)) /
                         (Math.Pow(Math.Sin(a * Math.Asin(x) + Math.Log(y)), 2));
                break;

            case 20:
                result = (Math.Pow(Math.Tan(y), 3) + Math.Pow(Math.Sin(x), 5) * Math.Sqrt(b - c)) /
                         Math.Sqrt(a - b + c);
                break;

            case 21:
                result = Math.Pow(1 + Math.Sqrt(x), 1.0 / 5) /
                         (Math.Exp(x) + Math.Pow(a, 5) * Math.Atan(x));
                break;

            case 22:
                result = Math.Cos(Math.Pow(x, 2) + 2) +
                         (3.5 * Math.Pow(x, 2) + 1) / Math.Pow(Math.Cos(y), 2);
                break;

            case 23:
                result = Math.Sqrt(Math.Abs(x)) + Math.Pow(Math.Cos(x), 5) + Math.Pow(1, 4);
                result /= (Math.Log(x) - Math.Asin(b * x - a));
                break;

            case 24:
                result = (Math.Pow(Math.Cos(b * x), 5) -
                         (Math.Pow(Math.Sin(a), 2) + Math.Cos(Math.Pow(x, 2) + Math.Pow(1, 5) - Math.Pow(a, 2))))
                         / (Math.Asin(Math.Pow(a, 2)) + Math.Acos(Math.Pow(x, 2) - Math.Pow(a, 2)));
                break;

            case 25:
                result = (Math.Pow(1 / Math.Tan(a), 3) * Math.Pow(a, 3) +
                         Math.Pow(Math.Atan(a), 2)) /
                         Math.Sqrt(Math.Pow(y, x));
                break;

            case 26:
                result = (Math.Log(Math.Pow(x, 3) + y) - Math.Pow(y, 4)) /
                         (Math.Exp(y) + 5.4 * Math.Pow(x, 3));
                break;

            case 27:
                result = (Math.Pow(a, 5) + Math.Acos(a + Math.Pow(x, 3)) -
                         Math.Pow(Math.Sin(y - c), 4)) /
                         (Math.Pow(Math.Sin(x + y), 3) + Math.Abs(x - y));
                break;

            case 28:
                result = (Math.Tan(Math.Pow(x, 4) - 6) -
                         Math.Pow(Math.Cos(1 + Math.Pow(x, 3) * y), 3)) /
                         (Math.Pow(Math.Cos(x), 2) * Math.Pow(c, 2));
                break;

            case 29:
                result = (Math.Pow(Math.Cos(y), 2) + 2.4 * d) /
                         (Math.Exp(y) + Math.Log(Math.Pow(Math.Sin(x), 2) + 6));
                break;

            case 30:
                result = (Math.Sqrt(Math.Pow(3 + x, 6)) - Math.Log(x)) /
                         (Math.Exp(0) + Math.Asin(6 * Math.Pow(x, 2)));
                break;

            default:
                Console.WriteLine("Нет такого варианта");
                return;
        }

        Console.WriteLine($"Результат = {result}");
        Console.ReadKey();
    }
}