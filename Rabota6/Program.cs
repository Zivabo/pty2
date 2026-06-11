using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер задачи (1-14):");
        int task = int.Parse(Console.ReadLine());

        switch (task)
        {
            case 1:
                Console.Clear();
                int[] arr = new int[14];
                Console.WriteLine("Введите 14 целых чисел:");
                for (int i = 0; i < 14; i++)
                {
                    arr[i] = int.Parse(Console.ReadLine());
                }
                int evenCount = 0;
                foreach (int num in arr)
                {
                    if (num % 2 == 0) evenCount++;
                }
                Console.WriteLine($"Количество чётных: {evenCount}");
                break;

            case 2:
                Console.Clear();
                int[] arr2 = new int[12];
                Console.WriteLine("Введите 12 целых чисел:");
                for (int i = 0; i < 12; i++)
                {
                    arr2[i] = int.Parse(Console.ReadLine());
                }
                double avg = 0;
                foreach (int num in arr2) avg += num;
                avg /= 12;
                for (int i = 0; i < 12; i++)
                {
                    arr2[i] = (int)avg;
                }
                Console.WriteLine("Новый массив: " + string.Join(", ", arr2));
                break;

            case 3:
                Console.Clear();
                int[] arr3 = new int[11];
                Console.WriteLine("Введите 11 целых чисел:");
                for (int i = 0; i < 11; i++)
                {
                    arr3[i] = int.Parse(Console.ReadLine());
                }
                avg = 0;
                foreach (int num in arr3) avg += num;
                avg /= 11;
                int count3 = 0;
                foreach (int num in arr3)
                {
                    if (Math.Abs(num) > avg) count3++;
                }
                Console.WriteLine($"Количество: {count3}");
                break;

            case 4:
                Console.Clear();
                int[] arr4 = new int[16];
                Console.WriteLine("Введите 16 целых чисел:");
                for (int i = 0; i < 16; i++)
                {
                    arr4[i] = int.Parse(Console.ReadLine());
                }
                int maxIndex = 0;
                for (int i = 1; i < 16; i++)
                {
                    if (arr4[i] > arr4[maxIndex]) maxIndex = i;
                }
                int temp = arr4[0];
                arr4[0] = arr4[maxIndex];
                arr4[maxIndex] = temp;
                Console.WriteLine("Новый массив: " + string.Join(", ", arr4));
                break;

            case 5:
                Console.Clear();
                int[] arr5 = new int[9];
                Console.WriteLine("Введите 9 целых чисел:");
                for (int i = 0; i < 9; i++)
                {
                    arr5[i] = int.Parse(Console.ReadLine());
                }
                int max = arr5[0], min = arr5[0];
                int maxIndex5 = 0, minIndex = 0;
                for (int i = 1; i < 9; i++)
                {
                    if (arr5[i] > max)
                    {
                        max = arr5[i];
                        maxIndex5 = i;
                    }
                    if (arr5[i] < min)
                    {
                        min = arr5[i];
                        minIndex = i;
                    }
                }
                temp = arr5[maxIndex5];
                arr5[maxIndex5] = arr5[minIndex];
                arr5[minIndex] = temp;
                Console.WriteLine("Новый массив: " + string.Join(", ", arr5));
                break;

            case 6:
                Console.Clear();
                int[] arr6 = new int[20];
                Console.WriteLine("Введите 20 целых чисел:");
                for (int i = 0; i < 20; i++)
                {
                    arr6[i] = int.Parse(Console.ReadLine());
                }
                int evenCount6 = 0, oddCount = 0;
                foreach (int num in arr6)
                {
                    if (num % 2 == 0) evenCount6++;
                    else oddCount++;
                }
                Console.WriteLine($"Чётных: {evenCount6}, Нечётных: {oddCount}");
                break;

            case 7:
                Console.Clear();
                double[] arr7 = new double[15];
                Console.WriteLine("Введите 15 вещественных чисел:");
                for (int i = 0; i < 15; i++)
                {
                    arr7[i] = double.Parse(Console.ReadLine());
                }
                double first = arr7[0];
                int count7 = 0;
                foreach (double num in arr7)
                {
                    if (num > first) count7++;
                }
                Console.WriteLine($"Количество: {count7}");
                break;

            case 8:
                Console.Clear();
                double[] arr8 = new double[16];
                Console.WriteLine("Введите 16 вещественных чисел:");
                for (int i = 0; i < 16; i++)
                {
                    arr8[i] = double.Parse(Console.ReadLine());
                }
                double max8 = arr8[0], min8 = arr8[0];
                int maxIndex8 = 0, minIndex8 = 0;
                for (int i = 1; i < 16; i++)
                {
                    if (arr8[i] > max8)
                    {
                        max8 = arr8[i];
                        maxIndex8 = i;
                    }
                    if (arr8[i] < min8)
                    {
                        min8 = arr8[i];
                        minIndex8 = i;
                    }
                }
                Console.WriteLine($"Индекс максимального: {maxIndex8}, Индекс минимального: {minIndex8}");
                break;

            case 9:
                Console.Clear();
                double[] arr9 = new double[15];
                Console.WriteLine("Введите 15 вещественных чисел:");
                for (int i = 0; i < 15; i++)
                {
                    arr9[i] = double.Parse(Console.ReadLine());
                }
                avg = 0;
                foreach (double num in arr9) avg += num;
                avg /= 15;
                for (int i = 0; i < 15; i++)
                {
                    arr9[i] -= avg;
                }
                Console.WriteLine("Новый массив: " + string.Join(", ", arr9));
                break;

            case 10:
                Console.Clear();
                int[] arr10 = new int[17];
                Console.WriteLine("Введите 17 целых чисел (положительных и отрицательных):");
                for (int i = 0; i < 17; i++)
                {
                    arr10[i] = int.Parse(Console.ReadLine());
                }
                int sumPos = 0, sumNeg = 0;
                foreach (int num in arr10)
                {
                    if (num > 0) sumPos += num;
                    else if (num < 0) sumNeg += num;
                }
                Console.WriteLine($"Сумма положительных: {sumPos}, Сумма отрицательных: {sumNeg}");
                break;

            case 11:
                Console.Clear();
                int[] arr11 = new int[14];
                Console.WriteLine("Введите 14 целых чисел:");
                for (int i = 0; i < 14; i++)
                {
                    arr11[i] = int.Parse(Console.ReadLine());
                }
                int count11 = 0, sum11 = 0;
                foreach (int num in arr11)
                {
                    if (num > 0 && num % 2 == 0)
                    {
                        count11++;
                        sum11 += num;
                    }
                }
                Console.WriteLine($"Количество: {count11}, Сумма: {sum11}");
                break;

            case 12:
                Console.Clear();
                double[] arr12 = new double[12];
                Console.WriteLine("Введите 12 вещественных чисел:");
                for (int i = 0; i < 12; i++)
                {
                    arr12[i] = double.Parse(Console.ReadLine());
                }
                Array.Sort(arr12);
                Array.Reverse(arr12);
                double sum12 = arr12[0] + arr12[11];
                Console.WriteLine($"Сумма максимального и минимального: {sum12}");
                break;

            case 13:
                Console.Clear();
                int[] arr13 = new int[15];
                Console.WriteLine("Введите 15 целых чисел:");
                for (int i = 0; i < 15; i++)
                {
                    arr13[i] = int.Parse(Console.ReadLine());
                }
                int max13 = arr13[0], min13 = arr13[0];
                foreach (int num in arr13)
                {
                    if (num > max13) max13 = num;
                    if (num < min13) min13 = num;
                }
                Console.WriteLine($"Сумма: {max13 + min13}, Разность: {max13 - min13}");
                break;

            case 14:
                Console.Clear();
                int[] arr14 = new int[17];
                Console.WriteLine("Введите 17 целых чисел:");
                for (int i = 0; i < 17; i++)
                {
                    arr14[i] = int.Parse(Console.ReadLine());
                }
                int sumOdd = 0;
                foreach (int num in arr14)
                {
                    if (num % 2 != 0) sumOdd += num;
                }
                for (int i = 0; i < 17; i++)
                {
                    if (arr14[i] % 3 == 0) arr14[i] = sumOdd;
                }
                Console.WriteLine("Новый массив: " + string.Join(", ", arr14));
                break;

            default:
                Console.WriteLine("Неверный номер задачи.");
                break;
        }
    }
}