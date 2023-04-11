// Задача 1: Напишите программу замены элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// int ReadInt(string msg) // чтение вводимых данных с клавиатуры
// {
//     System.Console.Write($"{msg}");
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// int[] CreateArray(int length, int minRnd, int maxRnd) // создание массива
// {
//     int[] array = new int[length];
//     Random var = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = var.Next(minRnd, maxRnd);
//     }
//     return array;
// }

// void PrintArray(int[] array) // печать массива
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]}\t");
//     }
//     System.Console.WriteLine();
// }

// void Reverse(int[] array) // замена значений отрицательных на положительные
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
// }

// int len = ReadInt("Введите длину: ");
// int min = ReadInt("Введите минимальное число: ");
// int max = ReadInt("Введите максимальное число: ");
// int[]array = CreateArray(len, min, max);
// PrintArray(array);
// Reverse(array);
// PrintArray(array);


// Задача 1: Задайте массив из 12 элементов, заполненный случайными числами 
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
// равна 29, сумма отрицательных равна -20.

// int ReadInt(string msg)
// {
//     System.Console.Write($"{msg}");
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// int[] CreateArray(int length, int minRnd, int maxRnd)
// {
//     int[] array = new int[length];
//     Random rnd = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = rnd.Next(minRnd, maxRnd + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]}\t");
//     }
//     System.Console.WriteLine();
// }

// int SumSign(int[] array, bool isPositive = true)
// {
//     int sign = 1;
//     if (!isPositive)
//     {
//         sign = -1;
//     }
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] * sign > 0)
//         {
//             sum += array[i];
//         }
//     }
//     return sum;
// }

// int len = ReadInt("Введите длину массива: ");
// int min = ReadInt("Введите минимальную границу: ");
// int max = ReadInt("Введите максимальную границу: ");
// int[] array = CreateArray(len, min, max);
// PrintArray(array);
// System.Console.WriteLine($"Сумма положительных значений {SumSign(array)}");
// System.Console.WriteLine($"Сумма отрицательных значений {SumSign(array, false)}");


// Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует 
// ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

// int ReadInt(string msg)
// {
//     System.Console.Write($"{msg}");
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// int[] CreateArray(int length, int minRnd, int maxRnd)
// {
//     int[] array = new int[length];
//     Random rnd = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = rnd.Next(minRnd, maxRnd + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]}\t");
//     }
//     System.Console.WriteLine();
// }

// bool FindNum(int[] array, int number)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == number)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// int len = ReadInt("Введите длину массива: ");
// int min = ReadInt("Введите минимальную границу: ");
// int max = ReadInt("Введите максимальную границу: ");
// int[] array = CreateArray(len, min, max);
// PrintArray(array);
// int number = ReadInt("Введите число: ");
// if (FindNum(array, number))
// {
//     System.Console.WriteLine($"Число {number} присутствует в массиве");
// }
// else
// {
//     System.Console.WriteLine($"Числа {number} нет в массиве");
// }


// Задача 3: Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200.
// Найдите количество  двузначных элементов массива. 
// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int ReadInt(string msg)
// {
//     System.Console.Write($"{msg}");
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// int[] CreateArray(int length, int minRnd, int maxRnd)
// {
//     int[] array = new int[length];
//     Random rnd = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = rnd.Next(minRnd, maxRnd + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write($"{array[i]}\t");
//     }
//     System.Console.WriteLine();
// }

// int FindNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 9 && array[i] < 100)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int len = ReadInt("Введите длину массива: ");
// int min = ReadInt("Введите минимальную границу: ");
// int max = ReadInt("Введите максимальную границу: ");
// int[] array = CreateArray(len, min, max);
// PrintArray(array);
// int numbers = FindNumbers(array);
// System.Console.WriteLine($"Колличество двухзначных чисел составляет {numbers}");


// Задача 4: Найдите произведение пар чисел в одномерном массиве. Парой считаем 
// первый и последний элемент, второй и предпоследний и т.д. Результат запишите 
// в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int ReadInt(string msg)
{
    System.Console.Write($"{msg}");
    return System.Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int length, int minRnd, int maxRnd)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(minRnd, maxRnd + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int[] Multipair(int[] mas)
{
    int[] res = new int[mas.Length / 2 + mas.Length % 2];
    int iLastRes = res.Length - 1;
    res[iLastRes] = mas[iLastRes];
    for (int i = 0; i < mas.Length / 2; i++)
    {
        res[i] = mas[i] * mas[mas.Length - 1 - i];
    }
    return res;
}

int len = ReadInt("Введите длину массива: ");
int min = ReadInt("Введите минимальную границу: ");
int max = ReadInt("Введите максимальную границу: ");
int[] array = CreateArray(len, min, max);
PrintArray(array);
PrintArray(Multipair(array));