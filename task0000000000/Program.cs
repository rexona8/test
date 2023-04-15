// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника 
// меньше суммы двух других сторон.

// int ReadInt(string message)
// {
//     System.Console.Write(message);
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// void EqualsNum(int num1, int num2, int num3)
// {
//     int numer = num1;
//     if (numer == num1)
//     {
//         numer = num2;
//         if (numer == num3)
//         {
//             numer = num3;
//             System.Console.Write("Числа равны");
//         }
//         else
//         {
//             System.Console.Write("Числа неравны");
//         }
//     }
// }

// void TheoruInequality(int num1, int num2, int num3, string txt)
// {
//     if (num1 < num2 + num3)
//     {
//         if (num2 < num1 + num3 && num3 < num1 + num2)
//         {
//             txt = ("Теорема верна");
//         }
//     }
// System.Console.WriteLine(txt);
// }

// int side1 = ReadInt("Введите координаты 1 точки: ");
// int side2 = ReadInt("Введите координаты 2 точки: ");
// int side3 = ReadInt("Введите координаты 3 точки: ");
// string text = "Теорема неверна";
// TheoruInequality(side1, side2, side3, text);


// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int ReadInt(string message)
// {
//     System.Console.Write(message);
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// int[] BinaryNum(int num)
// {
//     int[] array = new int[10];
//     for (int i = array.Length - 1; i >= 0; i--)
//     {
//         array[i] = num % 2;
//         num = num / 2;
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

// int number = ReadInt("Введите число: ");
// int[] arr = BinaryNum(number);
// PrintArray(arr);


// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа 
// Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// int ReadInt(string message)
// {
//     System.Console.Write(message);
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// int[] Fibonachi(int num)
// {
//     if (num <= 1)
//     {
//         return new int[1];
//     }
//     int[] array = new int[num];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < array.Length; i++)
//     {
//         array[i] = array[i] - 1 + array[i] - 2;
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

// int number = ReadInt("Введите число: ");
// PrintArray(Fibonachi(number));


// Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int[] Copy(int[] arr)
{
    int[] copyArray = new int[arr.Length];
    for (int i = 0; i < copyArray.Length; i++)
    {
        copyArray[i] = arr[i];
    }
    return copyArray;
}

int[] origin = new int[] {0,1,2,3};
int[] array = origin;
origin [0] = 100;
int[] copied = Copy(origin);
origin[1] = 555;
PrintArray(origin);
PrintArray(array);
PrintArray(copied);