using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите номер задачи (1-10):");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("Задача 1");
                Console.WriteLine("Введите A и B:");
                int A1 = int.Parse(Console.ReadLine());
                int B1 = int.Parse(Console.ReadLine());
                bool task1a = (A1 % 2 == 0 && B1 % 2 != 0) || (A1 % 2 != 0 && B1 % 2 == 0);
                Console.WriteLine($"1a) Только одно из чисел четное: {task1a}");

                Console.WriteLine("Введите A, B, C:");
                int A1b = int.Parse(Console.ReadLine());
                int B1b = int.Parse(Console.ReadLine());
                int C1b = int.Parse(Console.ReadLine());
                bool task1b = (A1b % 3 == 0) && (B1b % 3 == 0) && (C1b % 3 == 0);
                Console.WriteLine($"1b) Каждое кратно трем: {task1b}");
                break;

            case 2:
                Console.WriteLine("Задача 2");
                Console.WriteLine("Введите N:");
                int N2 = int.Parse(Console.ReadLine());
                bool task2a = (N2 % 4 == 0) || (N2 % 7 == 0);
                Console.WriteLine($"2a) N кратно 4 или 7: {task2a}");

                bool task2b = (N2 % 5 == 0) && (N2 % 10 != 0);
                Console.WriteLine($"2b) N кратно 5 и не оканчивается нулем: {task2b}");
                break;

            case 3:
                Console.WriteLine("Задача 3");
                Console.WriteLine("Введите n, m, k, l:");
                int n3 = int.Parse(Console.ReadLine());
                int m3 = int.Parse(Console.ReadLine());
                int k3 = int.Parse(Console.ReadLine());
                int l3 = int.Parse(Console.ReadLine());
                bool task3 = (n3 + m3 > k3) && (!(n3 > k3) || (m3 < l3));
                Console.WriteLine($"3) Условие выполнено: {task3}");
                break;

            case 4:
                Console.WriteLine("Задача 4");
                Console.WriteLine("Введите N:");
                int N4 = int.Parse(Console.ReadLine());
                bool task4 = (!(N4 % 3 == 0) || (N4 % 9 != 0)) && (!(N4 % 4 == 0) || (N4 % 5 == 0 && N4 % 24 == 0));
                Console.WriteLine($"4) Условие выполнено: {task4}");
                break;

            case 5:
                Console.WriteLine("Задача 5");
                Console.WriteLine("Введите k, l, m, n:");
                int k5 = int.Parse(Console.ReadLine());
                int l5 = int.Parse(Console.ReadLine());
                int m5 = int.Parse(Console.ReadLine());
                int n5 = int.Parse(Console.ReadLine());
                bool task5 = (n5 > 1 || (m5 == l5 + k5 && k5 == 0)) && (!(n5 > 2) || (m5 * m5 > l5 * l5));
                Console.WriteLine($"5) Условие выполнено: {task5}");
                break;

            case 6:
                Console.WriteLine("Задача 6");
                Console.WriteLine("Введите сумму вклада:");
                double sum = double.Parse(Console.ReadLine());
                double rate;
                if (sum < 50000)
                    rate = 0.16;
                else if (sum <= 100000)
                    rate = 0.18;
                else
                    rate = 0.18;
                double payout = sum + sum * rate;
                Console.WriteLine($"Сумма выплаты: {payout}");
                break;

            case 7:
                Console.WriteLine("Задача 7");
                Console.WriteLine("Введите N:");
                int N7 = int.Parse(Console.ReadLine());
                bool task7 = (N7 % 2 == 0) && (N7 % 7 == 0) && (N7 % 11 != 0) && (N7 % 13 != 0);
                Console.WriteLine($"7) Условие выполнено: {task7}");
                break;

            case 8:
                Console.WriteLine("Задача 8");
                Console.WriteLine("Введите N:");
                int N8 = int.Parse(Console.ReadLine());
                bool task8 = (N8 % 3 != 0) && (N8 % 7 == 0) && (N8 % 10 == 0);
                Console.WriteLine($"8) Условие выполнено: {task8}");
                break;

            case 9:
                Console.WriteLine("Задача 9");
                Console.WriteLine("Введите k, l, m:");
                int k9 = int.Parse(Console.ReadLine());
                int l9 = int.Parse(Console.ReadLine());
                int m9 = int.Parse(Console.ReadLine());
                bool task9 = (k9 == 0 && l9 > m9) || (k9 < 0 && 2 * l9 - 3 * m9 < m9);
                Console.WriteLine($"9) Условие выполнено: {task9}");
                break;

            case 10:
                Console.WriteLine("Задача 10");
                Console.WriteLine("Введите N:");
                int N10 = int.Parse(Console.ReadLine());
                bool task10 = (N10 % 2 == 0) &&
                              (N10 % 3 != 0) &&
                              (N10 % 7 == 0) &&
                              (!(N10 % 5 != 0) || (N10 % 4 == 0)) &&
                              (!(N10 % 8 == 0) || (N10 % 11 == 0));
                Console.WriteLine($"10) Условие выполнено: {task10}");
                break;

            default:
                Console.WriteLine("Ошибка: введите номер задачи от 1 до 10");
                break;
        }

        Console.WriteLine("Готово!");
    }
}