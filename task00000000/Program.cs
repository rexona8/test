﻿// Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125

int ReadInt(string message)
{
    System.Console.Write($"{message}");
    return System.Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите число: ");
for (int i = 0; i < number; i++)
{
    System.Console.WriteLine(Math.Pow(i, 3));
}