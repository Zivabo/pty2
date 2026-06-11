using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер задания (1–27): ");
        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
            case 1:
                int A1 = int.Parse(Console.ReadLine());
                int B1 = int.Parse(Console.ReadLine());
                int C1 = int.Parse(Console.ReadLine());
                Console.WriteLine((A1 % 2 == 0) ^ (B1 % 2 == 0));
                Console.WriteLine(A1 % 3 == 0 && B1 % 3 == 0 && C1 % 3 == 0);
                break;

            case 2:
                int N2 = int.Parse(Console.ReadLine());
                Console.WriteLine(N2 % 4 == 0 || N2 % 7 == 0);
                Console.WriteLine(N2 % 5 == 0 && N2 % 10 != 0);
                break;

            case 3:
                int n = int.Parse(Console.ReadLine());
                int m = int.Parse(Console.ReadLine());
                int k = int.Parse(Console.ReadLine());
                int l = int.Parse(Console.ReadLine());
                Console.WriteLine((n + m > k) && (!(n > k) || m < l));
                break;

            case 4:
                int N4 = int.Parse(Console.ReadLine());
                Console.WriteLine((N4 % 3 == 0 && N4 % 9 != 0) ||
                                  (N4 % 4 == 0 && N4 % 5 == 0 && N4 % 24 == 0));
                break;

            case 5:
                int k5 = int.Parse(Console.ReadLine());
                int l5 = int.Parse(Console.ReadLine());
                int n5 = int.Parse(Console.ReadLine());
                int m5 = int.Parse(Console.ReadLine());
                Console.WriteLine((n5 > l5 && m5 <= l5 && k5 == 0) ||
                                  (n5 > 2 && m5 > 2));
                break;

            case 6:
                int sum = int.Parse(Console.ReadLine());
                if (sum <= 50000)
                    Console.WriteLine(sum * 1.16);
                else if (sum <= 100000)
                    Console.WriteLine(sum * 1.18);
                break;

            case 7:
                int N7 = int.Parse(Console.ReadLine());
                Console.WriteLine(N7 % 2 == 0 && N7 % 7 == 0 && N7 % 11 != 0 && N7 % 13 != 0);
                break;

            case 8:
                int N8 = int.Parse(Console.ReadLine());
                Console.WriteLine(N8 % 3 != 0 && N8 % 7 == 0 && N8 % 10 == 0);
                break;

            case 9:
                int k9 = int.Parse(Console.ReadLine());
                int l9 = int.Parse(Console.ReadLine());
                int n9 = int.Parse(Console.ReadLine());
                int m9 = int.Parse(Console.ReadLine());
                Console.WriteLine((k9 == 0 && l9 > m9) ||
                                  (k9 != 0 && 2 * l9 - 3 * n9 < m9));
                break;

            case 10:
                int N10 = int.Parse(Console.ReadLine());
                Console.WriteLine(N10 % 2 == 0 &&
                                  N10 % 3 != 0 &&
                                  N10 % 7 == 0 &&
                                  (N10 % 5 != 0 || N10 % 4 != 0) &&
                                  (N10 % 8 == 0 && N10 % 11 == 0));
                break;

            case 11:
                int x = 2, y = 1;
                Console.WriteLine((x * x >= 0) || (y < x));
                break;

            case 12:
                int A12 = int.Parse(Console.ReadLine());
                Console.WriteLine(A12 >= 100 && A12 <= 999);
                break;

            case 13:
                int A13 = int.Parse(Console.ReadLine());
                int B13 = int.Parse(Console.ReadLine());
                int C13 = int.Parse(Console.ReadLine());
                Console.WriteLine(
                    ((A13 < 45) ? 1 : 0) +
                    ((B13 < 45) ? 1 : 0) +
                    ((C13 < 45) ? 1 : 0) == 1
                );
                break;

            case 14:
                int A14 = int.Parse(Console.ReadLine());
                Console.WriteLine(A14 % 3 != 0 && A14 % 10 == 0);
                break;

            case 15:

                int A15 = int.Parse(Console.ReadLine());
                Console.WriteLine((A15 >= -137 && A15 <= -51) ||
                                  (A15 >= 55 && A15 <= 123));
                break;

            case 16:
                int X16 = int.Parse(Console.ReadLine());
                int Y16 = int.Parse(Console.ReadLine());
                int Z16 = int.Parse(Console.ReadLine());
                Console.WriteLine(
                    (X16 % 5 == 0 ? 1 : 0) +
                    (Y16 % 5 == 0 ? 1 : 0) +
                    (Z16 % 5 == 0 ? 1 : 0) == 1
                );
                break;

            case 17:
                int X17 = int.Parse(Console.ReadLine());
                int Y17 = int.Parse(Console.ReadLine());
                int Z17 = int.Parse(Console.ReadLine());
                Console.WriteLine(X17 > 80 || Y17 > 80 || Z17 > 80);
                break;

            case 18:
                bool A = true, B = false, C = false;
                Console.WriteLine(!A || !B || C);
                Console.WriteLine(A && (!B || C));
                Console.WriteLine(A || (!B && !C));
                break;

            case 19:
                bool A19 = false, B19 = false, C19 = true;
                Console.WriteLine((!A19 || !B19) && !C19);
                Console.WriteLine((!A19 || !B19) && (A19 || B19));
                Console.WriteLine(A19 || B19 || (A19 && C19) || !C19);
                break;

            case 20:
                Console.WriteLine("y=1-cos(3x) определена при всех x");
                Console.WriteLine("y=x/(x-3)^2, x!=3");
                break;

            case 21:
                bool X21 = false, Y21 = false, Z21 = true;
                Console.WriteLine((X21 && !Y21) || Z21);
                Console.WriteLine(X21 && (!Y21 || Z21));
                Console.WriteLine(X21 || (!(Y21 || Z21)));
                break;

            case 22:
                int x22 = int.Parse(Console.ReadLine());
                Console.WriteLine(!(x22 <= -5 && x22 > 5));
                Console.WriteLine(x22 >= -3.5 && x22 <= 8.1 && x22 != 0);
                break;

            case 23:
                int A23 = int.Parse(Console.ReadLine());
                Console.WriteLine(!((A23 >= -10 && A23 <= -1) ||
                                    (A23 >= 2 && A23 <= 15)));
                break;

            case 24:
                int A24 = int.Parse(Console.ReadLine());
                Console.WriteLine(A24 >= 1000 && A24 <= 9999 && A24 != 4999);
                break;

            case 25:
                double A25 = double.Parse(Console.ReadLine());
                double B25 = double.Parse(Console.ReadLine());
                double C25 = double.Parse(Console.ReadLine());
                double D25 = double.Parse(Console.ReadLine());
                Console.WriteLine(A25 / B25 > C25 / D25);
                break;

            case 26:
                int x26 = int.Parse(Console.ReadLine());
                Console.WriteLine(!(x26 > 0 && x26 < 5));
                Console.WriteLine(x26 >= 0 && x26 <= 6 && x26 != 7);
                break;

            case 27:
                int x27 = int.Parse(Console.ReadLine());
                Console.WriteLine(x27 > 3 || x27 <= -1);
                break;

            default:
                Console.WriteLine("Неверный номер задания");
                break;
        }
    }
}
