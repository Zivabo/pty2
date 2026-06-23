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
                    Console.Write("Введите размер массива: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] arr = new int[size];
                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    int sum = 0;
                    foreach (int num in arr)
                    {
                        sum += num;
                    }
                    Console.WriteLine($"Сумма элементов: {sum}");
                    break;
                }

            case 2:
                {
                    Console.Clear();
                    Console.Write("Введите размер массива: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] arr = new int[size];
                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    int max = arr[0];
                    foreach (int num in arr)
                    {
                        if (num > max)
                            max = num;
                    }
                    Console.WriteLine($"Максимальный элемент: {max}");
                    break;
                }

            case 3:
                {
                    Console.Clear();
                    Console.Write("Введите размер массива: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] arr = new int[size];
                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    int min = arr[0];
                    foreach (int num in arr)
                    {
                        if (num < min)
                            min = num;
                    }
                    Console.WriteLine($"Минимальный элемент: {min}");
                    break;
                }

            case 4:
                {
                    Console.Clear();
                    Console.Write("Введите размер массива: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] arr = new int[size];
                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    double sum = 0;
                    foreach (int num in arr)
                    {
                        sum += num;
                    }
                    double average = sum / size;
                    Console.WriteLine($"Среднее арифметическое: {average}");
                    break;
                }

            case 5:
                {
                    Console.Clear();
                    Console.Write("Введите размер массива: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] arr = new int[size];
                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    Console.Write("Введите число для поиска: ");
                    int search = int.Parse(Console.ReadLine());
                    bool found = false;
                    foreach (int num in arr)
                    {
                        if (num == search)
                        {
                            found = true;
                            break;
                        }
                    }
                    Console.WriteLine(found ? "Число найдено" : "Число не найдено");
                    break;
                }

            case 6:
                {
                    Console.Clear();
                    Console.Write("Введите размер массива: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] arr = new int[size];
                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    Array.Sort(arr);
                    Console.WriteLine("Отсортированный массив: " + string.Join(", ", arr));
                    break;
                }

            case 7:
                {
                    Console.Clear();
                    Console.Write("Введите размер массива: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] arr = new int[size];
                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    Array.Sort(arr);
                    Array.Reverse(arr);
                    Console.WriteLine("Отсортированный массив: " + string.Join(", ", arr));
                    break;
                }

            case 8:
                {
                    Console.Clear();
                    Console.Write("Введите размер массива: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] arr = new int[size];
                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    int evenCount = 0;
                    foreach (int num in arr)
                    {
                        if (num % 2 == 0)
                            evenCount++;
                    }
                    Console.WriteLine($"Количество чётных элементов: {evenCount}");
                    break;
                }

            case 9:
                {
                    Console.Clear();
                    Console.Write("Введите размер массива: ");
                    int size = int.Parse(Console.ReadLine());
                    int[] arr = new int[size];
                    Console.WriteLine("Введите элементы массива:");
                    for (int i = 0; i < size; i++)
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    int oddCount = 0;
                    foreach (int num in arr)
                    {
                        if (num % 2 != 0)
                            oddCount++;
                    }
                    Console.WriteLine($"Количество нечётных элементов: {oddCount}");
                    break;
                }

            case 10:
                {
                    Console.Clear();
                    Console.Write("Введите строку: ");
                    string input = Console.ReadLine();
                    char[] chars = input.ToCharArray();
                    Array.Reverse(chars);
                    string reversed = new string(chars);
                    Console.WriteLine(input == reversed ? "Палиндром" : "Не палиндром");
                    break;
                }

            case 11:
                {
                    Console.Clear();
                    Console.Write("Введите строку: ");
                    string input = Console.ReadLine();
                    Console.WriteLine($"Длина строки: {input.Length}");
                    break;
                }

            case 12:
                {
                    Console.Clear();
                    Console.Write("Введите строку: ");
                    string input = Console.ReadLine();
                    string replaced = input.Replace(' ', '_');
                    Console.WriteLine($"Результат: {replaced}");
                    break;
                }

            case 13:
                {
                    Console.Clear();
                    Console.Write("Введите строку: ");
                    string input = Console.ReadLine();
                    string vowels = "aeiouAEIOUаеиоуАЕИОУ";
                    int vowelCount = 0;
                    foreach (char c in input)
                    {
                        if (vowels.Contains(c))
                            vowelCount++;
                    }
                    Console.WriteLine($"Количество гласных: {vowelCount}");
                    break;
                }

            case 14:
                {
                    Console.Clear();
                    Console.Write("Введите строку: ");
                    string input = Console.ReadLine();
                    string vowels = "aeiouAEIOUаеиоуАЕИОУ";
                    int consonantCount = 0;
                    foreach (char c in input)
                    {
                        if (char.IsLetter(c) && !vowels.Contains(c))
                            consonantCount++;
                    }
                    Console.WriteLine($"Количество согласных: {consonantCount}");
                    break;
                }

            case 15:
                {
                    Console.Clear();
                    Console.Write("Введите строку: ");
                    string input = Console.ReadLine();
                    char[] chars = input.ToCharArray();
                    Array.Reverse(chars);
                    Console.WriteLine($"Результат: {new string(chars)}");
                    break;
                }

            default:
                Console.WriteLine("Неверный номер задачи.");
                break;
        }
    }
}