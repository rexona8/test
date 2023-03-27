// Напишите программу, которая принимает на вход трехзначное число, а на выходе 
// показывает последнюю цифру этого числа.
// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine(number % 10);

// 2. Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

int Maxnumber(int number)
{
    int num1 = num / 10;
    int num2 = num % 10;
    int max = num1;
    if (max < num2)
    {
        max = num2;
    }
    return max;
}

int num = new Random().Next(10, 100);
System.Console.WriteLine($"Наибольшее число из {num} является {Maxnumber(num)}");