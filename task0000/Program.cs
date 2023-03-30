// 3. Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// int ReadInt(string message)
// {
//     System.Console.WriteLine($"{message}");
//     int value = Convert.ToInt32(System.Console.ReadLine());
//     return value;
// }

// int num1 = ReadInt("input 1st number");
// int num2 = ReadInt("input 2nd number");
// int remains = num1 % num2;
// if (remains == 0)
// {
//     System.Console.WriteLine("Второе число кратно первому");
// }
// else
// {
//     System.Console.WriteLine($"Не кратно, остаток {remains}");
// }


// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно 
// одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int ReadInt(string message)
{
    System.Console.WriteLine($"{message}");
    int value = Convert.ToInt32(System.Console.ReadLine());
    return value;
}

int num = ReadInt("input number");

if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine("the number is a multiple of 7 and 23");
}
else
{
    System.Console.WriteLine("not multiple");
}