// Задача 3: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] CreateArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

int Count1(int[] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            count++;
        }
    }
    return count;
}

int ReadInt(string message)
{
    System.Console.Write($"{message} = ");
    return System.Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("Введите число:");
int[] writeArray = CreateArray();
PrintArray(writeArray);
System.Console.WriteLine($"Количество заданного числа в массиве = {Count1(writeArray, number)}");