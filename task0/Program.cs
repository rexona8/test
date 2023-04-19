// Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве 
// находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// int ReadInt(string message)
// {
//     System.Console.Write(message);
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// int[,] Create2DArray(int rows, int cols)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите количество столбцов: ");
// int[,] arr = Create2DArray(rows, cols);
// Print2DArray(arr);


// Задача 2: Задайте двумерный массив. Найдите элементы, у которых обе позиции чётные, 
// и замените эти элементы на их квадраты.

// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть 
// вот так:
// 1   4  7  2
// 5  81  2  9
// 8   4  2  4

// int ReadInt(string message)
// {
//     System.Console.Write(message);
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// int[,] Create2DArray(int rows, int cols)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[,] FindEvenSquare(int[,] massive)
// {
//     for (int i = 1; i < massive.GetLength(0); i += 2)
//     {
//         for (int j = 1; j < massive.GetLength(1); j += 2)
//         {
//             massive[i, j] *= massive[i, j];
//         }
//     }
//     return massive;
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите количество столбцов: ");
// int[,] arr = Create2DArray(rows, cols);
// Print2DArray(arr);
// System.Console.WriteLine();
// int[,] arrPlus = FindEvenSquare(arr);
// Print2DArray(arrPlus);


// Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали.
// Например, задан массив:
// 1   4   7
// 5   9   2
// 8   4   2
// Сумма элементов главной диагонали: 1+9+2 = 12

// int ReadInt(string message)
// {
//     System.Console.Write(message);
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// int[,] Create2DArray(int rows, int cols)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int SumDiagonal(int[,] massive)
// {
//     int sum = 0;
//     for (int i = 0; i < massive.GetLength(0); i++)
//     {
//         sum += massive[i, i];
//     }
//     return sum;
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите количество столбцов: ");
// int[,] arr = Create2DArray(rows, cols);
// Print2DArray(arr);
// System.Console.WriteLine($"Сумма главной диагонали равна: {SumDiagonal(arr)} ");


// Задача 4: Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Введенный элемент 2, результат: [1, 4]
// Введенный элемент 6, результат: такого элемента нет.

// int ReadInt(string message)
// {
//     System.Console.Write(message);
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// int[,] Create2DArray(int rows, int cols)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = i + j;
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// (int, int) FindNumber(int[,] arrArr, int num) // кортеж (tuple) - возвращает из функции, несколько значений, больше двух
// {
//     for (int i = 0; i < arrArr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrArr.GetLength(1); j++)
//         {
//             if (arrArr[i, j] == num)
//             {
//                 return (i, j);
//             }
//         }
//     }
//     return (-1, -1);
// }

// int rows = ReadInt("Введите количество строк: ");
// int cols = ReadInt("Введите количество столбцов: ");
// int[,] arr = Create2DArray(rows, cols);
// Print2DArray(arr);
// int number = ReadInt("Введите число для поиска: ");
// (int x, int y) = FindNumber(arr, number);
// if (x != -1)
// {
//     System.Console.WriteLine($"Координаты введенного числа: {x + 1} , {y + 1}");
// }
// else
// {
//     System.Console.WriteLine($"Такого элемента нет");
// }


// Задача 5: Задайте двумерный массив. Найдите максимальный элемент массива и 
// среднее арифметическое всех элементов массива.
// Например, такой массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Максимальный элемент массива 9
// Среднее арифметическое 4.25


int ReadInt(string message)
{
    System.Console.Write(message);
    return System.Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

int FindMax(int[,] array)
{
    int max = array[0, 0];
    foreach (int item in array)
    {
        if (max < item)
        {
            max = item;
        }
    }
    return max;
}

double AverageMax(int[,] array)
{
    double sum = array[0, 0];
    foreach (int item in array)
    {
        sum += item;
    }
    return sum / array.Length;
}

int rows = ReadInt("Введите количество строк: ");
int cols = ReadInt("Введите количество столбцов: ");
int[,] arr = Create2DArray(rows, cols);
Print2DArray(arr);
System.Console.WriteLine($"Максимальное значение равно: {FindMax(arr)}");
System.Console.WriteLine($"Среднее арифметическое равно: {AverageMax(arr)}");