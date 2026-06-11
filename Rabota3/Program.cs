using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер варианта (1-30): ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите y: ");
        double y = double.Parse(Console.ReadLine());

        double result = 0;

        switch (n)
        {
            case 1:
                result = 3 * x + 3 / Math.Pow(y, 5) + 4.9;
                break;

            case 2:
                result = Math.Log(Math.Pow(x, 2) + Math.Pow(y, 3)) + Math.Exp(y);
                break;

            case 3:
                result = Math.Sqrt(x + 3.5) + Math.Sqrt(y);
                break;

            case 4:
                result = 9.8 * x * x + 5.52 * Math.Cos(y * y);
                break;

            case 5:
                result = 1.51 * Math.Cos(x * x) + 2 * Math.Pow(x, 3);
                break;

            case 6:
                result = Math.Cos(2.1 * x) + 3.6 * Math.Exp(x);
                break;

            case 7:
                result = Math.Pow(x, 2) + 2.8 * Math.Log(Math.Abs(y)) + 0.55;
                break;

            case 8:
                result = Math.Sqrt(6 * y * y - 0.1 * y + 4);
                break;

            case 9:
                result = Math.Log(y + 0.95) + Math.Sin(Math.Pow(x, 4));
                break;

            case 10:
                result = Math.Exp(y + 7.355) + Math.Sin(x * x);
                break;

            case 11:
                result = 9.756 * y + 2 * Math.Tan(x);
                break;

            case 12:
                result = 7 * x * x + 3 * Math.Sin(Math.Pow(x, 3)) + 9.2;
                break;

            case 13:
                result = Math.Sqrt(3 * y * y + 0.5 * y + 4);
                break;

            case 14:
                result = Math.Sqrt(Math.Sin(x * x) + 6.835 + Math.Exp(y));
                break;

            case 15:
                result = Math.Sin(y * y) - 2.8 * y + Math.Sqrt(Math.Abs(y));
                break;

            case 16:
                result = Math.Sqrt(Math.Cos(4 * y * y)) + 7.151;
                break;

            case 17:
                result = 3 * x * x + Math.Sqrt(y + 1);
                break;

            case 18:
                result = 3 * Math.Pow(y, 2) + Math.Sqrt(Math.Pow(y, 3) + 1);
                break;

            case 19:
                result = Math.Log(Math.Sqrt(Math.Pow(y, 3) + 1.09));
                break;

            case 20:
                result = Math.Exp(x * y) + Math.Sqrt(y);
                break;

            case 21:
                result = Math.Exp(-x * y) + 9.1 * Math.Pow(x, 2);
                break;

            case 22:
                result = Math.Sin(2 * x) * Math.Log(2 * y * y) + Math.Sqrt(x);
                break;

            case 23:
                result = Math.Exp(2 * x) + Math.Sin(x);
                break;

            case 24:
                result = 2 * Math.Sin(0.214 * y * y + 1);
                break;

            case 25:
                result = Math.Exp(2 * y) + Math.Sin(x * x);
                break;

            case 26:
                result = Math.Sin(Math.Pow(x * x + 0.4, 3));
                break;

            case 27:
                result = 1.03 * x + Math.Exp(2 * y) + Math.Abs(x);
                break;

            case 28:
                result = Math.Exp(x + y) + Math.Sqrt(6.4 * y);
                break;

            case 29:
                result = 3 * y * y + Math.Sqrt(Math.Abs(y) + 1);
                break;

            case 30:
                result = Math.Exp(x + y) + 7.2 * Math.Sin(x);
                break;

            default:
                Console.WriteLine("Нет такого варианта");
                return;
        }

        Console.WriteLine($"Результат: {result}");
    }
}