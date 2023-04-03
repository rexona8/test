// 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём 
// X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
//   2    |    1
//  -------------
//   3    |    4

// int ReadInt(string message)
// {
//     System.Console.Write($"{message} = ");
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// int Quarter(int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         return 1;
//     }
//     if (x < 0 && y > 0)
//     {
//         return 2;
//     }
//     if (x < 0 && y < 0)
//     {
//         return 3;
//     }
//     if (x > 0 && y < 0)
//     {
//         return 4;
//     }
//     return 0;
// }

// bool ValidateXY(int x, int y)
// {
//     if (x == 0 || y == 0)
//     {
//         System.Console.WriteLine("Координата находится на оси");
//         return false;
//     }
//     return true;
// }

// int x = ReadInt("Введите x");
// int y = ReadInt("Введите y");
// int numberQuorter = Quarter(x, y);
// if (ValidateXY(x, y))
// {
//     System.Console.WriteLine($"Номер четверти для X,Y ({x}, {y}) равна {numberQuorter}");
// }


// Задача 2: Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).

// int ReadInt(string message)
// {
//     System.Console.Write($"{message} = ");
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// string GetRange(int quorter) // возвращает строку
// {
//     if (quorter == 1)
//     {
//         return ("x > 0 y > 0");
//     }
//     if (quorter == 2)
//     {
//         return ("x < 0 y > 0");
//     }
//     if (quorter == 3)
//     {
//         return ("x < 0 y < 0");
//     }
//     return ("x > 0 y < 0");
// }

// bool ValidateXY(int quorter)
// {
//     if (quorter < 1 || quorter > 4)
//     {
//         System.Console.WriteLine("Такой четверти не существует");
//         return false;
//     }
//     return true;
// }

// int numberA = ReadInt("Введите значение");
// if (ValidateXY(numberA))
// {
//     string range = GetRange(numberA);
//     System.Console.WriteLine(range);
// }


// Задача 3: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// int ReadInt(string message)
// {
//     System.Console.Write($"{message} = ");
//     return System.Convert.ToInt32(Console.ReadLine());
// }

// int aX = ReadInt("Введите координату Х первой точки: ");
// int aY = ReadInt("Введите координату Y первой точки: ");
// int bX = ReadInt("Введите координату Х второй точки: ");
// int bY = ReadInt("Введите координату Y второй точки: ");

// double coordX = (aX - bX);
// double coordY = (aY - bY);
// double sum = Math.Sqrt(Math.Pow(coordX, 2) + Math.Pow(coordY, 2));
// System.Console.Write($"Результат {sum :F2}");


// Задача 4: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

int ReadInt(string message)
{
    System.Console.Write($"{message} = ");
    return System.Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите число: ");

for (int i = 0; i <= number; i++)
{
    System.Console.Write($"{Math.Pow(i, 2)} ");
}