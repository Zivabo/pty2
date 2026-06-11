using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер варианта (1-30): ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите x, y, a, b, c, d, t, k, p, m, r:");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double t = double.Parse(Console.ReadLine());
        double k = double.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());
        double r = double.Parse(Console.ReadLine());

        double result = 0;

        switch (n)
        {
            case 1:
                result = (Math.Exp(x) + Math.Sin(t)) /
                         (Math.Log(3.8 * y + 7));
                break;

            case 2:
                result = Math.Log(d) + (3.5 * d * d + 1) /
                         Math.Cos(2 * y);
                break;

            case 3:
                result = Math.Log(x - y) + Math.Pow(y, 4);
                result /= (Math.Exp(y) + 2.355 * k * k);
                break;

            case 4:
                result = (9.33 * Math.Pow(1, 3) + Math.Sqrt(1)) /
                         (Math.Log(y + 3.5) + Math.Sqrt(y));
                break;

            case 5:
                result = (7.8 * a * a + 3.52 * t) /
                         (Math.Log(a + 2 * y) + Math.Exp(y));
                break;

            case 6:
                result = (0.81 * Math.Cos(t)) /
                         (Math.Log(y) + 2 * Math.Pow(1, 3));
                break;

            case 7:
                result = (m * m + 2.8 * m + 0.355) /
                         (Math.Cos(2 * y) + 3.6);
                break;

            case 8:
                result = (2.37 * Math.Sin(t + 1)) /
                         Math.Sqrt(4 * y * y - 0.1 * y + 5);
                break;

            case 9:
                result = (y + 2 * 1) /
                         Math.Log(y + 0.75);
                break;

            case 10:
                result = (2 * t + y * Math.Cos(t)) /
                         Math.Sqrt(y + 4.831);
                break;

            case 11:
                result = y * y + (0.5 * n + 4.8) /
                         Math.Sin(y);
                break;

            case 12:
                result = (Math.Sin(Math.Pow(2 * t + 1, 2)) + 0.3) /
                         Math.Log(t + y);
                break;

            case 13:
                result = (Math.Sin(2 * y + 1) + Math.Pow(1, 2)) /
                         (Math.Exp(y) + y);
                break;

            case 14:
                result = (Math.Exp(y + 2.5) + 7.1 * Math.Pow(1, 3)) /
                         Math.Log(Math.Sqrt(y) + 0.04 * 1);
                break;

            case 15:
                result = (2 * Math.Sin(0.354 * y + 1)) /
                         Math.Log(y + 2 *1);
                break;

            case 16:
                result = (4 * Math.Pow(t, 3) + b * r) /
                         (Math.Exp(r) + 7.2 * Math.Sin(r));
                break;

            case 17:
                result = (Math.Pow(y, 2) - 0.8 * y + Math.Sqrt(y)) /
                         (23 * Math.Pow(t, 3) + Math.Cos(t));
                break;

            case 18:
                result = Math.Sqrt(Math.Pow(Math.Sin(y), 2) + 6.835) /
                         Math.Log(y + k) + 3 * Math.Pow(y, 3);
                break;

            case 19:
                result = Math.Log(0.7 * y + 2 * 1) /
                         Math.Sqrt(3 * Math.Pow(y, 2) + 0.5 * y + 4);
                break;

            case 20:
                result = (2 * t * t + 3 * t + 7.2) /
                         (Math.Log(y) + Math.Exp(y));
                break;

            case 21:
                result = Math.Log(k + 2.6 * p * Math.Sin(k)) /
                         (x - Math.Pow(d, 3));
                break;

            case 22:
                result = (4.35 * Math.Pow(y, 3) + 2 * Math.Log(t)) /
                         Math.Sqrt(Math.Cos(2 * y) + 4.35);
                break;

            case 23:
                result = (Math.Pow(Math.Sin(y), 2) + 0.3 * d) /
                         (Math.Exp(y) + Math.Log(d));
                break;

            case 24:
                result = Math.Log(2 * k + 4.3) /
                         (Math.Exp(y) + Math.Sqrt(y));
                break;

            case 25:
                result = Math.Pow(Math.Cos(c), 2) +
                         (3 * t * t + 4) / Math.Sqrt(c + t);
                break;

            case 26:
                result = Math.Sin(2 * t) /
                         Math.Log(2 * y + t);
                break;

            case 27:
                result = Math.Pow(Math.Sin(p + 0.4), 2) /
                         (y * y + 7.325 * p);
                break;

            case 28:
                result = (0.004 * 1 + Math.Exp(y)) /
                         Math.Exp(y / 2);
                break;

            case 29:
                result = (0.355 * Math.Pow(1, 2) - 4.355) /
                         (Math.Exp(y + 1) + Math.Sqrt(2.7 * y));
                break;

            case 30:
                result = (3 * Math.Pow(y, 2) + Math.Sqrt(y + 1)) /
                         Math.Log(p + y) + Math.Exp(p);
                break;

            default:
                Console.WriteLine("Нет такого варианта");
                return;
        }

        Console.WriteLine($"Результат = {result}");
        Console.ReadKey();
    }
}