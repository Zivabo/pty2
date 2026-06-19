using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер задания (12–27): ");
        int n = int.Parse(Console.ReadLine());

        switch (n)
        {
            
            case 12:
                Console.Write("Введите A: ");
                int A12 = int.Parse(Console.ReadLine());
                bool isThreeDigit = (A12 >= 100 && A12 <= 999) || (A12 <= -100 && A12 >= -999);
                Console.WriteLine(isThreeDigit);
                break;

            
            case 13:
                Console.Write("Введите A, B, C: ");
                int a13 = int.Parse(Console.ReadLine());
                int b13 = int.Parse(Console.ReadLine());
                int c13 = int.Parse(Console.ReadLine());
                int count13 = 0;
                if (a13 < 45) count13++;
                if (b13 < 45) count13++;
                if (c13 < 45) count13++;
                Console.WriteLine(count13 == 1);
                break;

            
            case 14:
                Console.Write("Введите A: ");
                int A14 = int.Parse(Console.ReadLine());
                bool result14 = (A14 % 3 != 0) && (A14 % 10 == 0);
                Console.WriteLine(result14);
                break;

            
            case 15:
                Console.Write("Введите A: ");
                int A15 = int.Parse(Console.ReadLine());
                bool result15 = (A15 >= -137 && A15 <= -51) || (A15 >= 55 && A15 <= 123);
                Console.WriteLine(result15);
                break;

            
            case 16:
                Console.Write("Введите X, Y, Z: ");
                int X16 = int.Parse(Console.ReadLine());
                int Y16 = int.Parse(Console.ReadLine());
                int Z16 = int.Parse(Console.ReadLine());
                int count16 = 0;
                if (X16 % 5 == 0) count16++;
                if (Y16 % 5 == 0) count16++;
                if (Z16 % 5 == 0) count16++;
                Console.WriteLine(count16 == 1);
                break;

            
            case 17:
                Console.Write("Введите X, Y, Z: ");
                int X17 = int.Parse(Console.ReadLine());
                int Y17 = int.Parse(Console.ReadLine());
                int Z17 = int.Parse(Console.ReadLine());
                Console.WriteLine((X17 > 80) || (Y17 > 80) || (Z17 > 80));
                break;

            
            case 18:
                bool A18 = true, B18 = false, C18 = false;
                Console.WriteLine("a) " + (A18 && (!B18 || C18)));
                Console.WriteLine("б) " + (A18 && (!B18 || C18)));
                Console.WriteLine("в) " + (A18 || (!(B18 && C18))));
                break;

            
            case 19:
                bool A19 = false, B19 = false, C19 = true;
                Console.WriteLine("a) " + (((!A19 || !B19) && !C19)));
                Console.WriteLine("б) " + (((!A19 || !B19) && (A19 || B19))));
                Console.WriteLine("в) " + ((A19 && B19) || (A19 && C19) || !C19));
                break;

            
            case 20:
                Console.WriteLine("a) Область определения: все x");
                Console.WriteLine("б) Область определения: x != 3");
                break;

            
            case 21:
                bool X21 = false, Y21 = false, Z21 = true;
                Console.WriteLine("a) " + ((X21 && !Y21) || Z21));
                Console.WriteLine("б) " + (X21 && (!Y21 || Z21)));
                Console.WriteLine("в) " + (X21 || (!(Y21 || Z21))));
                break;

            
            case 22:
                Console.Write("Введите x: ");
                double x22 = double.Parse(Console.ReadLine());
                Console.Write("Введите y: ");
                double y22 = double.Parse(Console.ReadLine());

                bool a22 = !((x22 <= -5) && (x22 > 5)); 
                bool b22 = (x22 >= -3.5 && y22 <= 8.1 && x22 != 0);

                Console.WriteLine("a) " + a22);
                Console.WriteLine("б) " + b22);
                break;

            
            case 23:
                Console.Write("Введите A: ");
                int A23 = int.Parse(Console.ReadLine());
                bool result23 = !((A23 >= -10 && A23 <= -1) || (A23 >= 2 && A23 <= 15));
                Console.WriteLine(result23);
                break;

            
            case 24:
                Console.Write("Введите A: ");
                int A24 = int.Parse(Console.ReadLine());
                bool result24 = (A24 >= 1000 && A24 <= 9999) && (A24 != 4999);
                Console.WriteLine(result24);
                break;

            
            case 25:
                Console.Write("Введите A, B, C, D: ");
                double A25 = double.Parse(Console.ReadLine());
                double B25 = double.Parse(Console.ReadLine());
                double C25 = double.Parse(Console.ReadLine());
                double D25 = double.Parse(Console.ReadLine());

                bool result25 = (A25 / B25) > (C25 / D25);
                Console.WriteLine(result25);
                break;

            
            case 26:
                Console.Write("Введите x: ");
                int x26 = int.Parse(Console.ReadLine());
                Console.Write("Введите y: ");
                int y26 = int.Parse(Console.ReadLine());

                bool a26 = !((y26 > 0) && (x26 < 5));
                bool b26 = (y26 > 0 && y26 <= 6 && x26 < 7);

                Console.WriteLine("a) " + a26);
                Console.WriteLine("б) " + b26);
                break;

            
            case 27:
                Console.Write("Введите x: ");
                int x27 = int.Parse(Console.ReadLine());

                bool a27 = (x27 > 3) || (x27 < -1);
                Console.WriteLine("a) " + a27);
                break;

            default:
                Console.WriteLine("Нет такого задания.");
                break;
        }
    }
}