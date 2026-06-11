using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер задачи (1-29):");
        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
            case 1:
                {
                    Console.Clear();
                    Console.WriteLine("Введите A и B (A < B):");
                    int A = int.Parse(Console.ReadLine());
                    int B = int.Parse(Console.ReadLine());
                    int count = 0;
                    for (int i = A; i <= B; i++)
                    {
                        Console.Write(i + " ");
                        count++;
                    }
                    Console.WriteLine($"\nКоличество: {count}");
                    break;
                }

            case 2:
                {
                    Console.Clear();
                    Console.WriteLine("Введите A и B (A < B):");
                    int A = int.Parse(Console.ReadLine());
                    int B = int.Parse(Console.ReadLine());
                    int count = 0;
                    for (int i = B - 1; i > A; i--)
                    {
                        Console.Write(i + " ");
                        count++;
                    }
                    Console.WriteLine($"\nКоличество: {count}");
                    break;
                }

            case 3:
                {
                    Console.Clear();
                    Console.WriteLine("Введите A и N:");
                    int A = int.Parse(Console.ReadLine());
                    int N = int.Parse(Console.ReadLine());
                    int result = 1;
                    for (int i = 0; i < N; i++)
                    {
                        result *= A;
                    }
                    Console.WriteLine($"Результат: {result}");
                    break;
                }

            case 4:
                {
                    Console.Clear();
                    Console.WriteLine("Введите A и N:");
                    int A = int.Parse(Console.ReadLine());
                    int N = int.Parse(Console.ReadLine());
                    int result = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        result += A;
                    }
                    Console.WriteLine($"Сумма: {result}");
                    break;
                }

            case 5:
                {
                    Console.Clear();
                    Console.WriteLine("Введите A и N:");
                    int A = int.Parse(Console.ReadLine());
                    int N = int.Parse(Console.ReadLine());
                    int result = 0;
                    for (int i = 0; i <= N; i++)
                    {
                        result += (int)Math.Pow(A, i);
                    }
                    Console.WriteLine($"Сумма: {result}");
                    break;
                }

            case 6:
                {
                    Console.Clear();
                    Console.WriteLine("Введите N:");
                    int N = int.Parse(Console.ReadLine());
                    int K = 1;
                    while (3 * K <= N)
                    {
                        K++;
                    }
                    Console.WriteLine($"K: {K}");
                    break;
                }

            case 7:
                {
                    Console.Clear();
                    Console.WriteLine("Введите N:");
                    int N = int.Parse(Console.ReadLine());
                    int K = 1;
                    while (3 * (K + 1) < N)
                    {
                        K++;
                    }
                    Console.WriteLine($"K: {K}");
                    break;
                }

            case 8:
                {
                    Console.Clear();
                    Console.WriteLine("Введите A:");
                    double A_double = double.Parse(Console.ReadLine());
                    double sum = 0;
                    int N = 0;
                    while (sum <= A_double)
                    {
                        N++;
                        sum += 1.0 / N;
                    }
                    Console.WriteLine($"N: {N}");
                    break;
                }

            case 9:
                {
                    Console.Clear();
                    Console.WriteLine("Введите N:");
                    int N = int.Parse(Console.ReadLine());
                    int result = 1;
                    for (int i = 1; i <= N; i++)
                    {
                        result *= i;
                    }
                    Console.WriteLine($"Произведение: {result}");
                    break;
                }

            case 10:
                {
                    Console.Clear();
                    Console.WriteLine("Введите N:");
                    int N = int.Parse(Console.ReadLine());
                    double product = 2.0;
                    for (int i = 2; i <= N; i++)
                    {
                        product *= (1.0 / i);
                    }
                    Console.WriteLine($"Произведение: {product}");
                    break;
                }

            case 11:
                {
                    Console.Clear();
                    Console.WriteLine("Введите X и N:");
                    double X = double.Parse(Console.ReadLine());
                    int N = int.Parse(Console.ReadLine());
                    double sum11 = 1 + X + Math.Pow(X, 2) / 2 + Math.Pow(X, 3) / N;
                    Console.WriteLine($"Сумма: {sum11}");
                    break;
                }

            case 12:
                {
                    Console.Clear();
                    Console.WriteLine("Введите X и N:");
                    double X = double.Parse(Console.ReadLine());
                    int N = int.Parse(Console.ReadLine());
                    double term1 = Math.Pow(X, 3) / 3;
                    double term2 = Math.Pow(X, 5) / 5;
                    double term3 = Math.Pow(-1, N) * Math.Pow(X, 2 * N + 1) / (2 * N + 1);
                    double sum12 = term1 + term2 - term3;
                    Console.WriteLine($"Сумма: {sum12}");
                    break;
                }

            case 13:
                {
                    Console.Clear();
                    Console.WriteLine("Введите X и N:");
                    double X = double.Parse(Console.ReadLine());
                    int N = int.Parse(Console.ReadLine());
                    double term1 = Math.Pow(X, 2) / 2;
                    double term2 = Math.Pow(X, 4) / 4;
                    double term3 = Math.Pow(-1, N) * Math.Pow(X, 2 * N) / (2 * N);
                    double sum13 = term1 + term2 - term3;
                    Console.WriteLine($"Сумма: {sum13}");
                    break;
                }

            case 14:
                {
                    Console.Clear();
                    Console.WriteLine("Введите X и N:");
                    double X = double.Parse(Console.ReadLine());
                    int N = int.Parse(Console.ReadLine());
                    double term1 = X;
                    double term2 = Math.Pow(X, 2) / 2;
                    double term3 = Math.Pow(X, 3) / 3;
                    double term4 = Math.Pow(-1, N) * N * Math.Pow(X, N) / N;
                    double sum14 = term1 - term2 + term3 - term4;
                    Console.WriteLine($"Сумма: {sum14}");
                    break;
                }

            case 15:
                {
                    Console.Write("X (|X|<1): ");
                    double X = double.Parse(Console.ReadLine());
                    Console.Write("N: ");
                    int N = int.Parse(Console.ReadLine());
                    double sum = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        double term = Math.Pow(X, 2 * i - 1) / (2 * i - 1);
                        if (i % 2 == 0)
                            sum -= term;
                        else
                            sum += term;
                    }
                    Console.WriteLine("arctg(X) ≈ " + sum);
                    break;
                }

            case 16:
                {
                    Console.Write("A: ");
                    double A = double.Parse(Console.ReadLine());
                    Console.Write("B: ");
                    double B = double.Parse(Console.ReadLine());
                    Console.Write("N: ");
                    int N = int.Parse(Console.ReadLine());
                    double H = (B - A) / N;
                    Console.WriteLine("H = " + H);
                    for (int i = 0; i <= N; i++)
                        Console.WriteLine(A + i * H);
                    break;
                }

            case 17:
                {
                    Console.Write("A: ");
                    double A = double.Parse(Console.ReadLine());
                    Console.Write("B: ");
                    double B = double.Parse(Console.ReadLine());
                    Console.Write("N: ");
                    int N = int.Parse(Console.ReadLine());
                    double H = (B - A) / N;
                    for (int i = 0; i <= N; i++)
                    {
                        double x = A + i * H;
                        double F = 1 - Math.Sin(x);
                        Console.WriteLine(F);
                    }
                    break;
                }

            case 18:
                {
                    Console.Write("D: ");
                    double D = double.Parse(Console.ReadLine());
                    double A_prev = 2;
                    double A_curr = 2 + 1.0 / A_prev;
                    int k = 2;
                    while (Math.Abs(A_curr - A_prev) >= D)
                    {
                        A_prev = A_curr;
                        A_curr = 2 + 1.0 / A_prev;
                        k++;
                    }
                    Console.WriteLine("K: " + k);
                    Console.WriteLine("A(k-1): " + A_prev);
                    Console.WriteLine("A(k): " + A_curr);
                    break;
                }

            case 19:
                {
                    Console.Write("D: ");
                    double D = double.Parse(Console.ReadLine());
                    double A1 = 1;
                    double A2 = 2;
                    int k = 2;
                    while (Math.Abs(A2 - A1) >= D)
                    {
                        double next = (A1 + A2) / 2;
                        A1 = A2;
                        A2 = next;
                        k++;
                    }
                    Console.WriteLine("K: " + k);
                    Console.WriteLine("A(k-1): " + A1);
                    Console.WriteLine("A(k): " + A2);
                    break;
                }

            case 20:
                {
                    Console.Write("N: ");
                    int N = int.Parse(Console.ReadLine());
                    for (int i = 10; i <= N; i++)
                        if (i % 2 != 0 && i % 5 == 0)
                            Console.WriteLine(i);
                    break;
                }

            case 21:
                {
                    for (int i = 11; i <= 99; i++)
                        Console.WriteLine(i * i);
                    break;
                }

            case 22:
                {
                    double x;
                    Console.WriteLine("Вводите x (0 для выхода):");
                    while (true)
                    {
                        x = double.Parse(Console.ReadLine());
                        if (x == 0) break;
                        double r;
                        if (0 < x && x < 3.14)
                            r = Math.Sin(x);
                        else if (-3.14 <= x && x < 0)
                            r = Math.Pow(x, 3);
                        else if (x < -3.14 || x > 3.14)
                            r = Math.Pow(x, 2);
                        else
                            r = 0;
                        Console.WriteLine("r = " + r);
                    }
                    break;
                }

            case 23:
                {
                    Console.Write("n: ");
                    int n = int.Parse(Console.ReadLine());
                    double fact = 1;
                    double pow = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        fact *= i;
                        pow *= 2;
                    }
                    Console.WriteLine("n! = " + fact);
                    Console.WriteLine("2^n = " + pow);
                    break;
                }

            case 24:
                {
                    Console.Write("N: ");
                    int N = int.Parse(Console.ReadLine());
                    for (int i = 10; i <= N; i++)
                    {
                        int max = 0;
                        int temp = i;
                        while (temp > 0)
                        {
                            int digit = temp % 10;
                            if (digit > max) max = digit;
                            temp /= 10;
                        }
                        Console.WriteLine($"{i} -> {max}");
                    }
                    break;
                }

            case 25:
                {
                    Console.Write("N: ");
                    int N = int.Parse(Console.ReadLine());
                    for (int i = 10; i <= N; i++)
                    {
                        int temp = i;
                        int sum = 0;
                        while (temp > 0)
                        {
                            sum += temp % 10;
                            temp /= 10;
                        }
                        int first = i;
                        while (first >= 10)
                            first /= 10;
                        Console.WriteLine($"{i} -> первая: {first}, сумма: {sum}");
                    }
                    break;
                }

            case 26:
                {
                    Console.Write("Число: ");
                    int n = int.Parse(Console.ReadLine());
                    int original = n;
                    int reversed = 0;
                    while (n > 0)
                    {
                        reversed = reversed * 10 + n % 10;
                        n /= 10;
                    }
                    if (original == reversed)
                        Console.WriteLine("Палиндром");
                    else
                        Console.WriteLine("Перевертыш");
                    break;
                }

            case 27:
                {
                    for (int i = 12; i <= 80; i++)
                        Console.WriteLine(i * i);
                    break;
                }

            case 28:
                {
                    for (int i = 22; i <= 88; i++)
                        Console.WriteLine(i * i - (i - 1) * (i - 1));
                    break;
                }

            case 29:
                {
                    Console.Write("A: ");
                    double A = double.Parse(Console.ReadLine());
                    Console.Write("N: ");
                    int N = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= N; i++)
                        Console.WriteLine(A * A - i * i);
                    break;
                }

            default:
                Console.WriteLine("Неверный номер задачи.");
                break;
        }
    }
}