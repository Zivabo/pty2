using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool A = true, B = false, C = false;
        Console.WriteLine("Задание 1");
        if (((A || !A && B) || C)) Console.WriteLine("1"); else Console.WriteLine("0");
        if ((!A || A && (B || C))) Console.WriteLine("1"); else Console.WriteLine("0");
        if (((A || B && !C) && C)) Console.WriteLine("1"); else Console.WriteLine("0");
        Console.WriteLine();

        
        bool X = false, Y = true, Z = false;
        Console.WriteLine("Задание 2");
        if ((X && (!Z || Y) || !Z)) Console.WriteLine("1"); else Console.WriteLine("0");
        if ((!X || X && (Y || Z))) Console.WriteLine("1"); else Console.WriteLine("0");
        if (((X || Y && !Z) && Z)) Console.WriteLine("1"); else Console.WriteLine("0");
        Console.WriteLine();

        
        Console.WriteLine("Задание 3");
        int x3 = 1, y3 = 2, z3 = 0;
        if (((x3 != 0) || (y3 != 0) || (z3 != 0)) && (y3 > x3)) Console.WriteLine("1"); else Console.WriteLine("0");
        if ((x3 >= 2) || (y3 * y3 == 5)) Console.WriteLine("1"); else Console.WriteLine("0");
        if ((x3 == 0) || (y3 - 2 != 0)) Console.WriteLine("1"); else Console.WriteLine("0");
        Console.WriteLine();

        
        Console.WriteLine("Задание 4");
        int A4 = 6;
        if ((A4 % 2 == 0) || (A4 % 3 == 0)) Console.WriteLine("1"); else Console.WriteLine("0");
        Console.WriteLine();

        
        Console.WriteLine("Задание 5");
        int A5 = 3, B5 = 5;
        if ((A5 % 2 != 0) && (B5 % 2 != 0)) Console.WriteLine("1"); else Console.WriteLine("0");
        Console.WriteLine();

        
        X = false; Y = false; Z = true;
        Console.WriteLine("Задание 6");
        if ((X || Y && !Z)) Console.WriteLine("1"); else Console.WriteLine("0");
        if ((!X && !Y)) Console.WriteLine("1"); else Console.WriteLine("0");
        if (((!X || Y) || Z)) Console.WriteLine("1"); else Console.WriteLine("0");
        Console.WriteLine();

        
        Console.WriteLine("Задание 7");
        double x7 = 1;
        if ((Math.Abs(Math.Cos(x7)) > 1e-9)) Console.WriteLine("1"); else Console.WriteLine("0");
        if ((x7 != 1)) Console.WriteLine("1"); else Console.WriteLine("0");
        Console.WriteLine();

        
        Console.WriteLine("Задание 8");
        int x8 = 0, y8 = 2;
        if ((x8 >= 0) && (y8 * y8 == 4)) Console.WriteLine("1"); else Console.WriteLine("0");
        if (((x8 != 0 || y8 != 0) || (y8 > x8))) Console.WriteLine("1"); else Console.WriteLine("0");
        if (((x8 != 0 || y8 != 0) || (y8 > x8))) Console.WriteLine("1"); else Console.WriteLine("0");
        Console.WriteLine();

        
        Console.WriteLine("Задание 9");
        int x9 = -1, y9 = 0;
        if (((x9 == 0) || (y9 < 0) || (y9 > x9))) Console.WriteLine("1"); else Console.WriteLine("0");
        if (((x9 != 0 || y9 != 0) && (y9 < x9))) Console.WriteLine("1"); else Console.WriteLine("0");
        if (((x9 != 0 || y9 != 0) && (y9 < x9))) Console.WriteLine("1"); else Console.WriteLine("0");
        Console.WriteLine();

        
        A = true; B = false; C = true;
        Console.WriteLine("Задание 10");
        if ((A || !(A && B) || C)) Console.WriteLine("1"); else Console.WriteLine("0");
        if ((!A || C && !(B || C))) Console.WriteLine("1"); else Console.WriteLine("0");
        if (((A || B && !C) || A)) Console.WriteLine("1"); else Console.WriteLine("0");
        Console.WriteLine();

        
        Console.WriteLine("Задание 11");
        int x11 = 0, y11 = 0;
        if (((x11 == 0 || y11 < 1) && (y11 > x11))) Console.WriteLine("1"); else Console.WriteLine("0");
        if ((x11 == 0 || y11 < 1)) Console.WriteLine("1"); else Console.WriteLine("0");

        Console.ReadLine();
    }
}