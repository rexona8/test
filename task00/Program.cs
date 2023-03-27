// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Введите 1 число: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите 2 число: ");
int num2 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите 3 число: ");
int num3 = Convert.ToInt32(System.Console.ReadLine());

int max = num1;
if (max < num2) max = num2;
if (max < num3) max = num3;
System.Console.WriteLine($"Максимальное число: {max}");