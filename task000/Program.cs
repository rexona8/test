// Задача 2: Задайте значения M и N. Напишите программу, которая рекурсивно выведет 
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

// int ReadInt(string msg)
// {
//     System.Console.Write(msg);
//     return Convert.ToInt32(System.Console.ReadLine());
// }

// void RecurseNumbers(int num1, int num2)
// {
//     if (num1 > num2)
//     {
//         return;
//     }
//     System.Console.Write(num1);
//     RecurseNumbers(num1 + 1, num2);
// }

// int m = ReadInt("Input first number ");
// int n = ReadInt("Input second number ");
// RecurseNumbers(m, n);


// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число 
// А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Power(int a, int b)
{
    if (b < 1)
    {
        return 1;
    }
    return a * Power(a, b - 1);
}
System.Console.WriteLine(Power(3,5));