// Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.

// int ReadInt(string message)
// {
//     System.Console.Write(message);
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// int[,] Create2DArray(int rows, int cols)
// {
//     int[,] arr = new int[rows, cols];
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = i + j;
//         }
//     }
//     return arr;
// }

// void Print2DArray(int[,] massive)
// {
//     for (int i = 0; i < massive.GetLength(0); i++)
//     {
//         for (int j = 0; j < massive.GetLength(1); j++)
//         {
//             System.Console.Write($"{massive[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void Swap(int[,] array)
// {
//     int lastrow = array.GetLength(0) - 1;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         int temp = array[0, j];
//         array[0, j] = array[lastrow, j];
//         array[lastrow, j] = temp;
//     }
// }

// int rows = ReadInt("Введите кол-во строк: ");
// int cols = ReadInt("Введите кол-во столбцов: ");
// int[,] array = Create2DArray(rows, cols);
// System.Console.WriteLine();
// Print2DArray(array);
// System.Console.WriteLine();
// Swap(array);
// Print2DArray(array);


// Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки 
// на столбцы. В случае, если это невозможно, программа должна вывести сообщение 
// для пользователя.

// int ReadInt(string message)
// {
//     System.Console.Write(message);
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// int[,] Create2DArray(int rows, int cols)
// {
//     int[,] arr = new int[rows, cols];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = rnd.Next(-10,11);
//         }
//     }
//     return arr;
// }

// void Print2DArray(int[,] massive)
// {
//     for (int i = 0; i < massive.GetLength(0); i++)
//     {
//         for (int j = 0; j < massive.GetLength(1); j++)
//         {
//             System.Console.Write($"{massive[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// void ReverseColsRows(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = i; j < arr.GetLength(1); j++)
//         {
//             int temp = arr[i, j];
//             arr[i, j] = arr[j, i];
//             arr[j, i] = temp;
//         }
//     }
// }

// int rows = ReadInt("Введите кол-во строк: ");
// int cols = ReadInt("Введите кол-во столбцов: ");
// int[,] array = Create2DArray(rows, cols);
// System.Console.WriteLine();
// Print2DArray(array);
// System.Console.WriteLine();
// ReverseColsRows(array);
// Print2DArray(array);


// Задача 3: Составить частотный словарь элементов двумерного массива. Частотный 
// словарь содержит информацию о том, сколько раз встречается элемент входных 
// данных. Значения элементов массива 0..9

// int ReadInt(string message)
// {
//     System.Console.Write(message);
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// int[,] Create2DArray(int rows, int cols)
// {
//     int[,] arr = new int[rows, cols];
//     Random rnd = new Random();
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = rnd.Next(0, 10);
//         }
//     }
//     return arr;
// }

// void Print2DArray(int[,] massive)
// {
//     for (int i = 0; i < massive.GetLength(0); i++)
//     {
//         for (int j = 0; j < massive.GetLength(1); j++)
//         {
//             System.Console.Write($"{massive[i, j]}\t");
//         }
//         System.Console.WriteLine();
//     }
// }

// int[] Freqence(int[,] array)
// {
//     int[] group = new int[10];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             int index = array[i, j];
//             group[index]++;
//         }
//     }
//     return group;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.WriteLine($"{i} - {arr[i]}");
//     }
// }

// int rows = ReadInt("Введите кол-во строк: ");
// int cols = ReadInt("Введите кол-во столбцов: ");
// int[,] array = Create2DArray(rows, cols);
// System.Console.WriteLine();
// Print2DArray(array);
// int[] grArr = Freqence(array);
// System.Console.WriteLine();
// PrintArray(grArr);


// Задача 4: Задайте двумерный массив из целых чисел. Напишите программу, которая 
// удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int ReadInt(string message)
{
    System.Console.Write(message);
    return System.Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int rows, int cols)
{
    int[,] arr = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 10);
        }
    }
    return arr;
}

void Print2DArray(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            System.Console.Write($"{massive[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

(int, int) MinIndex(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[minI, minJ] > array[i, j])
            {
                minI = i;
                minJ = j;
            }
        }
    }
    return (minI, minJ);
}

int[,] DeleteMinElement(int[,] array)
{
    (int minI, int minJ) = MinIndex(array);
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int ind1 = 0;
    int ind2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (minI == i)
        {
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minJ == j)
            {
                continue;
            }
            result[ind1, ind2] = array[i, j];
            ind2++;
        }
        ind1++;
        ind2 = 0;
    }
    return result;
}

int rows = ReadInt("Введите кол-во строк: ");
int cols = ReadInt("Введите кол-во столбцов: ");
int[,] array = Create2DArray(rows, cols);
Print2DArray(array);
System.Console.WriteLine(MinIndex(array));
Print2DArray(DeleteMinElement(array));