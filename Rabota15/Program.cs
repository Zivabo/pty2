using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер задачи (1-15):");
        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
            case 1:
                {
                    Console.Clear();
                    Console.Write("Введите N: ");
                    int N = int.Parse(Console.ReadLine());
                    int sum = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine($"Сумма чисел от 1 до {N}: {sum}");
                    break;
                }

            case 2:
                {
                    Console.Clear();
                    Console.Write("Введите число: ");
                    int num = int.Parse(Console.ReadLine());
                    bool isPrime = true;
                    if (num <= 1)
                        isPrime = false;
                    else
                    {
                        for (int i = 2; i * i <= num; i++)
                        {
                            if (num % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    Console.WriteLine(isPrime ? "Простое" : "Не простое");
                    break;
                }

            case 3:
                {
                    Console.Clear();
                    Console.Write("Введите число: ");
                    int num = int.Parse(Console.ReadLine());
                    long factorial = 1;
                    for (int i = 1; i <= num; i++)
                    {
                        factorial *= i;
                    }
                    Console.WriteLine($"Факториал {num}: {factorial}");
                    break;
                }

            case 4:
                {
                    Console.Clear();
                    Console.Write("Введите два числа: ");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    while (b != 0)
                    {
                        int temp = b;
                        b = a % b;
                        a = temp;
                    }
                    Console.WriteLine($"НОД: {a}");
                    break;
                }

            case 5:
                {
                    Console.Clear();
                    Console.Write("Введите два числа: ");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    int gcd = a;
                    int temp = b;
                    while (temp != 0)
                    {
                        int t = temp;
                        temp = gcd % temp;
                        gcd = t;
                    }
                    int lcm = a * b / gcd;
                    Console.WriteLine($"НОК: {lcm}");
                    break;
                }

            case 6:
                {
                    Console.Clear();
                    Console.Write("Введите N: ");
                    int N = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Чётные числа от 1 до {N}:");
                    for (int i = 2; i <= N; i += 2)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    break;
                }

            case 7:
                {
                    Console.Clear();
                    Console.Write("Введите N: ");
                    int N = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Нечётные числа от 1 до {N}:");
                    for (int i = 1; i <= N; i += 2)
                    {
                        Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    break;
                }

            case 8:
                {
                    Console.Clear();
                    Console.Write("Введите число: ");
                    int num = int.Parse(Console.ReadLine());
                    int original = num;
                    int reversed = 0;
                    while (num > 0)
                    {
                        reversed = reversed * 10 + num % 10;
                        num /= 10;
                    }
                    Console.WriteLine(original == reversed ? "Палиндром" : "Не палиндром");
                    break;
                }

            case 9:
                {
                    Console.Clear();
                    Console.Write("Введите число: ");
                    int num = int.Parse(Console.ReadLine());
                    int sum = 0;
                    while (num > 0)
                    {
                        sum += num % 10;
                        num /= 10;
                    }
                    Console.WriteLine($"Сумма цифр: {sum}");
                    break;
                }

            case 10:
                {
                    Console.Clear();
                    Console.WriteLine("Таблица умножения на 5:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{i} * 5 = {i * 5}");
                    }
                    break;
                }

            case 11:
                {
                    Console.Clear();
                    Console.Write("Введите число: ");
                    int num = int.Parse(Console.ReadLine());
                    int maxDigit = 0;
                    while (num > 0)
                    {
                        int digit = num % 10;
                        if (digit > maxDigit)
                            maxDigit = digit;
                        num /= 10;
                    }
                    Console.WriteLine($"Максимальная цифра: {maxDigit}");
                    break;
                }

            case 12:
                {
                    Console.Clear();
                    Console.Write("Введите N: ");
                    int N = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Простые числа от 1 до {N}:");
                    for (int i = 2; i <= N; i++)
                    {
                        bool isPrime = true;
                        for (int j = 2; j * j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if (isPrime)
                            Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    break;
                }

            case 13:
                {
                    Console.Clear();
                    Console.Write("Введите N: ");
                    int N = int.Parse(Console.ReadLine());
                    double sum = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        sum += i;
                    }
                    double average = sum / N;
                    Console.WriteLine($"Среднее арифметическое: {average}");
                    break;
                }

            case 14:
                {
                    Console.Clear();
                    Console.Write("Введите N: ");
                    int N = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Числа от 1 до {N}, делящиеся на 3 и на 5:");
                    for (int i = 1; i <= N; i++)
                    {
                        if (i % 3 == 0 && i % 5 == 0)
                            Console.Write(i + " ");
                    }
                    Console.WriteLine();
                    break;
                }

            case 15:
                {
                    Console.Clear();
                    Console.Write("Введите число: ");
                    int num = int.Parse(Console.ReadLine());
                    int count = 0;
                    while (num > 0)
                    {
                        num /= 10;
                        count++;
                    }
                    Console.WriteLine($"Количество цифр: {count}");
                    break;
                }

            default:
                Console.WriteLine("Неверный номер задачи.");
                break;
        }
    }
}